WPFアプリ(.NET Framework4.7.2)用ひな形プロジェクト

■Domain
　・説明　外部に依存しないプレーンなC#コード
　・依存関係　なし

■Infrastructure
　・説明　外部(File、DB)との接続を担当
　・依存関係　Domain

■API
　・説明　ユーザに画面ではなくコマンドラインインタフェースを公開する場合に使用
　・依存関係　Domain、Infrastructure

■WPF or WinForm
　・説明　画面
　・依存関係　Domain、Infrastructure

■Tests
　・単体テスト用
　・依存関係　Domain、Infrastructure、API、WPF

