// Задача 4: Напишите программу, которая на вход принимает два 
// числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Exp(int a, int b)
{
    if (b == 0) return 1;
    else if (b % 2 == 0) return Exp(a * a, b / 2);
    else return Exp(a, b - 1) * a;

}
int a = 3;
int b = 5;
Console.WriteLine(Exp(a, b));
