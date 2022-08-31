// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125




void Cube(int number)
{
  int N = 1;
  while (N <= number)
  {
  int result = Convert.ToInt32(Math.Pow(N, 3));
  N++;
  Console.WriteLine(result);
  }

}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Cube(number);



