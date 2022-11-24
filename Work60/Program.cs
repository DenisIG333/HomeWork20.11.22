/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы
каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int size1 = UserInput("размерность 1: ");
int size2 = UserInput("размерность 2: ");
int size3 = UserInput("размерность 3: ");
int NumbersCount = 89;

if (size1 * size2 * size3 > NumbersCount)
{
    Console.Write("Массив слишком большой");
    return;
}

int[,,] NumbersResult = Array3D(size1, size2, size3);

for (int i = 0; i < NumbersResult.GetLength(0); i++)
{
    for (int j = 0; j < NumbersResult.GetLength(1); j++)
    {
        for (int k = 0; k < NumbersResult.GetLength(2); k++)
        {
            Console.WriteLine($"({i},{j},{k}) - {NumbersResult[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] Array3D(int size1, int size2, int size3)
{
    Random rnd = new Random();
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[NumbersCount];
    int num = 10;

    for (int i = 0; i < values.Length; i++)
        values[i] = num++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInt = rnd.Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInt];
        values[randomInt] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}


int UserInput(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
