// 3. Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int Promt(string text)
{
    System.Console.WriteLine(text);
    int number = Convert.ToInt32(System.Console.ReadLine());
    return number;
}

int DivBy(int A, int B)  // вычисляем отстаток от деления В на А
{
    return (B % A);
}

int A = Promt("Введите первое число: ");
int B = Promt("Введите второе число: ");

if (DivBy(A, B) == 0)            // проверка на кратность
{
    System.Console.WriteLine($"Число {B} кратно числу {A}");
}
else
{
    System.Console.WriteLine($"Число не кратно, остаток {DivBy(A, B)}");
}