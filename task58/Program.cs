// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int str = Prompt("Введите количество строк: ");
int col = Prompt("Введите количество столбцов: ");

Console.Write("Вывод первой матрицы");
Console.WriteLine();
int[,] Mass = CreateMassive(str, col); //Создание первой матрицы
PrintMassive(Mass);

Console.Write("Вывод второй матрицы");
Console.WriteLine();
int[,] Mass2 = CreateMassive(str, col); // Создание второй матрицы
PrintMassive(Mass2);

if (Mass.GetLength(0) == Mass2.GetLength(1)) //Итоговая матрица
{
    int[,] Mass3 = CreateMassive(str, col); 
    ResultatMatrix(Mass, Mass2, Mass3);

    Console.Write("Вывод итогой матрицы");
    Console.WriteLine();
    PrintMassive(Mass3);
}
else
{
    Console.WriteLine();
    Console.Write("Нельзя переумножить!");
}

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

int[,] ResultatMatrix(int[,] elmass, int[,] elmass2, int[,] elmass3)
{

    for (int i = 0; i < elmass.GetLength(0); i++)
    {
        for (int j = 0; j < elmass2.GetLength(1); j++)
        {
            elmass3[i, j] = 0;
            for (int k = 0; k < elmass.GetLength(1); k++)
            {
                elmass3[i, j] += elmass[i, k] * elmass2[k, j];
            }
        }
    }
    Console.WriteLine();


    return elmass3;


}