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
    public partial class ContentMgmtForm : Form
    {
        private Supabase.Client supabase;
        private List<ContentMaster> masterList = new List<ContentMaster>();
        private ProcMode currentMode = ProcMode.Regist;

        public ContentMgmtForm(Supabase.Client client)
        {
            InitializeComponent();
            this.supabase = client;
        }

        private async void ContentMgmtForm_Load(object sender, EventArgs e)
        {
            // 初期表示
            rdoRegist.Checked = true;
            currentMode = ProcMode.Regist;
            await RefreshTree();
        }

        // ツリー形式で一覧を表示する
        private async Task RefreshTree()
        {
            try
            {
                // contentmasterテーブルを対象に、ContentNameでソート、DisplayOrderでソートし、取得
                var result = await supabase.From<ContentMaster>()
                    .Order(x => x.ContentName, Postgrest.Constants.Ordering.Ascending)
                    .Order(x => x.DisplayOrder, Postgrest.Constants.Ordering.Ascending)
                    .Get();

                masterList = result.Models;
                treeContent.Nodes.Clear();

                // コンテンツ名でグループごとに分ける
                var groups = masterList.GroupBy(m => m.ContentName);

                foreach (var group in groups)
                {
                    // 親ノードを作る（ContentNameがキー）
                    TreeNode parentNode = new TreeNode(group.Key);

                    foreach (var item in group)
                    {
                        // 子ノード フェーズ名：詳細
                        string nodeText = $"[{item.DisplayOrder}] {item.PhaseName} : {item.DetailGimmick}";
                        TreeNode childNode = new TreeNode(nodeText);

                        // Tagを使用してデータ本体を保持
                        childNode.Tag = item;

                        parentNode.Nodes.Add(childNode);

                    }
                    treeContent.Nodes.Add(parentNode);
                }
                treeContent.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("一覧取得に失敗 : " + ex.Message);
            }
        }

        // ツリーから選択時、各テキストボックスへ値を表示
        private void treeContent_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Tagにデータがあるかを確認
            if (e.Node.Tag is ContentMaster selected)
            {
                // Tagに隠しておいたデータをそのまま各Boxに入れる
                lblSelectedId.Text = selected.Id.ToString();
                txtContentName.Text = selected.ContentName;
                txtPhaseName.Text = selected.PhaseName;
                txtDetailGimmick.Text = selected.DetailGimmick;
                numDisplayOrder.Value = selected.DisplayOrder;
            }
            else
            {
                ClearInput();
                txtContentName.Text = e.Node.Text;
            }
            UpdateButtonText();
        }

        // 登録ボタン
        private async void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentMode == ProcMode.Delete)
                {
                    await ExecuteDelete();
                }
                else
                {
                    await ExecuteUpsert();
                }
                await RefreshTree();
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show("処理失敗：" + ex.Message);
            }
        }

        private async Task ExecuteUpsert()
        {
            if (string.IsNullOrWhiteSpace(txtContentName.Text) ||
                string.IsNullOrWhiteSpace(txtPhaseName.Text))
            {
                MessageBox.Show("コンテンツ名とフェーズ名を入力してください。");
                return;
            }

            try
            {
                // lblSelectedIdが空なら新規登録、値があれば更新
                if (string.IsNullOrEmpty(lblSelectedId.Text))
                {
                    // 新規登録
                    var model = new ContentMaster
                    {
                        ContentName = txtContentName.Text,
                        PhaseName = txtPhaseName.Text,
                        DetailGimmick = txtDetailGimmick.Text,
                        DisplayOrder = (int)numDisplayOrder.Value
                    };

                    // Insertを使う
                    await supabase.From<ContentMaster>().Insert(model);
                    MessageBox.Show("新規登録しました。");
                }
                else
                {
                    // 更新処理
                    var model = new ContentMaster
                    {
                        Id = int.Parse(lblSelectedId.Text), // 更新時はIDをセットする
                        ContentName = txtContentName.Text,
                        PhaseName = txtPhaseName.Text,
                        DetailGimmick = txtDetailGimmick.Text,
                        DisplayOrder = (int)numDisplayOrder.Value
                    };

                    // Updateを使う
                    await supabase.From<ContentMaster>().Update(model);
                    MessageBox.Show("内容を更新しました。");
                }

                await RefreshTree();
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失敗。：　" + ex.Message);
            }
        }

        private async Task ExecuteDelete()
        {
            if (string.IsNullOrEmpty(lblSelectedId.Text))
            {
                MessageBox.Show("削除する項目を選択してください。");
                return;
            }

            int targetId;
            if (!int.TryParse(lblSelectedId.Text, out targetId)) return;

            var dr = MessageBox.Show($"選択中のデータ(ID:{targetId}を削除しますか？",
                "削除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    // IDで絞り込み
                    await supabase
                        .From<ContentMaster>()
                        .Filter("id", Postgrest.Constants.Operator.Equals, targetId)
                        .Delete();

                    MessageBox.Show("削除しました。");

                    await RefreshTree();
                    ClearInput();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("処理失敗：" + ex.Message);
                }
            }
        }

        private void UpdateButtonText()
        {
            // 現在のモードを最優先でチェック
            if (currentMode == ProcMode.Delete)
            {
                btnExecute.Text = "データ削除";
                btnExecute.BackColor = Color.MistyRose;
            }
            else // Registモードの時
            {
                if (string.IsNullOrEmpty(lblSelectedId.Text))
                {
                    btnExecute.Text = "新規登録";
                    btnExecute.BackColor = Color.LightCyan;
                }
                else
                {
                    btnExecute.Text = "内容更新";
                    btnExecute.BackColor = Color.LightYellow;
                }
            }
        }

        // モード切替
        private void rdoRegist_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRegist.Checked)
            {
                currentMode = ProcMode.Regist;
                UpdateButtonText();
            }
        }

        private void rdoDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDelete.Checked)
            {
                currentMode = ProcMode.Delete;
                UpdateButtonText();
            }
        }

        private void ClearInput()
        {
            lblSelectedId.Text = "";
            txtContentName.Text = "";
            txtPhaseName.Text = "";
            txtDetailGimmick.Text = "";
            numDisplayOrder.Value = 0;

            UpdateButtonText();
        }

        // 閉じて戻る
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
