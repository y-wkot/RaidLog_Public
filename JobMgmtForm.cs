using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaidLog
{
    public partial class JobMgmtForm : Form
    {
        private Supabase.Client supabase;
        private List<JobMaster> jobList = new List<JobMaster>();
        private ProcMode currentMode = ProcMode.Regist;

        public JobMgmtForm(Supabase.Client client)
        {
            InitializeComponent();
            this.supabase = client;
        }

        private async void JobMgmtForm_Load(object sender, EventArgs e)
        {
            // 初期表示
            rdoRegist.Checked = true;
            currentMode = ProcMode.Regist;
            await RefreshData();
        }

        // GridViewにデータを表示
        private async Task RefreshData()
        {
            try
            {
                var result = await supabase.From<JobMaster>()
                    .Order(x => x.DisplayOrder, Postgrest.Constants.Ordering.Ascending)
                    .Get();

                jobList = result.Models;

                // Grid
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = jobList;

                // --- 不要な列を非表示にする ---
                string[] hideCols = { "Id", "BaseUrl", "Client", "TableName", "PrimaryKey", "RequestClientOptions" }; // 必要に応じて追加
                foreach (var colName in hideCols)
                {
                    if (dataGridView1.Columns[colName] != null)
                        dataGridView1.Columns[colName].Visible = false;
                }

                // layout
                // if (dataGridView1.Columns["Id"] != null) dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["jobName"].HeaderText = "ジョブ名";
                dataGridView1.Columns["RoleName"].HeaderText = "ロール";
                dataGridView1.Columns["DisplayOrder"].HeaderText = "表示順";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ジョブ情報取得失敗： " + ex.Message);
            }
        }

        // 登録ボタン処理
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
                await RefreshData();
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show("処理失敗： " + ex.Message);
            }
        }
        private async Task ExecuteUpsert()
        {
            if (string.IsNullOrWhiteSpace(txtJobName.Text))
            {
                MessageBox.Show("内容を入力してください。");
                return;
            }

            try
            {
                // lblSelectedIdが空なら新規登録、値があれば更新
                if (string.IsNullOrEmpty(lblSelectedId.Text))
                {
                    // 新規登録
                    var model = new JobMaster
                    {
                        jobName = txtJobName.Text,
                        RoleName = txtRoleName.Text,
                        DisplayOrder = (int)numDisplayOrder.Value
                    };

                    // Insertを使う
                    await supabase.From<JobMaster>().Insert(model);
                    MessageBox.Show("ジョブ情報を新規登録しました。");
                }
                else
                {
                    // 【更新】
                    var model = new JobMaster
                    {
                        Id = int.Parse(lblSelectedId.Text), // 更新時はIDをセットする
                        jobName = txtJobName.Text,
                        RoleName = txtRoleName.Text,
                        DisplayOrder = (int)numDisplayOrder.Value
                    };

                    // Updateを使う
                    await supabase.From<JobMaster>().Update(model);
                    MessageBox.Show("ジョブ情報を更新しました。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存に失敗しました。：" + ex.Message);
            }
        }

        private async Task ExecuteDelete()
        {
            if (string.IsNullOrEmpty(lblSelectedId.Text)) return;

            var dr = MessageBox.Show("選択したジョブ情報を削除しますか？", "削除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    int targetId = int.Parse(lblSelectedId.Text);
                    await supabase.From<JobMaster>()
                        .Filter("id", Postgrest.Constants.Operator.Equals, targetId)
                        .Delete();

                    MessageBox.Show("削除しました。");
                    await RefreshData();
                    ClearInput();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("削除に失敗しました。：" + ex.Message);
                }
            }
        }

        // リストからダブルクリック時にテキストボックスへ各項目を入れる
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var job = jobList[e.RowIndex]; // リストの何番目かを指定して取り出す
            lblSelectedId.Text = job.Id.ToString();
            txtJobName.Text = job.jobName;
            txtRoleName.Text = job.RoleName;
            numDisplayOrder.Value = job.DisplayOrder;
        }

        // モード切替
        private void rdoRegist_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoRegist.Checked)
            {
                currentMode = ProcMode.Regist;
                btnExecute.Text = "登録・更新";
                btnExecute.BackColor = SystemColors.Control;
            }
        }

        private void rdoDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDelete.Checked)
            {
                currentMode = ProcMode.Delete;
                btnExecute.Text = "削除実行";
                btnExecute.BackColor = Color.MistyRose;
            }
        }
        private void ClearInput()
        {
            lblSelectedId.Text = "";
            txtJobName.Text = "";
            txtRoleName.Text = "";
            numDisplayOrder.Value = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}