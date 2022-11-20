// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[size];

void EnteringElements(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        System.Console.Write($"Введите число с индексом {i}: ");
        myArray[i] = int.Parse(System.Console.ReadLine());
    }
}

void PrintArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + " ");
    }
    Console.WriteLine();
}

int PositiveNumbers(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            count++;
        }
    }
    return count;
}

EnteringElements(myArray);
PrintArray(myArray);
Console.WriteLine($"Всего {PositiveNumbers(myArray)} чисел больше нуля");