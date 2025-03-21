using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число для проверки на простоту: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 2)
        {
            Console.WriteLine("Число должно быть больше или равно 2.");
            return;
        }

        bool result = IsPrime(number, 2);
        Console.WriteLine($"Число {number} {(result ? "простое" : "не является простым")}.");
    }
    static bool IsPrime(int n, int divisor)
    {
        if (n <= 2)
            return n == 2; 

        if (n % divisor == 0)
            return false; 

        if (divisor * divisor > n)
            return true; 

        return IsPrime(n, divisor + 1); 
    }
}

