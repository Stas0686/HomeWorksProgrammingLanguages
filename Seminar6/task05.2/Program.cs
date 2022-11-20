// Написать последовательность чисел Фибоначи через рекурсию.

int PromptInt(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

void Seq (int n)
{
    if (n <=0)
    {
        return;
    }
    Seq(n-1);
    System.Console.Write($"{n} ");
}
Seq(5);