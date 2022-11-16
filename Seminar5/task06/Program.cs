// Создать массив. Найти среднее значение, среднее квадратичное

int[] CreateArray(int length = 10, int min = 0, int max = 10)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(min, max);
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

double Average(int[] array)
{
    double sum = 0;
    double aver = 0;
    foreach(var item in array)
    {
        sum += item;
    }
    return aver = sum / array.Length;
}

double SqAver (int[] array)
{
    double sqAver = 0;
    double sumTech = 0;
    foreach(var item in array)
    {
        sumTech += item * item;
    }
    sqAver = Math.Sqrt(sumTech / array.Length);
    return sqAver;
}

void Runner()
{
    int [] numbers = CreateArray();
    PrintArray(numbers);
    double result = Average(numbers);
    double sqAver = SqAver(numbers);
    Console.WriteLine($"Среднее значение = {result}, среднее квадратичное = {sqAver}");
}
Runner();