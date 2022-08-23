Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int y = Convert.ToInt32(Console.ReadLine());
if (x*x == y)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}