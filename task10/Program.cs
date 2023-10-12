/*
Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int num = new Random().Next(100, 1000);

System.Console.WriteLine("Сегенерировано трехзначное число: " + num);

int temp = num % 10;

num /= 100;
num = num * 10 + temp;

System.Console.Write("Удаляем вторую цифру: ");
System.Console.WriteLine(num);