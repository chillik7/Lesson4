using System;
using System.Linq;
static class StringExtensions
{
    public static bool IsNumeric(this string str)
    {
        return !string.IsNullOrEmpty(str) && str.All(char.IsDigit);
    }
}
class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        if (input.IsNumeric())
            Console.WriteLine("Строка содержит только цифры.");
        else
            Console.WriteLine("Строка содержит не только цифры.");
    }
}

