// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Write("Введите номер строки: ");
int numberString = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int numberColumns = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrixRndInt(int sumString1, int sumColumns1)
{
    int[,] matrix = new int[sumString1, sumColumns1];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 100);
        }
    }
    return matrix;
}
int[,] array2D = CreateMatrixRndInt(10, 10);

int SearchNumber(int[,] array2D1, int numberString1, int numberColumns1)
{
    int num = 0;
    if (numberString1 > array2D1.GetLength(0) || numberColumns1 > array2D1.GetLength(1))
    {
        num = 0;
    }
    else num = array2D1[numberString1 - 1, numberColumns1 - 1];
    return num;
}
int result = SearchNumber(array2D, numberString, numberColumns);


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3}  ");
        }
        Console.WriteLine("]");
    }
}

PrintMatrix(array2D);
if(result==0) Console.Write("Такого числа нет");
else Console.WriteLine($"На пересечении строки №{numberString} и столбца №{numberColumns} находится число - {result}");

