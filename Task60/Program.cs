// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int x = 0;
int y = 0;
int z = 0;
int maxArraySize = 90; // Максимальное кол-во неповторяющихся двухзначных чисел 
int currentArraySize = 0;

// Вводим размер массива пока он не будет удовлетворять условиям задачи
while ((currentArraySize < 1) || (currentArraySize > maxArraySize))
{
    Console.Write("Введите количество строк массива: ");
    x = int.Parse(Console.ReadLine());

    Console.Write("Введите количество столбцов массива: ");
    y = int.Parse(Console.ReadLine());

    Console.Write("Введите глубину массива: ");
    z = int.Parse(Console.ReadLine());

    currentArraySize = x * y * z;
}

int[,,] GetArrayMatrix(int ix, int iy, int iz, int minValue, int maxValue)
{
    int[,,] result = new int[ix, iy, iz];
    int newValue = 0;

    for (int i = 0; i < ix; i++)
        for (int j = 0; j < iy; j++)
            for (int k = 0; k < iz; k++)
            {
                do
                {
                    newValue = new Random().Next(minValue, maxValue + 1);
                }
                // while (ValueCountInArray(result, newValue) > 0);
                while (IsValueInArray(result, newValue));

                result[i, j, k] = newValue;
            }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
                Console.Write($"{inArray[i, j, k]}({i},{j},{k}) ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

bool IsValueInArray(int[,,] inArray, int value) // Проверка наличия числа в массиве
{
    bool fl = false;

    foreach (int el in inArray)
    {
        if (el == value) fl = true;
    }

    return fl;
}

int ValueCountInArray(int[,,] inArray, int value)
{
    var count = 0;

    for (int i = 0; i < inArray.GetLength(0); i++)
        for (int j = 0; j < inArray.GetLength(1); j++)
            for (int k = 0; k < inArray.GetLength(2); k++)
                if (value == inArray[i, j, k])
                    count++;
    return count;
}

int[,,] array = GetArrayMatrix(x, y, z, 10, 99);

PrintArray(array);

// Проверка дублирования элементов в массиве

// int ValCount = 0;
// for (int i = 0; i < x; i++)
//     for (int j = 0; j < y; j++)
//         for (int k = 0; k < z; k++)
//         {
//             ValCount = ValueCountInArray(array, array[i, j, k]);
//             if (ValCount > 1)
//                 Console.Write($"{array[i, j, k]}-{ValCount} ");
//         }
