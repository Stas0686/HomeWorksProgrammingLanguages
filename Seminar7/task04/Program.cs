// Задача 4: Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, 
// выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.

int PromptInt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

int[,] CreateArray(int m, int n)
{
    int[,] table = new int[m, n];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(-9, 9);
        }
    }
    return table;
}


void FindElement(int[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                System.Console.WriteLine($"Элемент {number} находится на позиции [{i},{j}] ");
                return;
            }
        }
    }
    System.Console.WriteLine("Этого числа нет в массиве");
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

void Execute()
{
    int rows = PromptInt("Введите размерность M (строки): ");
    int columns = PromptInt("Введите размерность N (столбцы): ");
    int[,] array = CreateArray(rows, columns);
    PrintArray(array);
    System.Console.WriteLine();
    int num = PromptInt("Введите число, которое ищем в массиве ");
    FindElement(array, num);
}

Execute();