//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второe число: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x>y)
{
    Console.WriteLine("Первое число больше второго");
}
else
{
    Console.WriteLine("Второе число больше первого");
}