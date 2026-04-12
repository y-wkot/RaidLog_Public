namespace RaidLog
{
    partial class RegisterForm
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
            this.Register = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.パスワード = new System.Windows.Forms.Label();
            this.ユーザーID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRegist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.Location = new System.Drawing.Point(198, 28);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(125, 12);
            this.Register.TabIndex = 0;
            this.Register.Text = "フォームを入力してください";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(350, 129);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 19);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(350, 75);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(150, 19);
            this.txtUserId.TabIndex = 0;
            // 
            // パスワード
            // 
            this.パスワード.AutoSize = true;
            this.パスワード.Location = new System.Drawing.Point(25, 132);
            this.パスワード.Name = "パスワード";
            this.パスワード.Size = new System.Drawing.Size(295, 12);
            this.パスワード.TabIndex = 5;
            this.パスワード.Text = "任意のパスワードを設定してください　（半角英数字6~10文字)";
            // 
            // ユーザーID
            // 
            this.ユーザーID.AutoSize = true;
            this.ユーザーID.Location = new System.Drawing.Point(25, 78);
            this.ユーザーID.Name = "ユーザーID";
            this.ユーザーID.Size = new System.Drawing.Size(301, 12);
            this.ユーザーID.TabIndex = 4;
            this.ユーザーID.Text = "任意のユーザーIDを入力してください（半角英数字20文字まで）";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(200, 228);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "ログイン画面へ戻る";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRegist
            // 
            this.btnRegist.Location = new System.Drawing.Point(200, 171);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(120, 40);
            this.btnRegist.TabIndex = 2;
            this.btnRegist.Text = "新規登録する";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegist);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.パスワード);
            this.Controls.Add(this.ユーザーID);
            this.Controls.Add(this.Register);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新規登録";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Register;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label パスワード;
        private System.Windows.Forms.Label ユーザーID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRegist;
    }
}