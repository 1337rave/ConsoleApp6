using System;

class Matrix
{
    private int[,] matrix;
    private int rows;
    private int columns;

    public Matrix(int rows, int columns)
    {
        this.rows = rows;
        this.columns = columns;
        matrix = new int[rows, columns];
    }

    public void InputMatrix()
    {
        Console.WriteLine("Enter matrix elements:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Enter element [{i},{j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    public void DisplayMatrix()
    {
        Console.WriteLine("Matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public int FindMax()
    {
        int max = matrix[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
            }
        }
        return max;
    }

    public int FindMin()
    {
        int min = matrix[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                }
            }
        }
        return min;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows in the matrix:");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number of columns in the matrix:");
        int columns = Convert.ToInt32(Console.ReadLine());

        Matrix matrix = new Matrix(rows, columns);
        matrix.InputMatrix();
        matrix.DisplayMatrix();

        int max = matrix.FindMax();
        int min = matrix.FindMin();

        Console.WriteLine($"Maximum element in the matrix: {max}");
        Console.WriteLine($"Minimum element in the matrix: {min}");
    }
}
