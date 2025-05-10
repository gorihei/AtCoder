using System;

class Program
{
    static void Main(string[] args)
    {
        Test();
        //Exec();
    }

    static void Test()
    {
        // 入力値
        // 3
        // 123 456 789
        ConsoleHelper.SetTestInput("3\n123 456 789");
        Exec();
    }

    static void Exec()
    {
        var value = ConsoleHelper.ReadInt(); // ⇒ 3
        var array = ConsoleHelper.ReadIntArray(); // ⇒ [123, 456, 789]
    }

    static class ConsoleHelper
    {
        private static StringReader? s_testInput;
        public static void SetTestInput(string input)
        {
            Console.WriteLine(input);
            s_testInput = new StringReader(input);
        }
        private static string ReadLine()
        {
            if (s_testInput != null) return s_testInput.ReadLine()!;
            else return Console.ReadLine()!;
        }
        public static int ReadInt() => Read<int>();
        public static int[] ReadIntArray(string separator = " ") => ReadLineArray<int>(separator);
        public static string ReadString() => Read<string>();
        public static string[] ReadStringArray(string separator = " ") => ReadLineArray<string>(separator);
        public static T Read<T>() where T : IConvertible => (T)Convert.ChangeType(ReadLine(), typeof(T))!;
        public static T[] ReadLineArray<T>(string separator = " ") where T : IConvertible
            => ReadLine()
                .Split(separator, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => (T)Convert.ChangeType(item, typeof(T)))
                .ToArray();
    }
}