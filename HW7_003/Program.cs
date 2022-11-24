// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

void PrintArray(int[,] matr)
{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}


void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}

double AverageColumns(int[,] matrix)
{
    double average = new double [matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average[j] += matrix[j, j];
        }
        average[j] = average[j] / matrix.GetLength(0);
    }
    return average;
}

void PrintAverage (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]}; ");
}

int m = Prompt("Введите количество строк: ");
int n = Prompt("Введите количество столбцов: ");
int [,] matrix = new int[m, n];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.Write($"Среднее арифметическое каждого столбца: ");
PrintAverage(AverageColumns(matrix));