// Задача 5: Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int start = -number;
while(start <= number)
{
	Console.WriteLine(start);
	start++;
}