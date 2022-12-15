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
            Console.Write($"{inArray[i, j],3} ");
        }
        Console.WriteLine();
    }
}

int size = 0;
while ((size < 2) || (size > 10))
{
    Console.Write("Введите размерность массива (2-10): ");
    size = int.Parse(Console.ReadLine());
}

int[,] array = new int[size, size];
int x = 0;
int y = 0;
int dx = 1;
int dy = 0;

for (int i = 0; i < size * size; i++)
{
    array[y, x] = i + 1;

    if (dy == 0) // направление влево-вправо
    {
        switch (dx)
        {
            // направление вправо > вниз
            case 1:
                if ((x + 1 == size) || (array[y, x + 1] != 0))
                { dx = 0; dy = 1; }; break;
            // напрвление влево > вверх
            case -1:
                if ((x - 1 < 0) || (array[y, x - 1] != 0))
                { dx = 0; dy = -1; }; break;
        }
    }

    if (dx == 0) // направление вверх-вниз
    {
        switch (dy)
        {
            // направление вниз > влево
            case 1:
                if ((y + 1 == size) || (array[y + 1, x] != 0))
                { dx = -1; dy = 0; }; break;
            // напрвление вверх > вправо
            case -1:
                if ((y - 1 < 0) || (array[y - 1, x] != 0))
                { dx = 1; dy = 0; }; break;
        }
    }

    x += dx;
    y += dy;

}

PrintArray(array);