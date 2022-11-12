// Задача 1: Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B. Реализовать через функции.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

int Power(int number, int exp)
{
    int result = 1;
    for (int i = 0; i < exp; i++)
    {
        result *= number;
    }
    return result;
}

int intA = Prompt("Введите целое число A: ");
int intB = Prompt("Введите целое число B: ");

System.Console.WriteLine(Power(intA, intB));
