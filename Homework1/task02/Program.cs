// Задача 2: Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

//                 1 ВАРИАНТ

// Console.WriteLine("Введите число a > ");
// string numbera = Console.ReadLine();
// int a = Convert.ToInt32(numbera);

// Console.WriteLine("Введите число b > ");
// string numberb = Console.ReadLine();
// int b = Convert.ToInt32(numberb);

// Console.WriteLine("Введите число c > ");
// string numberc = Console.ReadLine();
// int c = Convert.ToInt32(numberc);

// int max = a;

// if (b > max) max = b;
// if (c > max) max = c;

// Console.WriteLine($"Число {max} является максимальным");

//                 2 ВАРИАНТ
int Promt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int a = Promt("Введите первое число > ");
int b = Promt("Введите второе число > ");
int c = Promt("Введите третье число > ");

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine($"Число {max} является максимальным");