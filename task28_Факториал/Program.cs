/*
28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

System.Console.Write("Введите число: ");

int userNum = int.Parse(System.Console.ReadLine());

System.Console.WriteLine("Факториал этого числа: " + Factorial(userNum));

int Factorial(int num)
{
    int result = 1;
    for(int i = 2; i <= num; i++)
    {
        result *= i;
    }
    
    num = result;
}
