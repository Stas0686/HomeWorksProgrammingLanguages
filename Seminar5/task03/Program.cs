// Задача 2: Задайте массив. Напишите программу, которая определяет, присутствует ли
// заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArray(int length)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(-9, 10);
    }
    return tempArray;
}

void PrintArray(int[] array)
{
    Console.Write($"{array[0]} ");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int Prompt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

bool IsThereNumber(int number, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        return true;
    }
    return false;
}
void Execute()
{
    int[] array = CreateArray(12);
    PrintArray(array);
    int number = Prompt("Введите число: ");
    if (IsThereNumber(number, array))
    { Console.WriteLine($"Число {number} присутствует в массиве {array}"); }
    else
    { Console.WriteLine($"Число {number} не присутствует в массиве {array}"); }
}
Execute();