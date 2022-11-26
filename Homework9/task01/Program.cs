// Задача 1: Задайте значения M и N. Напишите программу, которая выведет
// все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = Convert.ToInt32(Console.ReadLine());
    return temp;
}

void PrintEvenNumbers(int m, int n)
{
    if (n < m)
    {
        return;
    }
    if (m % 2 != 0) m = m + 1;
    Console.WriteLine(m);
    PrintEvenNumbers(m + 2, n);

}

int m = Prompt("Введите целое число M: ");
int n = Prompt("Введите целое число N: ");

PrintEvenNumbers(m, n);