/*
1. Напишите программу, которая на вход принимает два числа и проверяет, 
является ли первое число квадратом второго. 
*/

System.Console.WriteLine("Введи первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введи второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 / number2 == number2 || number2 / number1 == number1)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}