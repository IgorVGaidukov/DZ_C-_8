// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

Console.Write("Введите количество строк массива: ");
var rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
var columns = int.Parse(Console.ReadLine());

int[,] GetArrayMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] SortArray(int[,] inArray)
{
    int[,] outArray =  inArray;
    int temp;

    for (int i = 0; i < outArray.GetLength(0); i++)
    {
        for (int j = 0; j < outArray.GetLength(1); j++)
        {
            for (int k = 0; k < outArray.GetLength(1)-1; k++)
            if (outArray[i,k]<outArray[i,k+1])
            {
                temp = outArray[i,k];
                outArray[i,k] = outArray[i,k+1];
                outArray[i,k+1] = temp;
            };
        }
    }
    return outArray;
} 

int[,] array = GetArrayMatrix(rows, columns, 0, 9);

PrintArray(array);

PrintArray(SortArray(array));