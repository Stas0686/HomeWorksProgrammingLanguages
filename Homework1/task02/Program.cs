// Задача 2: Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число a > ");
string numbera = Console.ReadLine();
int a = Convert.ToInt32(numbera);

Console.WriteLine("Введите число b > ");
string numberb = Console.ReadLine();
int b = Convert.ToInt32(numberb);

Console.WriteLine("Введите число c > ");
string numberc = Console.ReadLine();
int c = Convert.ToInt32(numberc);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write ("max = ");
Console.WriteLine(max);