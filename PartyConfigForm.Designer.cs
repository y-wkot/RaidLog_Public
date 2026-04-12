namespace RaidLog
{
    partial class PartyConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnBack = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Member = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Job = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CharacterName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Memo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.lblJobName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.rdoDelete = new System.Windows.Forms.RadioButton();
            this.rdoRegist = new System.Windows.Forms.RadioButton();
            this.cmbJobName = new System.Windows.Forms.ComboBox();
            this.lblMemo = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.lblSelectedId = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 549);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 26);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Member,
            this.Role,
            this.Job,
            this.CharacterName,
            this.Memo});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(434, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(594, 550);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Member
            // 
            this.Member.Text = "メンバー";
            this.Member.Width = 70;
            // 
            // Role
            // 
            this.Role.Text = "ロール";
            this.Role.Width = 62;
            // 
            // Job
            // 
            this.Job.Text = "ジョブ";
            this.Job.Width = 136;
            // 
            // CharacterName
            // 
            this.CharacterName.Text = "キャラクター名";
            this.CharacterName.Width = 145;
            // 
            // Memo
            // 
            this.Memo.Text = "備考";
            this.Memo.Width = 123;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(1, 30);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExecute.Location = new System.Drawing.Point(73, 427);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(284, 38);
            this.btnExecute.TabIndex = 42;
            this.btnExecute.Text = "PTリストの更新、追加";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblCharacterName.Location = new System.Drawing.Point(8, 271);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(135, 22);
            this.lblCharacterName.TabIndex = 48;
            this.lblCharacterName.Text = "キャラクター名";
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtCharacterName.Location = new System.Drawing.Point(12, 296);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(412, 29);
            this.txtCharacterName.TabIndex = 47;
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.lblJobName.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblJobName.Location = new System.Drawing.Point(12, 196);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(59, 22);
            this.lblJobName.TabIndex = 46;
            this.lblJobName.Text = "ジョブ";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRole.Location = new System.Drawing.Point(12, 125);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(151, 22);
            this.lblRole.TabIndex = 44;
            this.lblRole.Text = "ロール（例：D4）";
            // 
            // txtRole
            // 
            this.txtRole.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtRole.Location = new System.Drawing.Point(16, 150);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(412, 29);
            this.txtRole.TabIndex = 43;
            // 
            // rdoDelete
            // 
            this.rdoDelete.AutoSize = true;
            this.rdoDelete.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdoDelete.Location = new System.Drawing.Point(199, 25);
            this.rdoDelete.Name = "rdoDelete";
            this.rdoDelete.Size = new System.Drawing.Size(72, 26);
            this.rdoDelete.TabIndex = 50;
            this.rdoDelete.TabStop = true;
            this.rdoDelete.Text = "削除";
            this.rdoDelete.UseVisualStyleBackColor = true;
            // 
            // rdoRegist
            // 
            this.rdoRegist.AutoSize = true;
            this.rdoRegist.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdoRegist.Location = new System.Drawing.Point(23, 25);
            this.rdoRegist.Name = "rdoRegist";
            this.rdoRegist.Size = new System.Drawing.Size(127, 26);
            this.rdoRegist.TabIndex = 49;
            this.rdoRegist.TabStop = true;
            this.rdoRegist.Text = "登録・編集";
            this.rdoRegist.UseVisualStyleBackColor = true;
            // 
            // cmbJobName
            // 
            this.cmbJobName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJobName.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbJobName.FormattingEnabled = true;
            this.cmbJobName.Location = new System.Drawing.Point(12, 221);
            this.cmbJobName.Name = "cmbJobName";
            this.cmbJobName.Size = new System.Drawing.Size(416, 29);
            this.cmbJobName.TabIndex = 51;
            this.cmbJobName.SelectedIndexChanged += new System.EventHandler(this.cmbJobName_SelectedIndexChanged);
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMemo.Location = new System.Drawing.Point(12, 353);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(161, 22);
            this.lblMemo.TabIndex = 53;
            this.lblMemo.Text = "備考（例：傭兵）";
            // 
            // txtMemo
            // 
            this.txtMemo.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtMemo.Location = new System.Drawing.Point(16, 378);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(412, 29);
            this.txtMemo.TabIndex = 52;
            // 
            // lblSelectedId
            // 
            this.lblSelectedId.AutoSize = true;
            this.lblSelectedId.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblSelectedId.Location = new System.Drawing.Point(105, 78);
            this.lblSelectedId.Name = "lblSelectedId";
            this.lblSelectedId.Size = new System.Drawing.Size(177, 22);
            this.lblSelectedId.TabIndex = 54;
            this.lblSelectedId.Text = "選択中の行を表示";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSave.Location = new System.Drawing.Point(99, 486);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(215, 38);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "登録（PT確定）";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PartyConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 587);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSelectedId);
            this.Controls.Add(this.lblMemo);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.cmbJobName);
            this.Controls.Add(this.rdoDelete);
            this.Controls.Add(this.rdoRegist);
            this.Controls.Add(this.lblCharacterName);
            this.Controls.Add(this.txtCharacterName);
            this.Controls.Add(this.lblJobName);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnBack);
            this.Name = "PartyConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "パーティ編成";
            this.Load += new System.EventHandler(this.PartyConfigForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.ColumnHeader Role;
        private System.Windows.Forms.ColumnHeader Job;
        private System.Windows.Forms.ColumnHeader CharacterName;
        private System.Windows.Forms.ColumnHeader Memo;
        private System.Windows.Forms.Label lblCharacterName;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.Label lblJobName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.RadioButton rdoDelete;
        private System.Windows.Forms.RadioButton rdoRegist;
        private System.Windows.Forms.ComboBox cmbJobName;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.ColumnHeader Member;
        private System.Windows.Forms.Label lblSelectedId;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSave;
    }
}