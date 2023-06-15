// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

// int str = Prompt("Введите количество строк: ");
// int col = Prompt("Введите количество столбцов: ");
Console.Write($"Прямоуголник построен из данных 3 на 4");
Console.WriteLine();

int[,] Mass = CreateMassive(3, 4);
PrintMassive(Mass);

SummStrMassive(Mass);
// PrintMassive(Mass);

// int Prompt(string msg)
// {
//     Console.Write(msg);
//     int mess = int.Parse(Console.ReadLine()!);
//     return mess;
// }

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

void SummStrMassive(int[,] mass)
{
    int str = mass.GetLength(0);
    int col = mass.GetLength(1);

    int elementstr = 0;
    int summel = 0;
    int min = 0;
    for (int k = 0; k < col; k++)
    {

        elementstr += mass[0, k];

    }
    Console.WriteLine($"Число из строки с которой будем стравнивать минимальные занчения = {elementstr} ");
    Console.WriteLine();

    for (int j = 0; j < str; j++)
    {
        min = 0;
        for (int i = 0; i < col; i++)
        {
            min += mass[j, i];
            
            if (min < elementstr)
            {
                elementstr = min;
                summel = j;
            }
        }
        
        Console.WriteLine($"{j + 1} = {min} ");
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма чисел из всех строк находяться под строкой номер = {summel + 1} ");
    Console.WriteLine();
}