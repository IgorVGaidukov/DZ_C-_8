// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int GetMinSumRows(int[,] inArray)
{
    int MinSumRowIndex = 0;
    int MinSumRow = 0;
    int SumRow; 
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        SumRow = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            SumRow += inArray[i, j];
        }
        if (i == 0)
            MinSumRow = SumRow;
        else 
            if (SumRow < MinSumRow)
            {    
                MinSumRow = SumRow;
                MinSumRowIndex = i;
            }
    }

    return MinSumRowIndex;
}

int[,] array = GetArrayMatrix(rows, columns, 0, 9);

PrintArray(array);

Console.WriteLine($"номер строки с наименьшей суммой элементов: {GetMinSumRows(array)+1} строка");