﻿/*
28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

System.Console.Write("Введите число: ");
int userNum = Convert.ToInt32(System.Console.ReadLine());
int Factorial(int num)
{
    int result = 1;
    for(int i = 2; i <= num; i++)
    {
        result *= i;
    }
    return result;

}
System.Console.WriteLine("Факториал этого числа: " + Factorial(userNum));