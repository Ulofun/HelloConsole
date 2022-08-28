//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string STnumber = Convert.ToString(number);
if (STnumber.Length > 2)
{
    Console.WriteLine("Третья цифра числа " + number + " равна " + STnumber[2] );
}
else
{
    Console.WriteLine ("Третьей цифры заданного числа нет, попробуйте другое число...");
}