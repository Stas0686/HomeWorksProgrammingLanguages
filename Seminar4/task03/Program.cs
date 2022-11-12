// Задача 2: Напишите программу, которая принимает на 
// вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Fact (int number)
{
    int factor = 1;
    for (int i =2; i <=number; i++)
    {
        factor = factor*i;
    }
    return factor;
}
int number = Prompt ("Пожалуйста введите число > ");
int factor = Fact(number);
System.Console.WriteLine($"Факториал числа равен {factor}");