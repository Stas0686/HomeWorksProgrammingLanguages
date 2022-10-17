// *. Напишите программу вычисления модуля числа.
// 	2 -> 2
// 	-3 -> 3
// 	-7 -> 7

Console.Write("Введите число > ");
int number = int.Parse(Console.ReadLine());
int mod = number;
if (number < 0)
{
    mod = -number;
}

Console.WriteLine($"{mod} это модуль числа {number}");