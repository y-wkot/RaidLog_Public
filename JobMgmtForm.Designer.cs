namespace RaidLog
{
    partial class JobMgmtForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSelectedId = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.numDisplayOrder = new System.Windows.Forms.NumericUpDown();
            this.lblDisplayOrder = new System.Windows.Forms.Label();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.lblJobName = new System.Windows.Forms.Label();
            this.txtJobName = new System.Windows.Forms.TextBox();
            this.rdoDelete = new System.Windows.Forms.RadioButton();
            this.rdoRegist = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDisplayOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(463, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(496, 641);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(385, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(55, 26);
            this.btnBack.TabIndex = 43;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSelectedId
            // 
            this.lblSelectedId.AutoSize = true;
            this.lblSelectedId.Location = new System.Drawing.Point(331, 27);
            this.lblSelectedId.Name = "lblSelectedId";
            this.lblSelectedId.Size = new System.Drawing.Size(0, 12);
            this.lblSelectedId.TabIndex = 42;
            this.lblSelectedId.Visible = false;
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExecute.Location = new System.Drawing.Point(116, 615);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(215, 38);
            this.btnExecute.TabIndex = 41;
            this.btnExecute.Text = "登録";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // numDisplayOrder
            // 
            this.numDisplayOrder.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numDisplayOrder.Location = new System.Drawing.Point(16, 285);
            this.numDisplayOrder.Name = "numDisplayOrder";
            this.numDisplayOrder.Size = new System.Drawing.Size(75, 29);
            this.numDisplayOrder.TabIndex = 40;
            // 
            // lblDisplayOrder
            // 
            this.lblDisplayOrder.AutoSize = true;
            this.lblDisplayOrder.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDisplayOrder.Location = new System.Drawing.Point(12, 260);
            this.lblDisplayOrder.Name = "lblDisplayOrder";
            this.lblDisplayOrder.Size = new System.Drawing.Size(79, 22);
            this.lblDisplayOrder.TabIndex = 39;
            this.lblDisplayOrder.Text = "表示順";
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblRoleName.Location = new System.Drawing.Point(12, 178);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(212, 22);
            this.lblRoleName.TabIndex = 36;
            this.lblRoleName.Text = "ロール名　（例：タンク）";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtRoleName.Location = new System.Drawing.Point(16, 203);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(412, 29);
            this.txtRoleName.TabIndex = 35;
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.lblJobName.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblJobName.Location = new System.Drawing.Point(12, 96);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(226, 22);
            this.lblJobName.TabIndex = 34;
            this.lblJobName.Text = "ジョブ名称　（例：力士）";
            // 
            // txtJobName
            // 
            this.txtJobName.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtJobName.Location = new System.Drawing.Point(16, 121);
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.Size = new System.Drawing.Size(412, 29);
            this.txtJobName.TabIndex = 33;
            // 
            // rdoDelete
            // 
            this.rdoDelete.AutoSize = true;
            this.rdoDelete.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdoDelete.Location = new System.Drawing.Point(217, 41);
            this.rdoDelete.Name = "rdoDelete";
            this.rdoDelete.Size = new System.Drawing.Size(72, 26);
            this.rdoDelete.TabIndex = 32;
            this.rdoDelete.TabStop = true;
            this.rdoDelete.Text = "削除";
            this.rdoDelete.UseVisualStyleBackColor = true;
            this.rdoDelete.CheckedChanged += new System.EventHandler(this.rdoDelete_CheckedChanged);
            // 
            // rdoRegist
            // 
            this.rdoRegist.AutoSize = true;
            this.rdoRegist.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdoRegist.Location = new System.Drawing.Point(16, 41);
            this.rdoRegist.Name = "rdoRegist";
            this.rdoRegist.Size = new System.Drawing.Size(127, 26);
            this.rdoRegist.TabIndex = 31;
            this.rdoRegist.TabStop = true;
            this.rdoRegist.Text = "登録・編集";
            this.rdoRegist.UseVisualStyleBackColor = true;
            this.rdoRegist.CheckedChanged += new System.EventHandler(this.rdoRegist_CheckedChanged);
            // 
            // JobMgmtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 665);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSelectedId);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.numDisplayOrder);
            this.Controls.Add(this.lblDisplayOrder);
            this.Controls.Add(this.lblRoleName);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.lblJobName);
            this.Controls.Add(this.txtJobName);
            this.Controls.Add(this.rdoDelete);
            this.Controls.Add(this.rdoRegist);
            this.Controls.Add(this.dataGridView1);
            this.Name = "JobMgmtForm";
            this.Text = "ジョブ管理画面";
            this.Load += new System.EventHandler(this.JobMgmtForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDisplayOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSelectedId;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.NumericUpDown numDisplayOrder;
        private System.Windows.Forms.Label lblDisplayOrder;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Label lblJobName;
        private System.Windows.Forms.TextBox txtJobName;
        private System.Windows.Forms.RadioButton rdoDelete;
        private System.Windows.Forms.RadioButton rdoRegist;
    }
}