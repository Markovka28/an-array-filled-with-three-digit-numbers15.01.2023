﻿/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

int[] array = Enumerable.Range(100, 1000).ToArray();
int A = 0;
for (int i = 0; i < array.Length; i++)
{
   if (array [i] % 2 == 0)
   {
      A++;
    }
}
Console.WriteLine($"Количество чётных чисел в массиве: {A}");