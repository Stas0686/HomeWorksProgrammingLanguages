// 4. Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}

bool DivBy (int number)
{
    return (number % 7 == 0) && (number % 23 == 0);
}

int A = Prompt ("Введите число: ");
if (DivBy(A))
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}