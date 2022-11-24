// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int PromptInt(string strMessage)
{
    Console.Write(strMessage);
    int temp;
    if (int.TryParse(Console.ReadLine(), out temp))
    {
        return temp;
    }

    throw new Exception("Это не число!!!");
}

int Prompt(string message)
{
    while (true)
    try
    {
        return PromptInt(message);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Ошибка ввода: {e.Message}");
    }
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

void FindElement(int[,] array, int posI, int posJ)
{
    if (posI < array.GetLength(0)
    && posJ < array.GetLength(1))
    {
        Console.WriteLine($"Позиции [{posI},{posJ}] соответствует числу {array[posI, posJ]}");
        return;
    }

    Console.WriteLine($"такого числа в массиве нет");
}
int m = Prompt("Введите количество строк: ");
int n = Prompt("Введите количество столбцов: ");
Console.WriteLine();
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
int posI = Prompt("Введите позицию строки в массиве ");
int posJ = Prompt("Введите позицию стольбца в массиве ");
FindElement(matrix, posI, posJ);