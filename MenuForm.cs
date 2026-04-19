using Postgrest.Attributes;
using Postgrest.Models;
using Supabase.Gotrue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RaidLog
{
    public partial class MenuForm : Form
    {
        // Supabaseクライアント保存
        private Supabase.Client supabase;

        // ログアウト中かどうか
        private bool isLoggingOut = false;

        // 選択したラジオボタンでモード保持
        private ProcMode currentMode = ProcMode.Regist;

        // 選択中を保持
        private PlayLog currentPlayLog = null;

        public MenuForm(Supabase.Client client)
        {
            InitializeComponent();
            this.supabase = client;
        }

        #region 初期化・読み込み
        // 読み込み時の処理
        private async void MenuForm_Load(object sender, EventArgs e)
        {
            // 初期表示
            rdoRegist.Checked = true;
            currentMode = ProcMode.Regist;

            // 初期化
            ResetForm(true);
            try
            {
                // ログインユーザー情報を取得する
                var user = supabase.Auth.CurrentUser;

                if (user != null)
                {
                    // Profileテーブルを対象に
                    // 1行をxとしてIdがログインIDと一致するものを検索。SQLのWHEREと同じ役目
                    // Single()1件だけ
                    var profile = await supabase.From<Profile>().Where(x => x.Id == user.Id).Single();

                    if (profile != null)
                    {
                        username.Text = $"{profile.UserName}のマイページ";

                        // 管理者の場合のみ管理者用ボタンを表示
                        btnAdmin.Visible = (profile.UserName == "admin");
                    }
                    await LoadMasters();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("情報取得に失敗");
            }
        }

        // 変数定義
        private List<ContentMaster> _allContents = new List<ContentMaster>();

        // マスタデータ取得してコンボボックスへ
        private async Task LoadMasters()
        {
            try
            {
                // content_tableからマスタを取得
                var result = await supabase.From<ContentMaster>()
                    .Order(x => x.ContentOrder, Postgrest.Constants.Ordering.Ascending)
                    .Order(x => x.DisplayOrder, Postgrest.Constants.Ordering.Ascending)
                    .Get();

                // フェーズ絞りこみで使用
                _allContents = result.Models;

                // コンテンツ名コンボボックス（重複削除）
                var contentNames = result.Models
                    .Select(x => x.ContentName)
                    .Distinct()
                    .ToList();

                cmbContent.DataSource = contentNames;
                cmbContent.SelectedIndex = -1;

                // フェーズ初期化
                cmbPhase.DataSource = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("マスタ取得エラー" + ex.Message);
            }
        }

        private void ResetForm(bool fullClear = true)
        {
            lblSelectedId.Text = "";

            if (lblTotalTime != null)
            {
                lblTotalTime.Text = "現在：0回と0時間0分";
            }

            if (fullClear)
            {
                listView1.Items.Clear();         // PTメンバー表をクリア
                lblSelectedDate.Text = "";       // 日付ラベルをクリア
                txtStartTime.Text = "";          // 開始時間をクリア
                txtEndTime.Text = "";            // 終了時間をクリア
                txtMemo.Text = "";               // 自由記入欄をクリア
                txtYoutube.Text = "";            // 配信URLをクリア
                txtFflogs.Text = "";             // FFLogsをクリア
                txtOther.Text = "";              // その他URLをクリア
                txtNextPhase.Text = "";          // 次回攻略予定をクリア

                // コンボボックスは選択を解除させる
                cmbContent.SelectedIndex = -1;
                cmbPhase.DataSource = null;
                cmbPhaseDetail.DataSource = null;

                lblNextDay.Text = "";

            }
        }
        #endregion

        // 時間計算
        private int CalculateDuration(string startText, string endText)
        {
            if (TimeSpan.TryParse(startText, out var start) && TimeSpan.TryParse(endText, out var end))
            {
                // 終了が開始より前なら翌日扱い(24時間加算してから計算)
                var duration = (end < start) ? (end.Add(TimeSpan.FromDays(1)) - start) : (end - start);
                // TotalMinutesをintで返す
                return (int)duration.TotalMinutes;
            }
            return 0;
        }

        private void cmbContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedContent = cmbContent.Text;
            if (string.IsNullOrEmpty(selectedContent)) return;

            // LoadMasters()で取得した_allContentsを使う
            var phases = _allContents
                .Where(x => x.ContentName == selectedContent)
                .OrderBy(x => x.DisplayOrder)
                .Select(XmlReadMode => XmlReadMode.PhaseName)
                .Distinct()
                .ToList();

            cmbPhase.DataSource = phases;
            cmbPhase.SelectedIndex = -1; // 初期状態は未選択
            cmbPhaseDetail.DataSource = null;
        }

        // フェーズ名に応じてフェーズ詳細を出す
        private void cmbPhase_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedContent = cmbContent.Text;
            string selectedPhase = cmbPhase.Text;

            if (string.IsNullOrEmpty(selectedContent) ||
                    string.IsNullOrEmpty(selectedPhase)) return;

            var details = _allContents
        .Where(x => x.ContentName == selectedContent && x.PhaseName == selectedPhase)
        .OrderBy(x => x.DisplayOrder)
        .Select(x => x.DetailGimmick)
        .Where(x => !string.IsNullOrEmpty(x)) // 空文字除外
        .Distinct()
        .ToList();

            cmbPhaseDetail.DataSource = details;
            cmbPhaseDetail.SelectedIndex = -1;
        }

        private PlayLog CreatePlayLog(string userId, DateTime playDate, int duration)
        {
            var log = new PlayLog
            {
                // supabaseに送るIDがnullになっちゃうのでここで新規の場合に作ってしまう
                Id = string.IsNullOrEmpty(lblSelectedId.Text)? Guid.NewGuid()
                .ToString() : lblSelectedId.Text,

                Userid = userId,
                PlayDate = playDate,
                StartTime = txtStartTime.Text,
                EndTime = txtEndTime.Text,
                DurationMinutes = duration,
                ContentName = cmbContent.Text,
                CurrentPhase = cmbPhase.Text,
                PhaseDetail = cmbPhaseDetail.Text,
                NextPhase = txtNextPhase.Text,
                Memo = txtMemo.Text,
                UrlYoutube = txtYoutube.Text,
                UrlFflogs = txtFflogs.Text,
                UrlOther = txtOther.Text,

                // 下記にPT構成の情報
                Member1 = currentPlayLog.Member1,
                Member2 = currentPlayLog.Member2,
                Member3 = currentPlayLog.Member3,
                Member4 = currentPlayLog.Member4,
                Member5 = currentPlayLog.Member5,
                Member6 = currentPlayLog.Member6,
                Member7 = currentPlayLog.Member7,
                Member8 = currentPlayLog.Member8
            };

            // 既存データ編集（lblSelectedIdがある）場合のみIdをセットする
            if (!string.IsNullOrEmpty(lblSelectedId.Text))
            {
                log.Id = lblSelectedId.Text;
            }

            return log;
        }

        // 登録ボタン押下処理
        private async void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                var user = supabase.Auth.CurrentUser;
                if (user == null) return;

                // 必須チェック
                if (string.IsNullOrWhiteSpace(cmbContent.Text))
                {
                    MessageBox.Show("コンテンツ名を選択または入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbContent.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(cmbPhase.Text))
                {
                    MessageBox.Show("攻略フェーズを選択してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbPhase.Focus();
                    return;
                }

                // フェーズはまだマスタ完成していないのでとりあえず空いててもいい
                //if (string.IsNullOrWhiteSpace(cmbPhaseDetail.Text))
                //{
                //    MessageBox.Show("フェーズ詳細を入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    cmbPhaseDetail.Focus();
                //    return;
                //}

                if (string.IsNullOrWhiteSpace(txtStartTime.Text) || string.IsNullOrWhiteSpace(txtEndTime.Text))
                {
                    MessageBox.Show("開始時間と終了時間を入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 削除モード
                if (currentMode == ProcMode.Delete)
                {
                    await ExecuteDelete();
                    return;
                }

                // 登録・修正モード
                int totalMinutes = CalculateDuration(txtStartTime.Text, txtEndTime.Text);
                var logData = CreatePlayLog(user.Id, calendarLog.SelectionStart, totalMinutes);

                await supabase.From<PlayLog>().Upsert(logData);

                MessageBox.Show("活動内容を記録しました。");
                ResetForm(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("記録処理に失敗。エラー：" + ex.Message);
            }
        }

        // 削除処理
        private async Task ExecuteDelete()
        {
            if (string.IsNullOrEmpty(lblSelectedId.Text))
            {
                MessageBox.Show("日付を選択してください。");
                return;
            }
            var dr = MessageBox.Show("選択した日付の記録を削除しますか？", "削除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                await supabase.From<PlayLog>().Where(x => x.Id == lblSelectedId.Text).Delete();
                MessageBox.Show("記録を削除しました。");
                ResetForm(true);
            }
        }

        // カレンダー日付選択処理
        private async void calendarLog_DateSelected(object sender, DateRangeEventArgs e)
        {
            // ユーザーの国に合わせる記法
            lblSelectedDate.Text = e.Start.ToString("D", CultureInfo.CurrentCulture);

            try
            {
                var user = supabase.Auth.CurrentUser;
                if (user == null) return;

                // 既に選択日付にデータが登録されているかをチェックする
                var result = await supabase.From<PlayLog>()
                    .Where(x => x.Userid == user.Id)
                    .Where(x => x.PlayDate == e.Start)
                    .Get();

                currentPlayLog = result.Models.FirstOrDefault();

                if (currentPlayLog != null)
                {
                    // 3. データがある場合：各コントロールに値をセット
                    lblSelectedId.Text = currentPlayLog.Id; // 重要：Upsertで「更新」にするためにIDを保持
                    txtStartTime.Text = currentPlayLog.StartTime;
                    txtEndTime.Text = currentPlayLog.EndTime;
                    cmbContent.Text = currentPlayLog.ContentName;
                    cmbPhase.Text = currentPlayLog.CurrentPhase;
                    cmbPhaseDetail.Text = currentPlayLog.PhaseDetail;
                    txtNextPhase.Text = currentPlayLog.NextPhase;
                    txtMemo.Text = currentPlayLog.Memo;
                    txtYoutube.Text = currentPlayLog.UrlYoutube;
                    txtFflogs.Text = currentPlayLog.UrlFflogs;
                    txtOther.Text = currentPlayLog.UrlOther;

                    // メイン画面のPTリストも表示させる
                    DisplayPatyList();

                }
                else
                {
                    // PTメンバーは、直近の活動メンバーを表示させる

                    // データ無しの場合は新規作成状態できるようにクリアする
                    ResetForm(false);
                    lblSelectedId.Text = "";

                    // 入力欄をすべて手動でクリア（前の日のデータを残さないため）
                    txtStartTime.Clear();
                    txtEndTime.Clear();
                    cmbContent.SelectedIndex = -1;
                    cmbPhase.SelectedIndex = -1;
                    cmbPhaseDetail.SelectedIndex = -1;
                    txtNextPhase.Clear();
                    txtMemo.Clear();
                    txtYoutube.Clear();
                    txtFflogs.Clear();
                    txtOther.Clear();

                    // 選択日より過去の最新データ1件を取得
                    var lastData = await supabase.From<PlayLog>()
                        .Where(x => x.Userid == user.Id)
                        .Where(x => x.PlayDate < e.Start)
                        .Order(x => x.PlayDate, Postgrest.Constants.Ordering.Descending)
                        .Limit(1)
                        .Get();

                    var prevLog = lastData.Models.FirstOrDefault();

                    // 新規登録時の場合
                    currentPlayLog = new PlayLog
                    {
                        Userid = user.Id,
                        PlayDate = e.Start,
                        // 過去データがあればメンバーだけコピー、なければnull
                        // オプショナルにしないと、過去にデータが無い場合クラッシュしちゃう
                        Member1 = prevLog?.Member1,
                        Member2 = prevLog?.Member2,
                        Member3 = prevLog?.Member3,
                        Member4 = prevLog?.Member4,
                        Member5 = prevLog?.Member5,
                        Member6 = prevLog?.Member6,
                        Member7 = prevLog?.Member7,
                        Member8 = prevLog?.Member8
                    };
                }
                    // PT編成のリストビューを更新（データがあれば表示、なければ空行8行になる）
                    DisplayPatyList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("データ取得中エラー: " + ex.Message);
            }
        }

        // 登録・編集モード
        private void rdoRegist_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRegist.Checked)
            {
                currentMode = ProcMode.Regist;
                btnExecute.Text = "登録・更新";
                btnExecute.BackColor = SystemColors.Control;
            }
        }

        // 削除モード
        private void rdoDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDelete.Checked)
            {
                currentMode = ProcMode.Delete;
                btnExecute.Text = "削除実行";
                btnExecute.BackColor = Color.MistyRose; // 警告色のつもり
            }
        }

        private void OnTimeChanged(object sender, EventArgs e)
        {
            UpdateTimeLabel();
        }

        private void UpdateTimeLabel()
        {
            TimeSpan start, end;

            if (TimeSpan.TryParse(txtStartTime.Text, out start) &&
                TimeSpan.TryParse(txtEndTime.Text, out end))
            {
                // 終了日より前の時間のとき翌日とわかるように表示
                if (end < start)
                {
                    lblNextDay.Text = "(翌日)";
                    lblNextDay.ForeColor = Color.Red;
                }
                else
                {
                    lblNextDay.Text = "";
                }
            }
            else
            {
                lblNextDay.Text = "";
            }
        }

        // 管理者用ボタン押下
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var adminMenu = new AdminMenuForm(supabase);
            adminMenu.ShowDialog();

            _ = LoadMasters();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            isLoggingOut = true;
            MessageBox.Show("ログアウトしました。終了してトップページに戻ります。");

            foreach (Form f in Application.OpenForms)
            {
                if (f is LoginForm login)
                {
                    login.ClearInput();
                    login.Show();
                    login.FocusIdInput();
                    break;
                }
            }
            this.Close();
        }

        // ウインドウ右上の×をログアウトと同じ動きにする
        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !isLoggingOut)
            {
                e.Cancel = true;
                btnLogout_Click(null, null);
            }
        }

        private void btnptmember_Click(object sender, EventArgs e)
        {
            // カレンダーで日付を選択していない場合PT編成をさせない
            if (currentPlayLog == null)
            {
                MessageBox.Show("記録する日付を選択してください");
                return;
            }

            var partyConfig = new PartyConfigForm(supabase, currentPlayLog);

            // ShowDialogの結果を確認する
            if (partyConfig.ShowDialog() == DialogResult.OK)
            {
                // OKで戻ってきた場合、currentPlayLogの内容は更新されているので、
                // その内容をMenuForm上のListViewに反映させるメソッドを呼ぶ
                DisplayPatyList();
            }
        }

        private void DisplayPatyList()
        {
            // MenuForm側にあるListView
            listView1.Items.Clear();

            // currentPlayLog=nullの場合は処理しない
            if (currentPlayLog == null)
            {
                return;
            }

            string[] members = { currentPlayLog.Member1, currentPlayLog.Member2, currentPlayLog.Member3, currentPlayLog.Member4,
                         currentPlayLog.Member5, currentPlayLog.Member6, currentPlayLog.Member7, currentPlayLog.Member8 };

            for (int i = 0; i < 8; i++)
            {
                string m = members[i];

                if (!string.IsNullOrEmpty(m))
                {
                    string[] parts = m.Split(':');
                    if (parts.Length >= 3)
                    {
                        // データがある場合
                        ListViewItem item = new ListViewItem(parts[0]); // ロール
                        item.SubItems.Add(parts[1]); // ジョブ
                        item.SubItems.Add(parts[2]); // 名前
                        item.SubItems.Add(parts.Length > 3 ? parts[3] : ""); // 備考
                        listView1.Items.Add(item);
                        continue; // 次のループへ
                    }
                }

                // データがない、または不正な場合は「空行」を追加して位置を維持する
                ListViewItem emptyItem = new ListViewItem(""); // ロール空
                emptyItem.SubItems.AddRange(new string[] { "", "", "" }); // ジョブ, 名前, 備考も空
                listView1.Items.Add(emptyItem);
            }
        }

        // 選択日より過去の日付までの、選択したコンテンツ名の累計攻略時間を出力する
        private async void btnCalcTotalTime_Click(object sender, EventArgs e)
        {
            try
            {
                var user = supabase.Auth.CurrentUser;
                if (user == null)
                {
                    return;
                }

                // カレンダーの選択日を取得
                DateTime selectedDate = calendarLog.SelectionStart.Date;

                // コンボボックスで選択されているコンテンツ名を取得
                string selectedContent = cmbContent.SelectedItem?
                    .ToString() ?? cmbContent.Text;

                selectedContent = selectedContent.Trim();

                // コンテンツ名未入力：0表記
                if (string.IsNullOrEmpty(selectedContent))
                {
                    lblTotalTime.Text = "現在：0回と0時間0分";
                    return;
                }

                // DBから該当ユーザーの一致コンテンツ名の履歴を取得
                var result = await supabase.From<PlayLog>()
                    .Where(x => x.Userid == user.Id)
                    .Get();

                var logs = result.Models
                    .Where(x => x.ContentName == selectedContent && x.PlayDate.Date < selectedDate)
                    .ToList();

                // 過去に攻略データが無い場合
                if (logs == null || logs.Count == 0)
                {
                    lblTotalTime.Text = "過去に攻略履歴がありません";
                    return;
                }

                // 計算
                int totalDays = logs.Count;
                int totalMinutes = logs.Sum(x => x.DurationMinutes);

                // 分を「時間」と「分」に変換
                int hours = totalMinutes / 60;
                int minutes = totalMinutes % 60;

                // ラベルに結果を表示
                lblTotalTime.Text = $"現在：{totalDays}回と{hours}時間{minutes}分";

            }
            catch (Exception ex)
            {
                MessageBox.Show("計算中にエラー：" + ex.Message);
            }
        }
    }
}
