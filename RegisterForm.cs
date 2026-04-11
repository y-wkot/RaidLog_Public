using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RaidLog
{
    public partial class RegisterForm : Form
    {
        private Supabase.Client supabase;
        public RegisterForm(Supabase.Client client)
        {
            InitializeComponent();
            this.supabase = client;
        }

        // 新規登録ボタンクリック処理
        private async void btnRegist_Click(object sender, EventArgs e)
        {
            // 画面のテキストボックス
            string id = txtUserId.Text;
            string pw = txtPassword.Text;

            // バリデーション
            // ID：半角英数字1～20文字
            if (!Regex.IsMatch(id, "^[a-zA-Z0-9]{1,20}$"))
            {
                MessageBox.Show("IDは半角英数字1~20文字までの入力となります");
                return;
            }

            // PW: 半角英数字6~20文字
            if (!Regex.IsMatch(pw, "^[a-zA-Z0-9]{6,20}$"))
            {
                MessageBox.Show("パスワードは半角英数字6~20文字までの入力となります");
                return;
            }

            try
            {
                // 重複チェック：同じ名前のユーザーがいないか検索
                var existing = await supabase.From<Profile>()
                    .Where(x => x.UserName == id)
                    .Get();

                if (existing.Models.Count > 0)
                {
                    MessageBox.Show("このユーザー名は既に使われています。");
                    return;
                }

                // Supabase Authへ登録処理
                // メールアドレスである必要があるため、ユーザー入力のうしろにドメインつける
                string pseudoEmail = id + "@example.com";
                // ログイン用の認証情報作成
                var session = await supabase.Auth.SignUp(pseudoEmail, pw);

                if (session?.User != null)
                {
                    // UUIDを取得
                    string assignedUuid = session.User.Id;

                    var newProfile = new Profile
                    {
                        Id = assignedUuid,
                        UserName = id
                    };

                    // DBへinsert
                    await supabase.From<Profile>().Upsert(newProfile);

                    MessageBox.Show("登録完了。ログインページへ移動します。");
                    // 登録用ページを閉じる
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // 失敗時 $を付けると{}で囲った部分が変数に置き換わる
                MessageBox.Show($"登録に失敗しました。 \n管理者用：{ex.Message}");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}