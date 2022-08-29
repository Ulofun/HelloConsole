// Напишите программу, которая на вход принимает трехзначное число и показывает ВТОРУЮ цифру этого числа
//Пример решения с использованием функции!

int SecondNum(int num)
{
    int x = num / 10;
    x = x % 10;
    return x;
}



Console.WriteLine("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());
int x = SecondNum(num);
Console.WriteLine("Результат равен " + x);