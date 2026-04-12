namespace RaidLog
{
    partial class ContentMgmtForm
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
            this.treeContent = new System.Windows.Forms.TreeView();
            this.rdoDelete = new System.Windows.Forms.RadioButton();
            this.rdoRegist = new System.Windows.Forms.RadioButton();
            this.lblContentName = new System.Windows.Forms.Label();
            this.txtContentName = new System.Windows.Forms.TextBox();
            this.lblPhaseName = new System.Windows.Forms.Label();
            this.txtPhaseName = new System.Windows.Forms.TextBox();
            this.lblDetailGimmick = new System.Windows.Forms.Label();
            this.txtDetailGimmick = new System.Windows.Forms.TextBox();
            this.lblDisplayOrder = new System.Windows.Forms.Label();
            this.numDisplayOrder = new System.Windows.Forms.NumericUpDown();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblSelectedId = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDisplayOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // treeContent
            // 
            this.treeContent.Location = new System.Drawing.Point(442, 12);
            this.treeContent.Name = "treeContent";
            this.treeContent.Size = new System.Drawing.Size(517, 642);
            this.treeContent.TabIndex = 0;
            this.treeContent.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeContent_AfterSelect);
            // 
            // rdoDelete
            // 
            this.rdoDelete.AutoSize = true;
            this.rdoDelete.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdoDelete.Location = new System.Drawing.Point(213, 40);
            this.rdoDelete.Name = "rdoDelete";
            this.rdoDelete.Size = new System.Drawing.Size(72, 26);
            this.rdoDelete.TabIndex = 4;
            this.rdoDelete.TabStop = true;
            this.rdoDelete.Text = "削除";
            this.rdoDelete.UseVisualStyleBackColor = true;
            this.rdoDelete.MouseCaptureChanged += new System.EventHandler(this.rdoDelete_CheckedChanged);
            // 
            // rdoRegist
            // 
            this.rdoRegist.AutoSize = true;
            this.rdoRegist.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdoRegist.Location = new System.Drawing.Point(12, 40);
            this.rdoRegist.Name = "rdoRegist";
            this.rdoRegist.Size = new System.Drawing.Size(127, 26);
            this.rdoRegist.TabIndex = 0;
            this.rdoRegist.TabStop = true;
            this.rdoRegist.Text = "登録・編集";
            this.rdoRegist.UseVisualStyleBackColor = true;
            this.rdoRegist.Click += new System.EventHandler(this.rdoRegist_CheckedChanged);
            // 
            // lblContentName
            // 
            this.lblContentName.AutoSize = true;
            this.lblContentName.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblContentName.Location = new System.Drawing.Point(8, 95);
            this.lblContentName.Name = "lblContentName";
            this.lblContentName.Size = new System.Drawing.Size(361, 22);
            this.lblContentName.TabIndex = 20;
            this.lblContentName.Text = "コンテンツ名称　（例：絶オメガ検証戦）";
            // 
            // txtContentName
            // 
            this.txtContentName.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtContentName.Location = new System.Drawing.Point(12, 120);
            this.txtContentName.Name = "txtContentName";
            this.txtContentName.Size = new System.Drawing.Size(412, 29);
            this.txtContentName.TabIndex = 1;
            // 
            // lblPhaseName
            // 
            this.lblPhaseName.AutoSize = true;
            this.lblPhaseName.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPhaseName.Location = new System.Drawing.Point(8, 177);
            this.lblPhaseName.Name = "lblPhaseName";
            this.lblPhaseName.Size = new System.Drawing.Size(226, 22);
            this.lblPhaseName.TabIndex = 22;
            this.lblPhaseName.Text = "フェーズ名称　（例：P1）";
            // 
            // txtPhaseName
            // 
            this.txtPhaseName.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtPhaseName.Location = new System.Drawing.Point(12, 202);
            this.txtPhaseName.Name = "txtPhaseName";
            this.txtPhaseName.Size = new System.Drawing.Size(412, 29);
            this.txtPhaseName.TabIndex = 2;
            // 
            // lblDetailGimmick
            // 
            this.lblDetailGimmick.AutoSize = true;
            this.lblDetailGimmick.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDetailGimmick.Location = new System.Drawing.Point(8, 261);
            this.lblDetailGimmick.Name = "lblDetailGimmick";
            this.lblDetailGimmick.Size = new System.Drawing.Size(428, 22);
            this.lblDetailGimmick.TabIndex = 24;
            this.lblDetailGimmick.Text = "フェーズ詳細　（例：1回目パラダイスリゲインド）";
            // 
            // txtDetailGimmick
            // 
            this.txtDetailGimmick.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtDetailGimmick.Location = new System.Drawing.Point(12, 286);
            this.txtDetailGimmick.Name = "txtDetailGimmick";
            this.txtDetailGimmick.Size = new System.Drawing.Size(412, 29);
            this.txtDetailGimmick.TabIndex = 3;
            // 
            // lblDisplayOrder
            // 
            this.lblDisplayOrder.AutoSize = true;
            this.lblDisplayOrder.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDisplayOrder.Location = new System.Drawing.Point(8, 341);
            this.lblDisplayOrder.Name = "lblDisplayOrder";
            this.lblDisplayOrder.Size = new System.Drawing.Size(79, 22);
            this.lblDisplayOrder.TabIndex = 26;
            this.lblDisplayOrder.Text = "表示順";
            // 
            // numDisplayOrder
            // 
            this.numDisplayOrder.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numDisplayOrder.Location = new System.Drawing.Point(12, 366);
            this.numDisplayOrder.Name = "numDisplayOrder";
            this.numDisplayOrder.Size = new System.Drawing.Size(75, 29);
            this.numDisplayOrder.TabIndex = 4;
            // 
            // btnExecute
            // 
            this.btnExecute.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExecute.Location = new System.Drawing.Point(112, 616);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(215, 38);
            this.btnExecute.TabIndex = 5;
            this.btnExecute.Text = "登録";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lblSelectedId
            // 
            this.lblSelectedId.AutoSize = true;
            this.lblSelectedId.Location = new System.Drawing.Point(327, 26);
            this.lblSelectedId.Name = "lblSelectedId";
            this.lblSelectedId.Size = new System.Drawing.Size(0, 12);
            this.lblSelectedId.TabIndex = 29;
            this.lblSelectedId.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(333, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 26);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ContentMgmtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 666);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSelectedId);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.numDisplayOrder);
            this.Controls.Add(this.lblDisplayOrder);
            this.Controls.Add(this.lblDetailGimmick);
            this.Controls.Add(this.txtDetailGimmick);
            this.Controls.Add(this.lblPhaseName);
            this.Controls.Add(this.txtPhaseName);
            this.Controls.Add(this.lblContentName);
            this.Controls.Add(this.txtContentName);
            this.Controls.Add(this.rdoDelete);
            this.Controls.Add(this.rdoRegist);
            this.Controls.Add(this.treeContent);
            this.Name = "ContentMgmtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "コンテンツ管理画面";
            this.Load += new System.EventHandler(this.ContentMgmtForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDisplayOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeContent;
        private System.Windows.Forms.RadioButton rdoDelete;
        private System.Windows.Forms.RadioButton rdoRegist;
        private System.Windows.Forms.Label lblContentName;
        private System.Windows.Forms.TextBox txtContentName;
        private System.Windows.Forms.Label lblPhaseName;
        private System.Windows.Forms.TextBox txtPhaseName;
        private System.Windows.Forms.Label lblDetailGimmick;
        private System.Windows.Forms.TextBox txtDetailGimmick;
        private System.Windows.Forms.Label lblDisplayOrder;
        private System.Windows.Forms.NumericUpDown numDisplayOrder;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lblSelectedId;
        private System.Windows.Forms.Button btnBack;
    }
}