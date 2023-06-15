// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

int str = Prompt("Введите количество строк: ");
int col = Prompt("Введите количество столбцов: ");

int[,] Mass = CreateMassive(str, col);
PrintMassive(Mass);
Console.WriteLine();

SortMassive(Mass);
PrintMassive(Mass);

int Prompt(string msg)
{
    Console.Write(msg);
    int mess = int.Parse(Console.ReadLine()!);
    return mess;
}

int[,] CreateMassive(int str, int col)
{
    int[,] mass = new int[str, col];

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(1, 10);
        }
    }
    return mass;
}

void PrintMassive(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write($"{mass[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortMassive(int[,] mass)
{
    int str = mass.GetLength(0);
    int col = mass.GetLength(1);
    int endstr = mass.GetLength(0) - 1;

    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < endstr; k++)
            {
                if (mass[i, k] < mass[i, k + 1])
                {
                    int temp = mass[i, k + 1];
                    mass[i, k + 1] = mass[i, k];
                    mass[i, k] = temp;
                    
                }
                
            }
        }
    }
}