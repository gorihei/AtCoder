# AtCoderのC#用ヘルパー

## 問題の解答を記述
```cs
static void Exec()
{
    // AtCoderの問題の解答を記述

    // 標準入力から1行をint型で読み込み
    var i = ConsoleHelper.ReadInt();

    // 標準入力から1行をint型の配列で読み込み
    var array = ConsoleHelper.ReadIntArray();
}
```

## テスト

```cs
static void Main(string[] args)
{
    // Execをコメントアウトしてテストを実行する
    Test();

    // 提出する際はTestをコメントアウトしてExecのコメントアウトを解除する
    //Exec();
}


static void Test()
{
    // 入力値
    // 3
    // 123 456 789
    ConsoleHelper.SetTestInput("3\n123 456 789");
    Exec();

    // 複数ケースをテストする場合は上記記述を複数記述
    ConsoleHelper.SetTestInput("3\n123 456 789");
    Exec();

    ConsoleHelper.SetTestInput("3\n123 456 789");
    Exec();
}
```
