// Задача 1: Напишите программу, которая принимает на вход 
// ЛЮБОЕ число и проверяет, является ли оно палиндромом.
// Решение подсмотрел тут, но пришлось адаптировать : https://www.youtube.com/watch?v=rD1l1i7_fwc

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());

    return number;
}

bool ValidateNumber(int number)
{
    if (number < 0 || number % 10 == 0)                     // отсекаем отрицательные числа или кратные 10
    {
        System.Console.WriteLine("Это число не палиндром");
        return false;
    }
    return true;
}

int number = Prompt("Введите число: ");
if (ValidateNumber(number))

{
    int rev = 0;                                            // вводим переменную, которая будет разворачивать вторую половину числа
    while (number > rev)
    {
        rev = rev * 10;
        rev = rev + number % 10;
        number = number / 10;
    }

    if (number == rev || number == rev / 10)
    {
        System.Console.WriteLine("Это число палиндром");
    }
    else
    {
        System.Console.WriteLine("Это число не является палиндромом");
    }
}