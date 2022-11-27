// Задача 2: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = Convert.ToInt32(Console.ReadLine());
    return temp;
}

int SumNumbers(int m, int n)
{
    if (n < m)
    {
        return 0;
    }
    return m + SumNumbers(m + 1, n);
}

int m = Prompt("Введите целое число M: ");
int n = Prompt("Введите целое число N: ");

System.Console.WriteLine(SumNumbers(m, n));
