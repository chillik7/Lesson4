using System;
class Program
{
    static void Main()
    {
        int[] numbers = { 5, 10, 15, 20, 25 };
        double average = ArrayHelper.CalculateAverage(numbers);

        Console.WriteLine($"Среднее значение массива: {average}");
    }
}
static class ArrayHelper
{
    public static double CalculateAverage(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Массив пустой или null");
        }

        double sum = 0;
        foreach (var num in array)
        {
            sum += num;
        }

        return sum / array.Length;
    }
}

