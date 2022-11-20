// Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int PromptInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

void PrintArray(int[] array)
{
    Console.Write($"{array[0]} ");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] GetBinary(int decNumber)
{
    int[] binaryNum = new int[10];
    int i = binaryNum.Length - 1;
    while (decNumber > 0)
    {
        binaryNum[i] = decNumber % 2;
        decNumber /= 2;
        i--;
    }
    return binaryNum;
}

int decNumber = PromptInt("Введите десятичное число: ");
PrintArray(GetBinary(decNumber));