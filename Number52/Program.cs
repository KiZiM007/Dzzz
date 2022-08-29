// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Write("Задайте колличество строк: ");
int numberString = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте колличество столбцов: ");
int numberColumns = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrixRndInt(int numberString1, int numberColumns1)
{
    int[,] matrix = new int[numberString1, numberColumns1];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}
int[,] array2D = CreateMatrixRndInt(numberString, numberColumns);


double[] SumColumns(int[,] arr2D, int numberString1, int numberColumns1)
{
    double[] average = new double[numberColumns1];
    for (int i = 0; i < arr2D.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr2D.GetLength(0); j++)
        {
            sum = sum + arr2D[j, i];
        }
        average[i] = Math.Round(sum / numberString1, 3);
    }

    return average;
}
double[] result = SumColumns(array2D, numberString, numberColumns);

void PrintMatrix(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            if (j < arr2D.GetLength(1) - 1) Console.Write($"{arr2D[i, j],5}, ");
            else Console.Write($"{arr2D[i, j],5}    ");
        }
        Console.WriteLine("]");
    }
}


void Print(double[] end)
{
    Console.Write("[");
    for (int i = 0; i < end.Length; i++)
    {
        if (i < end.Length - 1) Console.Write($"  {Math.Round(end[i], 2, MidpointRounding.ToZero),5}");
        else Console.Write($"  {Math.Round(end[i], 2, MidpointRounding.ToZero),5}  ");
    }
    Console.WriteLine("]");
}
PrintMatrix(array2D);
Console.WriteLine();
Print(result);