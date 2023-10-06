/*
3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

3 -> Среда
5 -> Пятница
*/

System.Console.WriteLine("Введите число");
int weekday = Convert.ToInt32(Console.ReadLine());

int day1 = 1;
int day2 = 2;
int day3 = 3;
int day4 = 4;
int day5 = 5;
int day6 = 6;
int day7 = 7;

if (weekday == day1) Console.WriteLine("Понедельник");
if (weekday == day2) Console.WriteLine("Вторник");
if (weekday == day3) Console.WriteLine("Среда");
if (weekday == day4) Console.WriteLine("Четверг");
if (weekday == day5) Console.WriteLine("Пятница");
if (weekday == day6) Console.WriteLine("Суббота");
if (weekday == day7) Console.WriteLine("Воскресенье");

