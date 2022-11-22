// Задача 3: Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1   4   7
// 5   9   2
// 8   4   2
// Сумма элементов главной диагонали: 1+9+2 = 12

int PromptInt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

void PrintArray(int[,] arrNums)
{
    for (int i = 0; i < arrNums.GetLength(0); i++)
    {
        System.Console.Write($"{arrNums[i, 0]} ");
        for (int j = 1; j < arrNums.GetLength(1); j++)
        {
            System.Console.Write($"{arrNums[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

int SumDiagonal(int[,] array)
{
    int sum = 0;

    for (int m = 0; m < array.GetLength(1); m++)
    {
        sum = sum + array[m, m];
    }
    return sum;
}

void Execute()
{
    int intM = PromptInt ("Введите размерность M (строки): ");
    int intN = PromptInt ("Введите размерность N (столбцы): ");
    int[,] tempArray = FillArray(intM, intN);
    PrintArray(tempArray);
    System.Console.WriteLine(SumDiagonal(tempArray));
}

Execute();
