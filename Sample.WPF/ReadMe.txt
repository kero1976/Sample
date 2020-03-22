■WPF
　・説明　画面
　・依存関係　Domain、Infrastructure

■補足説明
・MVVMパターンを使用する。ModelはDomainInfrastructureが担うため、ViewとViewModelを格納する。
・View

■フォルダ構成
・ViewModels
	ファイル名の最後は「ViewModel」とする。

・Views
	ファイル名の最後は「View」とする。

・BackgroundWorkers　タイマーイベント等を格納する。(保守性を上げるため、Domainに格納せず、ここに格納する)

■スタイルについて
