﻿/* Напишите программу, которая принимает на вход число (N) и 
выдает таблицу квадратов чисел от 1 до N

5-> 1, 4, 9, 16, 25.
2-> 1, 4
*/

System.Console.Write("Введи число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= userNumber; i++)
{
   System.Console.WriteLine($"{i} * {i} = {Math.Pow(i,2)}");
}
