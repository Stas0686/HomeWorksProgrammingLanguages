// Задача 1: Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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
    System.Console.Write($"{array[0]}, ");
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
}

int[] ChangeElement(int[] tempArray)
{
    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = -tempArray[i];
    }
    return tempArray;
}

void Execute()
{
    int[] array = CreateArray(12);
    System.Console.WriteLine($"Массив {array}");
    PrintArray(array);
    System.Console.WriteLine();
    PrintArray(ChangeElement(array));
}
Execute();