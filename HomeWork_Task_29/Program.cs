﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]




void RandomArray(int[] a)
{
  Random randomNumber = new Random();
  for(int i = 0; i < a.Length; i++)
  {
    a[i] = randomNumber.Next(0, 100);
  
    Console.Write(a[i] + " ");

  }
}

int[] array = new int[8];
RandomArray(array);