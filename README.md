# AtCoderのC#用ヘルパー

## 問題の解答を記述
```cs
static void Exec()
{
    // AtCoderの問題の解答を記述

    // 標準入力から1行をint型で読み込み
    var i = ReadInt();

    // 標準入力から1行をint型の配列で読み込み
    var array = ReadIntArray();
}
```

## テスト
`#if DEBUG`ディレクティブを使用しているため、デバッグ実行時はテストが実行されます。
AtCoderに提出する場合はそのままコード全文を提出すればOKです。
```cs
static void Test()
{
    // 入力値
    // 3
    // 123 456 789
    SetTestInput("3\n123 456 789");
    TestExec();

    // 複数ケースをテストする場合は上記記述を複数記述
    SetTestInput("3\n123 456 789");
    TestExec();

    SetTestInput("3\n123 456 789");
    TestExec();
}
```
