// Задача 3: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreateArray(int length)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(-100, 100);
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

int CountElements (int[] array, int lowLim, int upLim)
{
    int count = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if((array[i]>= lowLim)&&(array[i]<=upLim))
        count++;
        
    }
    return count;
}
void Execute()
{
    int [] randomArray = CreateArray(123);
    int lowLim = 10;
    int upLim = 99;
    PrintArray(randomArray);
    int countMatch = CountElements(randomArray, lowLim, upLim);
    System.Console.WriteLine();
    Console.WriteLine($"Количество элементов массива, лежащих в отрезке [10; 99] равно {countMatch} ");
}
Execute();