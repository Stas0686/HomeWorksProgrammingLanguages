// Задача 2: Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
int firstDigit = number / 100;
int thirdDigit = number % 10;
int result = firstDigit * 10 + thirdDigit;
System.Console.WriteLine($"Из случайного числа {number} получается {result}");
