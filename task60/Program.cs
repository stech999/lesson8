// Задача 60. *** ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0, 1, 0)
// 34(1, 0, 0) 41(1, 1, 0)
// 27(0, 0, 1) 90(0, 1, 1)
// 26(1, 0, 1) 55(1, 1, 1)

Console.Clear();

int[,,] mass = new int[2, 2, 2];

CreateMassive(mass);
PrintMassive(mass);

void CreateMassive(int[,,] elements)
{
    int count = 0;
    for (int i = 0; i < elements.GetLength(0); i++)
    {
        for (int j = 0; j < elements.GetLength(1); j++)
        {
            for (int k = 0; k < elements.GetLength(2); k++)
            {
                elements[i, j, k] = new Random().Next(10, 90);
                elements[i, j, k] += count;
                count++;
            }
        }
    }
}

void PrintMassive(int[,,] matrix3D)
{
    Console.Write("Матрица с неповторяюшимися индексами: ");
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                Console.Write($"{matrix3D[i, j, k]}({i}{j}{k}) ");
            }
        }
    }
}