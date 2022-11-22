// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7    -2   -0,2
// 1   -3,3   8   -9,9
// 8    7,8  -7,1  9

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

double[,] CreateArray(int rows, int columns, int lowerLim, int upperLim)
{
    double[,] table = new double[rows, columns];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = Math.Round(new Random().Next(lowerLim, upperLim) + new Random().NextDouble(),2);
        }
    }
    return table;
}

void PrintArray(double[,] array)
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

void Runner()
{
    int rows = Prompt("Введите количество строк ");
    int columns = Prompt("Введите количество столбцов ");
    int lowLim = Prompt("Введите нижний предел для значения элемента массива");
    int upperLim = Prompt("Введите верхний предел для значения элемента массива");
    System.Console.WriteLine();
    double[,] array = CreateArray(rows, columns, lowLim, upperLim);
    PrintArray(array);
}
Runner();