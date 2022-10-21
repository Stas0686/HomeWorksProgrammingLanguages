// 3.1. Напишите программу, которая будет принимать на вход пять чисел
// и выводить сумму и среднее арифметическое этих чисел.
// 2, 5, 6, 8, 1 -> сумма 22, среднее 4,4 

int Prompt(string text)
{
    System.Console.WriteLine(text);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}

int a = Prompt("Введите число 1: ");
int b = Prompt("Введите число 2: ");
int c = Prompt("Введите число 3: ");
int d = Prompt("Введите число 4: ");
int e = Prompt("Введите число 5: ");
int sum = a + b + c + d + e;    // если "double sum" то "5.0" не нужно (просто "5")
double average = (sum/5.0);
System.Console.WriteLine($"Сумма чисел {sum}, среднее арифметическое {average}");