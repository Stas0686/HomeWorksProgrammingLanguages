// Задача 1: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7, min = 5
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("Введите число a > ");
string numbera = Console.ReadLine();
double a = Convert.ToDouble(numbera);

Console.WriteLine("Введите число b > ");
string numberb = Console.ReadLine();
double b = Convert.ToDouble(numberb);

if (a < b)
{
    System.Console.WriteLine("a меньшее, b большее");
}
if (a > b)
{
    System.Console.WriteLine("a большее, b меньшее");
}
if (a == b)
{
    System.Console.WriteLine("числа равны");
}