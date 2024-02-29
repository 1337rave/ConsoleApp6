using System;

class Program
{
    static void Main()
    {
        int numberToCheck = 13; // Задане число для перевірки
        bool isFibonacciOrPrime = IsFibonacciOrPrime(numberToCheck);

        if (isFibonacciOrPrime)
        {
            Console.WriteLine($"{numberToCheck} є або числом Фібоначчі, або простим числом.");
        }
        else
        {
            Console.WriteLine($"{numberToCheck} не є або числом Фібоначчі, або простим числом.");
        }
    }

    static bool IsPerfectSquare(int x)
    {
        int s = (int)Math.Sqrt(x);
        return (s * s == x);
    }

    static bool IsFibonacciOrPrime(int n)
    {
        if (n <= 0)
            return false;

        // Перевірка, чи є число Фібоначчі
        int fib1 = 0, fib2 = 1;
        while (fib2 < n)
        {
            int temp = fib2;
            fib2 = fib1 + fib2;
            fib1 = temp;
        }
        if (fib2 == n)
            return true;

        // Перевірка, чи є число простим
        if (n == 1 || n == 2)
            return true;
        if (n % 2 == 0)
            return false;
        for (int i = 3; i <= Math.Sqrt(n); i += 2)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
}
