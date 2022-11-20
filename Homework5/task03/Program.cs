// Задача 3: Задайте массив вещественных чисел. Найдите 
// разницу между максимальным и минимальным элементов массива.
// [3, 7.4, 22.3, 2, 78] -> 76

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

(double, double) MinAndMax(double[] numbers)
{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    return (max, min);
}

double dblMax = 0;
double dblMin = 0;
(dblMax, dblMin) = MinAndMax(numbers);

Console.WriteLine($"Максимальное значение = {dblMax}");
Console.WriteLine($"Минимальное значение = {dblMin}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {(dblMax - dblMin):F2}");

void FillArrayRandomNumbers(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}
void PrintArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}