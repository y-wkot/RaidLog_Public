using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Supabase;
using System.Reflection;
using System.IO;

// Supabase Auth利用によるIDとパスワード認証
// PWはハッシュ化（暗号化）される。TLS1.2という暗号化プロトコルを使用して保護される。通信内容が盗聴されない。
// 認証成功時に発行されるUUIDをprofilesテーブルのidカラムに保存して管理。

namespace RaidLog
{
    public partial class LoginForm : Form
    {
        private string supabaseUrl;
        private string supabaseKey;
        private Supabase.Client supabase;

        public LoginForm()
        {
            InitializeComponent();

            try
            {
                // 実行中のアセンブリ（自分自身）を取得
                var assembly = Assembly.GetExecutingAssembly();

                var resourceName = "RaidLog.appsettings.json";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                {
                    if (stream == null)
                    {
                        // リソースが見つからない場合はエラーを投げる
                        throw new FileNotFoundException($"リソース '{resourceName}' が見つかりません。プロパティで「埋め込みリソース」に設定されているか確認してください。");
                    }

                    // AddJsonStream を使って内蔵された json を読み込む
                    var config = new ConfigurationBuilder()
                        .AddJsonStream(stream)
                        .Build();

                    // jsonの中身を取得して箱に入れる
                    supabaseUrl = config["Supabase:Url"];
                    supabaseKey = config["Supabase:Key"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("設定ファイルの読み込みに失敗しました。ファイルが存在するか確認してください。\n" + ex.Message);
            }
        }

        // バージョン更新したら
        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            // アプリ自身のバージョン情報を自動取得
            string version = Application.ProductVersion;

            // 内容をとりあえずここに・・・
            string info = "【1.0.0.0更新情報】\n" +
                          "・絶オメガ検証戦 対応版リリース！\n" +
                          "・活動時間の自動計算機能を追加\n" +
                          "・竜詩、エデンを随時作成中\n" +
                          "【1.0.0.1更新情報】\n" +
                          "・ウインドウ出現位置を調整しました。";

            MessageBox.Show(info, $"バージョン {version} の詳細", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            // ラベルに現在のバージョンを表示
            lblVer.Text = "ver" + Application.ProductVersion;

            // 通信設定
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            // Supabaseの設定
            var options = new SupabaseOptions
            {
                AutoConnectRealtime = true
            };

            // Supabase初期化
            supabase = new Supabase.Client(supabaseUrl, supabaseKey, options);
            await supabase.InitializeAsync();

            // エンターでログインボタンを反応させる
            this.AcceptButton = btnLogin;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm(this.supabase);
            regForm.ShowDialog();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            // コントロールから入力値を取得
            string id = txtUserId.Text;
            string pw = txtPassword.Text;

            // 入力チェック
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(pw))
            {
                MessageBox.Show("IDとパスワードを入力してください。");
                return;
            }
            try
            {
                // 疑似的メールアドレスの生成
                string pseudoEmail = id + "@example.com";

                // supabase Authサインイン
                var session = await supabase.Auth.SignIn(pseudoEmail, pw);

                if (session != null && session.User != null)
                {
                    // OK
                    MessageBox.Show("ログイン成功");

                    // TODO:ここからMenuFormの実装
                    MenuForm menuForm = new MenuForm(this.supabase);
                    menuForm.Show();

                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                // NG
                MessageBox.Show("ログイン失敗");
            }
        }

        public void ClearInput()
        {
            txtUserId.Text = "";
            txtPassword.Text = "";
        }

        private void buttoncloseapp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void FocusIdInput()
        {
            txtUserId.Focus();
        }
    }
}



