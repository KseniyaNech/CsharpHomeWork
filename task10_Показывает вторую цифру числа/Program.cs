﻿/*
Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();

int num = new Random().Next(100, 1000);
System.Console.WriteLine("Сегенерировано трехзначное число: " + num);

int temp = (num % 100) /10;// например: 245, 245%100=45/10=4

System.Console.Write("Показываем вторую цифру числа: ");
System.Console.WriteLine(temp);