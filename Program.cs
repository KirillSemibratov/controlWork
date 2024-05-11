using System;

class Program
{
    static void Main()
    {
        string[] initialArray = { "Hello", "2", "world", ":-)" };
        // string[] initialArray = { "1234", "1567", "-2", "computer science" };
        // string[] initialArray = { "Russia", "Denmark", "Kazan" };
        string[] shortStrings = FilterShortStrings(initialArray);
        Console.WriteLine(string.Join(", ", shortStrings)); // Выводит результат
    }

    static string[] FilterShortStrings(string[] inputStrings)
    {
        string[] result = new string[0];
        foreach (var str in inputStrings)
        {
            if (str.Length <= 3)
            {
                string[] tempResult = new string[result.Length + 1];
                Array.Copy(result, tempResult, result.Length);
                tempResult[result.Length] = str;
                result = tempResult;
            }
        }
        return result;
    }
}

