// 2. Напишите программу, которая будет выдавать 
// название дня недели по заданному номеру.
// 	3 -> Среда 
//  5 -> Пятница

System.Console.WriteLine("Введите число, соответствующее дню недели");
string value = Console.ReadLine();
int day = Convert.ToInt32(value);

if (day == 1)
{
    System.Console.WriteLine("Понедельник");
}
if (day == 2)
{
    System.Console.WriteLine("Вторник");
}if (day == 3)
{
    System.Console.WriteLine("Среда");
}if (day == 4)
{
    System.Console.WriteLine("Четверг");
}if (day == 5)
{
    System.Console.WriteLine("Пятница");
}if (day == 6)
{
    System.Console.WriteLine("Суббота");
}
if (day == 7)
{
    System.Console.WriteLine("Восресенье");
}
if (day < 1 || day > 7)
{
    System.Console.WriteLine("Подумай еще раз!");
}