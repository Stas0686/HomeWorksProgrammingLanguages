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