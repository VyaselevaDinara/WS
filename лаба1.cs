csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        double x, sum = 0;
        int n;

        Console.Write("Введите значение x: ");
        x = double.Parse(Console.ReadLine());

        // рассчитываем сумму с заданной точностью
        for (n = 0; n <= 1000; n++)
        {
            double term = Math.Pow(-1, n) * Math.Pow(x, n) / Factorial(n);
            sum += term;

            if (Math.Abs(term) < 0.0001) // задаем точность
                break;
        }

        Console.WriteLine("e^-x = " + sum);
    }

    // функция для вычисления факториала
    static int Factorial(int n)
    {
        int fact = 1;

        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }

        return fact;
    }
}