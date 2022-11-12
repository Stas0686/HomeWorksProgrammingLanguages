// Задача 3: Напишите программу, которая выводит массив из 8 элементов,
// заполненный случайными числами. Оформите заполнение массива и вывод
// в виде функции (пригодится в следующих задачах).  Реализовать через функции.
// (* Доп сложность, “введите количество элементов массива”, “Введите минимальный порог
// случайных значений”, “Введите максимальный порог случайных значений”)
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8  -> 8

int[] CreateArray(int Length = 8)
{
    int[] tempArray = new int[Length];
    for (int i = 0; i < Length; i++)
    {
        tempArray[i] = new Random().Next();
    }
    return tempArray;
}

void printArray(int[] intArray)
{
    System.Console.Write($"{intArray[0]}");
    for (int i = 1; i < intArray.Length; i++)
    {
        System.Console.Write($", {intArray[i]}");
    }
}

System.Console.Write("Массив из 8 элементов, заполненный случайными числами: ");
printArray(intArray: CreateArray());