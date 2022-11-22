// Задача 2: Задайте двумерный массив. Найдите элементы, 
// у которых обе позиции чётные, и замените эти элементы на их квадраты.

int ReadData(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

int[,] GetNewArray(int[,] array)
{
    for (int i = 1; i < array.GetLength(0); i += 2)
    {
        for (int j = 1; j < array.GetLength(1); j += 2)
        {
            array[i, j] *= array[i, j];
        }
    }
    return array;
}

void Execute()
{
    int m = ReadData("Ввод количества строк");
    int n = ReadData("Ввод количества столбцов");
    System.Console.WriteLine();
    int[,] array = CreateArray(m, n);
    PrintArray(array);
    int[,] newArray = GetNewArray(array);
    PrintArray(newArray);
}

Execute();