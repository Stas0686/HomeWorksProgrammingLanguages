// Задача 4: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)
{
    if (number < 1 || number > 7)
    {
        System.Console.WriteLine("Попробуйте еще раз");
        return false;
    }
    return true;
}
int number = Prompt("Введите цифру, обозначающую день недели: ");
if (ValidateNumber(number))
{
    if (number >= 1 && number <= 5)
    {
        System.Console.WriteLine($"Цифра {number} не выходной");
    }
    else
    {
        System.Console.WriteLine($"Цифра {number} выходной");
    }
}