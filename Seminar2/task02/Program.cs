﻿// 2. Напишите программу, которая выводит случайное число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int number = new Random().Next(10,100);

int firstDigit = number / 10;
int lastDigit = number % 10;
if (firstDigit > lastDigit)
System.Console.WriteLine($"В числе {number} наибольшая цифра {firstDigit}");
else
{
    System.Console.WriteLine($"В числе {number} наибольшая цифра {lastDigit}");
}
