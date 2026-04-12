# FF14 RaidLog (固定活動記録アプリ)

FF14（ファイナルファンタジーXIV）のレイド活動を管理するための、Windows Formsデスクトップアプリケーションです。
活動時間の自動計算や、各コンテンツ（絶オメガ、絶竜詩、エデン等）の進捗管理をサポートします。

### ⬇️ ダウンロード＆インストール
以下のリンクをクリックし、「アプリをダウンロード」ボタンから `setup.exe` を実行してください。
👉 **[RaidLog インストールページを開く](https://y-wkot.github.io/RaidLog_Public/)**

※警告が出た場合は「詳細情報」→「実行」を選択してください。

---

## 🛠 技術スタック

| カテゴリ | 使用技術 |
| :--- | :--- |
| **言語 / フレームワーク** | C# / .NET Framework 4.8 |
| **UI** | Windows Forms (WinForms) |
| **バックエンド / DB** | [Supabase](https://supabase.com/) (PostgreSQL) |
| **認証** | Supabase Auth (Email/Password) |
| **ライブラリ** | supabase-csharp, Microsoft.Extensions.Configuration |

---

## ✨ 主な機能

* **ユーザー認証機能**: Supabase Authを利用したセキュアなログイン・新規登録。
* **レイドログ管理**: 絶・零式などの活動進捗を記録。
* **活動時間計算**: 入力されたログから活動時間を自動で算出。
* **バージョン情報通知**: 最新の対応コンテンツや更新情報をアプリ内で確認可能。

---

## 🔒 セキュリティとデータ保護

本プロジェクトでは、公開リポジトリでの運用を想定し、以下のセキュリティ対策を実施しています。

* **秘密鍵の管理**: APIキーやURLなどの機密情報は `appsettings.json` で管理し、`.gitignore` によりリポジトリから除外しています。
* **通信の保護**: TLS 1.2 暗号化プロトコルを使用し、通信の傍受を防止しています。
* **Row Level Security (RLS)**: Supabaseのポリシーを利用し、ユーザーは**自分自身のデータのみ**を参照・操作できるようデータベースレベルで保護されています。
* **パスワード保護**: Supabase Authにより、パスワードはハッシュ化された状態で安全に管理されています。

---

## 🚀 セットアップ方法

本アプリを自身の環境でビルド・実行する場合は、以下の手順が必要です。

1. **リポジトリをクローンする**
   ```bash
   git clone [https://github.com/y-wkot/RaidLog_Public.git](https://github.com/y-wkot/RaidLog_Public.git)

2．設定ファイルの作成

ルートディレクトリにある appsettings.json.example をコピーして、名前を appsettings.json に変更します。

自身のSupabaseプロジェクトの URL と Anon Key を記入してください。
{
  "Supabase": {
    "Url": "YOUR_SUPABASE_URL",
    "Key": "YOUR_SUPABASE_ANON_KEY"
  }
}

3．NuGetパッケージの復元
Visual Studioでソリューションファイル（.sln）を開き、ビルドを実行すると必要なパッケージが自動的にインストールされます。
