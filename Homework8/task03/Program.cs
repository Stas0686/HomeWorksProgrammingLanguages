// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int userInput = Convert.ToInt32(Console.ReadLine());
    return userInput;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secondMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

void Runner()
{
    Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
    int m = Prompt("Введите число строк 1-й матрицы: ");
    int n = Prompt("Введите число столбцов 1-й матрицы (и строк 2-й): ");
    int p = Prompt("Введите число столбцов 2-й матрицы: ");

    int[,] firstMartrix = new int[m, n];
    CreateArray(firstMartrix);
    Console.WriteLine("Первая матрица:");
    PrintArray(firstMartrix);

    int[,] secondMartrix = new int[n, p];
    CreateArray(secondMartrix);
    Console.WriteLine("Вторая матрица:");
    PrintArray(secondMartrix);

    int[,] resultMatrix = new int[m, p];
    MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
    Console.WriteLine("Произведение первой и второй матриц:");
    PrintArray(resultMatrix);
}
Runner();