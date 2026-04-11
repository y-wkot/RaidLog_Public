using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supabase;

namespace RaidLog
{
    public partial class AdminMenuForm : Form
    {
        private Supabase.Client supabase;

        public AdminMenuForm(Supabase.Client client)
        {
            InitializeComponent();
            this.supabase = client;
        }

        // コンテンツ管理
        private void btnContentMgmt_Click(object sender, EventArgs e)
        {
            var form = new ContentMgmtForm(supabase);
            form.ShowDialog();
        }

        // ジョブマスタ管理
        private void btnJobMgmt_Click(object sender, EventArgs e)
        {
            var form = new JobMgmtForm(supabase);
            form.ShowDialog();
        }

        // 閉じて戻る
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
