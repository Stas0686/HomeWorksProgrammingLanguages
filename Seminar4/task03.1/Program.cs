// Задача 2: Напишите программу, которая принимает на 
// вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
// *ЧЕРЕЗ РЕКУРСИЮ

int ReadData(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}

int number = ReadData("Введите число больше 0 > ");

long Factorial(int number)
{
    System.Console.WriteLine($"Итерация {number}");
    if (number == 1 || number == 0) return 1;
    return number * Factorial(number - 1);
}
long calculatedFactorial = Factorial(number);

System.Console.WriteLine($"Факториал числа {number} это {calculatedFactorial}");