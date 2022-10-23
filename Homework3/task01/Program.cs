// Задача 1: Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)
{
    if (number < 10000 || number >= 100000)
    {
        System.Console.WriteLine("Это число не пятизначное");
        return false;
    }
    return true;
}

int number = Prompt("Введите пятизначное число: ");
if (ValidateNumber(number))
{
    int FirstNumber = number / 10000;
    int SecondNumber = (number % 10000) / 1000;
    int FourthNumber = (number % 100) / 10;
    int FifthNumber = number % 10;
    
    if ((FirstNumber - FifthNumber) * (SecondNumber - FourthNumber) == 0)
    {
        System.Console.WriteLine("Это число палиндром");
    }
    else
    {
        System.Console.WriteLine("Это число не является палиндромом");
    }
}