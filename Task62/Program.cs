// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

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
}

int size = 4;
int[,] array = new int[size, size];
int count = 1;

for (int i = 0; i < size; i++)
{
    // for (int j = 0; j < size; j++)
    // {
    //     if (((i == 0) && (j < size - 1)) || (j == size - 1))
    //         array[i, j] = count;



        count++;
    }
}

PrintArray(array);