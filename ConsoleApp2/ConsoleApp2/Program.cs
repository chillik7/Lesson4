using System;

class Program
{
    static void Main()
    {
        int K, D1, D2;

        Console.Write("Введите начальное число K: ");
        K = int.Parse(Console.ReadLine());

        Console.Write("Введите первую цифру D1 (0-9): ");
        D1 = int.Parse(Console.ReadLine());

        Console.Write("Введите вторую цифру D2 (0-9): ");
        D2 = int.Parse(Console.ReadLine());

        AddRightDigit(D1, ref K);
        Console.WriteLine($"После добавления {D1}: {K}");

        AddRightDigit(D2, ref K);
        Console.WriteLine($"После добавления {D2}: {K}");
    }

    static void AddRightDigit(int D, ref int K)
    {
        if (D < 0 || D > 9)
        {
            Console.WriteLine("Ошибка: цифра D должна быть в диапазоне 0-9.");
            return;
        }

        K = K * 10 + D;
    }
}

