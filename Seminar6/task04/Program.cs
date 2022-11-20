// Задача 4: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.

int[] CreateArray(int len = 10, int startPointBorder = 0, int endPointBorder = 999)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(startPointBorder, endPointBorder);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    string msg = String.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        msg += $"{arr[i]}, ";
    }
    msg += $"{arr[arr.Length - 1]}";
    System.Console.WriteLine(msg);
}

int[] CopyArr(int[] arr)
{
    int[] result = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[i];
    }
    return result;
}

void Runner()
{
    int[] arr1 = CreateArray(len: 5);
    PrintArray(arr1);

    int[] arr2 = arr1;
    PrintArray(arr2);

    arr1[0] = 422;
    PrintArray(arr1);
    PrintArray(arr2);

    int[] arr3 = CopyArr(arr1);
    arr1[1] = 1000;

    PrintArray(arr1);
    PrintArray(arr3);
}

Runner();