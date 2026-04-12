namespace RaidLog
{
    partial class AdminMenuForm
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
            this.btnContentMgmt = new System.Windows.Forms.Button();
            this.btnJobMgmt = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnContentMgmt
            // 
            this.btnContentMgmt.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnContentMgmt.Location = new System.Drawing.Point(12, 12);
            this.btnContentMgmt.Name = "btnContentMgmt";
            this.btnContentMgmt.Size = new System.Drawing.Size(296, 61);
            this.btnContentMgmt.TabIndex = 0;
            this.btnContentMgmt.Text = "コンテンツマスタ管理";
            this.btnContentMgmt.UseVisualStyleBackColor = true;
            this.btnContentMgmt.Click += new System.EventHandler(this.btnContentMgmt_Click);
            // 
            // btnJobMgmt
            // 
            this.btnJobMgmt.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnJobMgmt.Location = new System.Drawing.Point(12, 79);
            this.btnJobMgmt.Name = "btnJobMgmt";
            this.btnJobMgmt.Size = new System.Drawing.Size(296, 61);
            this.btnJobMgmt.TabIndex = 1;
            this.btnJobMgmt.Text = "ジョブマスタ管理";
            this.btnJobMgmt.UseVisualStyleBackColor = true;
            this.btnJobMgmt.Click += new System.EventHandler(this.btnJobMgmt_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 398);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(191, 40);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "マイページへ戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AdminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnJobMgmt);
            this.Controls.Add(this.btnContentMgmt);
            this.Name = "AdminMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理者用画面";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContentMgmt;
        private System.Windows.Forms.Button btnJobMgmt;
        private System.Windows.Forms.Button btnBack;
    }
}