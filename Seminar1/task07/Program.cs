// **. Напишите программу, которая на вход принимает значение, 
// а  на выходе показывает обратное значение.
// Обратное число X = 1/X
// 1 -> 1 
// 2 -> 0.5
// 0.25 -> 4


Console.WriteLine("Введите число > ");
string inputString = Console.ReadLine();
double Number = Convert.ToDouble(inputString);
double ReversNumber = 1/Number;

Console.WriteLine($"{ReversNumber:F2}");          // Округление до второго знака после запятой