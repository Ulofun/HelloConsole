//Напишите программу, которая принимает на вход координаты точки (X и Y), причем X и Y выдает номер четверти плоскости, в которой находится эта точка/

//var - автоматическое определение типа данных.
Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());

int ChetvetVPloskosti (int x, int y)
{
     if (x > 0 && y > 0)
     return 1;

     if (x < 0 && y > 0)
     return 2;

     if (x < 0 && y < 0)
     return 3;

     if (x > 0 && y < 0);
     return 4;

     return 0;
}
Console.WriteLine("Результат равен" +  ChetvetVPloskosti(x, y));