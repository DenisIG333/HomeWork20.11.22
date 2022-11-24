/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
 */

Console.WriteLine("Введите размер массива");
int arraySize = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] nums = new int[arraySize, arraySize];

int number = 1;
int i = 0;
int j = 0;

while (number <= arraySize * arraySize)
{
    nums[i, j] = number;
    if (i <= j + 1 && i + j < arraySize - 1)
        ++j;
    else if (i < j && i + j >= arraySize - 1)
        ++i;
    else if (i >= j && i + j > arraySize - 1)
        --j;
    else
        --i;
    ++number;
}

Print(nums);

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}