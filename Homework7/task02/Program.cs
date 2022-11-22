// Задача 2: Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

int[,] CreateArray(int rows, int columns, int lowerLim, int upperLim)
{
    int[,] table = new int[rows, columns];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(lowerLim, upperLim);
        }
    }
    return table;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindElement(int[,] array, int posI, int posJ)
{
    if (posI >= 0 && posJ >= 0 
    && posI < array.GetLength(0)
    && posJ < array.GetLength(1))
    {
        System.Console.WriteLine(($"Позиции [{posJ}, {posI}] соответствует число {array[posI,posJ]}"));
        return;
    }
    System.Console.WriteLine("Такого элемента нет в массиве");
}

void Runner()
{
    int rows = Prompt("Введите количество строк ");
    int columns = Prompt("Введите количество столбцов ");
    int lowLim = Prompt("Введите нижний предел для значения элемента массива");
    int upperLim = Prompt("Введите верхний предел для значения элемента массива");
    System.Console.WriteLine();
    int[,] array = CreateArray(rows, columns, lowLim, upperLim);
    PrintArray(array);
    System.Console.WriteLine();
    int posJ = Prompt("Позиция элемента в строке: ");
    int posI = Prompt("Позиция элемента в столбце: ");
    FindElement(array, posI, posJ);
}
Runner();
