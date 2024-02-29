using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 2, 9, 1, 6, 4 }; // Початковий масив для сортування
        Console.WriteLine("Початковий масив:");
        PrintArray(array);

        Console.WriteLine("Виберіть порядок сортування: ");
        Console.WriteLine("1. Зростання");
        Console.WriteLine("2. Спадання");
        int choice = Convert.ToInt32(Console.ReadLine());

        BubbleSort(array, choice == 1); // Виклик методу сортування залежно від вибору користувача

        Console.WriteLine(choice == 1 ? "Масив після сортування за зростанням:" : "Масив після сортування за спаданням:");
        PrintArray(array);
    }

    static void BubbleSort(int[] arr, bool ascending)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (ascending ? arr[j] > arr[j + 1] : arr[j] < arr[j + 1])
                {
                    // Обмін елементів
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
