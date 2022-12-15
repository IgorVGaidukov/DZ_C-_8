// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            Console.Write($"{inArray[i, j],3} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultArray(int[,] inArray1, int[,] inArray2)
{
    int [,] resArray = new int[inArray1.GetLength(0),inArray1.GetLength(1)];
    
    for (int i = 0; i < inArray1.GetLength(0); i++)
        for (int j = 0; j < inArray1.GetLength(1); j++)
            resArray[i, j] = inArray1[i, j]*inArray2[i, j];
    
    return resArray;
}

int[,] array1 = GetArrayMatrix(rows, columns, 0, 9);
int[,] array2 = GetArrayMatrix(rows, columns, 0, 9);

Console.WriteLine("Массив 1");
PrintArray(array1);

Console.WriteLine("Массив 2");
PrintArray(array2);

Console.WriteLine("Произведение массивов 1 и 2");
PrintArray(MultArray(array1,array2));