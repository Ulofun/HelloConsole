﻿//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int z = Convert.ToInt32(Console.ReadLine());
int max = x;
if (y > max)
{
    max = y;
}
if(z>max)
{
   max = z;
}
Console.WriteLine("Число " + max + " больше всех");