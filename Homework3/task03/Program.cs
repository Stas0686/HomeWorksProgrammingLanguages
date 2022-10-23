// Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

bool ValidateNumber(int N)
{
    if (N <= 0)
    {
        System.Console.WriteLine("Это число 0 или меньше");
        return false;
    }
    return true;
}

int N = Prompt("Введите число больше 0: ");
if (ValidateNumber(N))
{
    int count = 1;
    while (count <= N)
    {
        System.Console.WriteLine(count * count * count);
        count++;
    }
}