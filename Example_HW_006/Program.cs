// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int X = Convert.ToInt32(Console.ReadLine());
int result = X % 10;
Console.WriteLine("Результат: " + result);