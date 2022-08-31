

void DayOfWeek(int num)
{
    if ( num < 1 || num > 7)
    Console.WriteLine("Нет такого дня");
    else if ( num == 6 || num ==7)
    Console.WriteLine("Выходной день");
    else
    Console.WriteLine("Сегодня не выходной день, иди работай!");
}

Console.WriteLine("Введите день недели от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
DayOfWeek(num);