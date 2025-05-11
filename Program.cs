using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using C = System.Console;

class Program
{
    static void Main(string[] args)
    {
#if DEBUG
        Test();
#else
        Exec();
#endif
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static void Test()
    {
        SetTestInput("4 2");
        TestExec();

        SetTestInput("10 20");
        TestExec();

        SetTestInput("1000000 500000");
        TestExec();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    static void Exec()
    {

    }

    #region Helper
    private static StringReader? s_testInput;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void SetTestInput(string input)
    {
        C.WriteLine(input);
        s_testInput = new StringReader(input);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string ReadLine()
    {
        if (s_testInput != null) return s_testInput.ReadLine()!;
        else return C.ReadLine()!;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int ReadInt() => Read<int>();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int[] ReadIntArray(string separator = " ") => ReadLineArray<int>(separator);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string ReadString() => Read<string>();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string[] ReadStringArray(string separator = " ") => ReadLineArray<string>(separator);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static T Read<T>() where T : IConvertible => (T)Convert.ChangeType(ReadLine(), typeof(T))!;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static T[] ReadLineArray<T>(string separator = " ") where T : IConvertible
        => ReadLine()
            .Split(separator, StringSplitOptions.RemoveEmptyEntries)
            .Select(item => (T)Convert.ChangeType(item, typeof(T)))
            .ToArray();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void WriteLine(object value) => C.WriteLine(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static void TestExec(Action? action = null)
    {
        var timer = new Stopwatch();
        timer.Start();
        if (action is not null) action();
        else Exec();
        timer.Stop();
        WriteLine($"ExecTime: {timer.ElapsedMilliseconds} ms");
    }
    #endregion Helper
}