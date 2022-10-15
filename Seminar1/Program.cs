// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
// Например:

// 4 -> 16 
// -3 -> 9 
// -7 -> 49

System.Console.Write("Введите число >");        // Выводим подсказку на экран
string inputString = Console.ReadLine();            // Поллучаем введенную строку в консоли
int value = Convert.ToInt32(inputString);           // Преобразуем к целому типу

int square = value * value;                         // Вычисляем квадрат чила
System.Console.WriteLine(square);                   // Выводим результат в консоль