namespace RaidLog
{
    partial class LoginForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ユーザーID = new System.Windows.Forms.Label();
            this.パスワード = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.buttoncloseapp = new System.Windows.Forms.Button();
            this.lblVer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ユーザーID
            // 
            this.ユーザーID.AutoSize = true;
            this.ユーザーID.Location = new System.Drawing.Point(67, 33);
            this.ユーザーID.Name = "ユーザーID";
            this.ユーザーID.Size = new System.Drawing.Size(56, 12);
            this.ユーザーID.TabIndex = 0;
            this.ユーザーID.Text = "ユーザーID";
            // 
            // パスワード
            // 
            this.パスワード.AutoSize = true;
            this.パスワード.Location = new System.Drawing.Point(67, 77);
            this.パスワード.Name = "パスワード";
            this.パスワード.Size = new System.Drawing.Size(52, 12);
            this.パスワード.TabIndex = 1;
            this.パスワード.Text = "パスワード";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(158, 26);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(100, 19);
            this.txtUserId.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(158, 70);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 19);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(110, 105);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "ログイン";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(110, 151);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 40);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "新規登録はこちら";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // buttoncloseapp
            // 
            this.buttoncloseapp.Location = new System.Drawing.Point(110, 209);
            this.buttoncloseapp.Name = "buttoncloseapp";
            this.buttoncloseapp.Size = new System.Drawing.Size(100, 40);
            this.buttoncloseapp.TabIndex = 4;
            this.buttoncloseapp.Text = "終了する";
            this.buttoncloseapp.UseVisualStyleBackColor = true;
            this.buttoncloseapp.Click += new System.EventHandler(this.buttoncloseapp_Click);
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Location = new System.Drawing.Point(279, 240);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(43, 12);
            this.lblVer.TabIndex = 5;
            this.lblVer.Text = "ver1.0.0";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.ControlBox = false;
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.buttoncloseapp);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.パスワード);
            this.Controls.Add(this.ユーザーID);
            this.Name = "LoginForm";
            this.Text = "固定活動記録アプリ";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ユーザーID;
        private System.Windows.Forms.Label パスワード;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button buttoncloseapp;
        private System.Windows.Forms.Label lblVer;
    }
}

