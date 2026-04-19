using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaidLog
{
    public partial class PartyConfigForm : Form
    {
        private Supabase.Client supabase;
        private List<JobMaster> masterList = new List<JobMaster>();
        private ProcMode currentMode = ProcMode.Regist;
        private PlayLog _playLog;

        public PartyConfigForm(Supabase.Client client, PlayLog log)
        {
            InitializeComponent();
            this.supabase = client;
            this._playLog = log;
        }

        private async void PartyConfigForm_Load(object sender, EventArgs e)
        {

            // リストビュー初期化
            listView1.Items.Clear();

            // 空の８行を作成
            for (int i = 1; i <= 8; i++)
            {
                // 1列目
                ListViewItem item = new ListViewItem($"Member {i}");
                item.SubItems.AddRange(new string[] { "", "", "", "" }); // ロール,ジョブ,キャラ名,備考を1カラム
                listView1.Items.Add(item);
            }

            // 既存データを表示
            LoadCurrentMemberData();

            lblSelectedId.Text = "リストから編集するメンバーを選択してください。";
            await LoadJobs();

            // 初期状態で「登録・編集」にチェックを入れる
            rdoRegist.Checked = true;
            currentMode = ProcMode.Regist;

            // 起動時に1行目を選択状態にする
            if (listView1.Items.Count > 0)
            {
                listView1.Items[0].Selected = true;
            }
        }

        private void LoadCurrentMemberData()
        {
            // _playLog内の文字列をリストに戻す
            string[] members = { _playLog.Member1, _playLog.Member2, _playLog.Member3, _playLog.Member4,
                                 _playLog.Member5, _playLog.Member6, _playLog.Member7, _playLog.Member8 };

            for (int i = 0; i < 8; i++)
            {

                if (string.IsNullOrEmpty(members[i])) continue;
                string[] parts = members[i].Split(':');
                if (parts.Length >= 3)
                {
                    listView1.Items[i].SubItems[1].Text = parts[0]; // Role
                    listView1.Items[i].SubItems[2].Text = parts[1]; // Job
                    listView1.Items[i].SubItems[3].Text = parts[2]; // Name
                    if (parts.Length == 4) listView1.Items[i].SubItems[4].Text = parts[3]; // 備考があれば
                }
            }
        }

        private async Task LoadJobs()
        {
            var result = await supabase.From<JobMaster>().Get();
            masterList = result.Models;

            cmbJobName.Items.Clear();
            foreach (var job in masterList)
            {
                cmbJobName.Items.Add(job.jobName);
            }
        }

        // ロールも一緒にセットさせる
        // TODO：ロールの表記をどこかにしたい　かも
        private void cmbJobName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedJob = masterList.FirstOrDefault(x => x.jobName == cmbJobName.Text);
            if (selectedJob != null)
            {
                txtRole.Text = selectedJob.RoleName; // Tank, Healerなどが自動で入る
            }
        }

        // リストから行を選択した時の処理
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 選択解除の一瞬がエラーになるらしいので早期リターンさせる
            if (listView1.SelectedItems.Count == 0) return;

            // 選択行を取得
            ListViewItem selectedRow = listView1.SelectedItems[0];

            // 選択している行をラベルに表示させる
            lblSelectedId.Text = $"{selectedRow.Text} を選択中";

            // 選択行の情報を各項目にセット
            txtRole.Text = selectedRow.SubItems[1].Text;
            cmbJobName.Text = selectedRow.SubItems[2].Text;
            txtCharacterName.Text = selectedRow.SubItems[3].Text;
            txtMemo.Text = selectedRow.SubItems[4].Text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string SerializeRow(int index)
        {
            var item = listView1.Items[index];
            // ロール、ジョブ、名前のいずれかが欠けている場合は「データなし」として扱う
            if (string.IsNullOrWhiteSpace(item.SubItems[1].Text) ||
                string.IsNullOrWhiteSpace(item.SubItems[2].Text) ||
                string.IsNullOrWhiteSpace(item.SubItems[3].Text))
            {
                return "";
            }

            return $"{item.SubItems[1].Text}:{item.SubItems[2].Text}:{item.SubItems[3].Text}:{item.SubItems[4].Text}";
        }

        // 反映ボタン：この画面のリスト内容を _playLog に書き戻して閉じる
        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("行を選択してください");
                return;
            }

            // 選択行を取得
            ListViewItem selectedRow = listView1.SelectedItems[0];

            // 削除モードの場合
            if (currentMode == ProcMode.Delete)
            {
                // 確認ダイアログ
                var confirm = MessageBox.Show($"{selectedRow.Text}のデータを削除しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    // 編集画面では実際に登録される前なので、空文字で消えてる感じに見せる
                    selectedRow.SubItems[1].Text = "";
                    selectedRow.SubItems[2].Text = "";
                    selectedRow.SubItems[3].Text = "";
                    if (selectedRow.SubItems.Count > 4)
                    {
                        selectedRow.SubItems[4].Text = ""; // Memoは必須じゃないため
                    }

                    // 入力欄リセット
                    txtRole.Clear();
                    cmbJobName.SelectedIndex = -1;
                    txtCharacterName.Clear();
                    txtMemo.Clear();
                }
                return;
            }

            // 登録・編集
            // 必須項目（ロール、ジョブ、キャラ名）の未入力チェック
            if (string.IsNullOrWhiteSpace(txtRole.Text) ||
                string.IsNullOrWhiteSpace(cmbJobName.Text) ||
                string.IsNullOrWhiteSpace(txtCharacterName.Text))
            {
                MessageBox.Show("ロール、ジョブ、キャラクター名は必須入力です。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // 入力内容をリストに反映
            selectedRow.SubItems[1].Text = txtRole.Text;
            selectedRow.SubItems[2].Text = cmbJobName.Text;
            selectedRow.SubItems[3].Text = txtCharacterName.Text;
            selectedRow.SubItems[4].Text = txtMemo.Text;

            // 入力欄をクリア
            txtRole.Clear();
            cmbJobName.SelectedIndex = -1;
            txtCharacterName.Clear();
            txtMemo.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 全8行を1行ずつシリアライズして _playLog オブジェクトに代入
                // SerializeRowメソッド（下で定義）を使って文字列に変換します
                _playLog.Member1 = SerializeRow(0);
                _playLog.Member2 = SerializeRow(1);
                _playLog.Member3 = SerializeRow(2);
                _playLog.Member4 = SerializeRow(3);
                _playLog.Member5 = SerializeRow(4);
                _playLog.Member6 = SerializeRow(5);
                _playLog.Member7 = SerializeRow(6);
                _playLog.Member8 = SerializeRow(7);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("処理中にエラーが発生しました。：" + ex.Message);
            }
        }

        // 登録・編集ラジオボタン選択
        private void rdoRegist_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRegist.Checked)
            {
                currentMode = ProcMode.Regist;
                btnExecute.Text = "リストに反映";
                btnExecute.BackColor = SystemColors.Control;

                txtRole.Enabled = true;
                cmbJobName.Enabled = true;
                txtCharacterName.Enabled = true;
                txtMemo.Enabled = true;
            }
        }

        // 削除ラジオボタン選択
        private void rdoDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDelete.Checked)
            {
                currentMode = ProcMode.Delete;
                btnExecute.Text = "PTメンバーから除名";
                btnExecute.BackColor = Color.MistyRose;

                txtRole.Enabled = false;
                cmbJobName.Enabled = false;
                txtCharacterName.Enabled = false;
                txtMemo.Enabled = false;
            }
        }
    }
}
