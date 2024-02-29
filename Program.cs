using System;

class RangeMultiplier
{
    public int Start { get; }
    public int End { get; }

    public RangeMultiplier(int start, int end)
    {
        Start = start;
        End = end;
    }

    public int GetProduct()
    {
        int product = 1;
        for (int i = Start; i <= End; i++)
        {
            product *= i;
        }
        return product;
    }
}

class Program
{
    static void Main()
    {
        int startRange = 1;
        int endRange = 5;

        RangeMultiplier rangeMultiplier = new RangeMultiplier(startRange, endRange);
        int product = rangeMultiplier.GetProduct();

        Console.WriteLine($"Добуток чисел у діапазоні від {startRange} до {endRange} дорівнює {product}");
    }
}
