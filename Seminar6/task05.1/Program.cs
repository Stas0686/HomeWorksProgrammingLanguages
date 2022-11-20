// Задача 3: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// ТЕПЕРЬ С РЕКУРСИЕЙ

int PromptInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

int Fib(int n)
{
    if (n == 1 || n == 2)
    {
        System.Console.Write($"{1} ");
        return 1;
    }
    else
    {
        int f = Fib(n - 1) + Fib(n - 2);
        System.Console.Write($"{f} ");
        return f;
    }
}

void Execute()
{
    int n = PromptInt("Введите число: ");
    int fibSeq = Fib(n);
}
Execute();