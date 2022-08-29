// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Задайте колличество строк: ");
int numberString = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте колличество столбцов: ");
int numberColumns = Convert.ToInt32(Console.ReadLine());


double[,] CreateMatrixRndInt(int numberString1, int numberColumns1)
{
    double[,] matrix = new double[numberString1, numberColumns1];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // matrix[i, j] = rnd.Next(-9, 10); 
            matrix[i, j] = 20.0 * rnd.Next() / 2147483648 - 10.0;
        }
    }
    return matrix;
}


void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if (j < matrix.GetLength(1) - 1) Console.Write($"{Math.Round(matrix[i, j], 2, MidpointRounding.ToZero), 5} ");
            else Console.Write($"{Math.Round(matrix[i, j], 2, MidpointRounding.ToZero), 5} ");
        }
        Console.WriteLine("]");
    }
}
double[,] array2D = CreateMatrixRndInt(numberString, numberColumns);
PrintMatrix(array2D);