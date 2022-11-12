// Задача 2: Напишите программу, которая принимает на вход
// число и выдаёт сумму цифр в числе. Реализовать через функции.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    System.Console.Write(message);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

bool ValidateNumber(int number)
{
    if (number < 0) return true;
    return false;
}

int SumOfDigits(int n)
{
    System.Console.Write($"Сумма цифр в числе {n} равна ");
    if (ValidateNumber(n)) n *= -1;
    int result = 0;
    while (n > 0)
    {
        result += n % 10;
        n /= 10;
    }
    return result;

}

int n = Prompt("Введите целое число: ");
int result = SumOfDigits(n);
System.Console.WriteLine(result);