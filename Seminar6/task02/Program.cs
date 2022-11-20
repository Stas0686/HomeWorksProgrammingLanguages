// Задача 1: Напишите программу, которая принимает на вход три числа и 
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше
// суммы двух других сторон.

int Prompt(string msg)
{
    System.Console.Write(msg);
    int lenght = Convert.ToInt32(Console.ReadLine());
    return lenght;
}

bool IsItTriangle(int x, int y, int z)
{
    return x + y > z;
}

void Execute()
{
    int num1 = Prompt("Введите сторону треугольника 1 = ");
    int num2 = Prompt("Введите сторону треугольника 2 = ");
    int num3 = Prompt("Введите сторону треугольника 3 = ");
    if (IsItTriangle(num1, num2, num3) && IsItTriangle(num2, num3, num1) && IsItTriangle(num3, num1, num2))
    {
        System.Console.WriteLine("Этот треугольник существует");
    }
    else
    {
        System.Console.WriteLine("Этот треугольник не существует");
    }
}
Execute();