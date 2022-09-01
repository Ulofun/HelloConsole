// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А : ");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число B , т.е степень : ");
double B = Convert.ToDouble(Console.ReadLine());
double result = FuncStep(A,B);
Console.WriteLine("Результат равен = " + result);

double FuncStep(double A, double B)
{
  double Y = (Math.Pow(A, B));
  result = Y;
  return result;
  
  //Math.Pow (A - возводимое, В - степень)
   
}





//Math.Pow(A,B) - возвести число А в степерь В