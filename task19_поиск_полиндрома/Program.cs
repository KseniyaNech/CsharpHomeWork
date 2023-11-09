﻿/*
Внутри класса Answer напишите метод IsPalindrome, 
который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.
Метод должен проверить является ли число пятизначным, 
в противном случае - вывести Число не пятизначное и False в следующей строке.
Для остальных чисел вернуть True или False.
14212 -> False
12821 -> True
234322 -> Число не пятизначное
*/

// System.Console.WriteLine("Enter number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int n1 = n / 10000;
// System.Console.WriteLine(n1);
// int n2 = n / 1000 % 10;
// System.Console.WriteLine(n2);
// int n4 = n / 10 % 10; 
// System.Console.WriteLine(n4);
// int n5 = n  % 10;
// System.Console.WriteLine(n5);
// if (n >= 10000 & n <= 99999)
// {
//     if (n1 == n5 & n2 == n4)
//     {
//         System.Console.Write("Yes");
//     }
//     else
//     System.Console.Write("No");
// }
// else
// {
//     System.Console.WriteLine("Here's not five digit!");
// }

/*
123 : 10 = 12 целых (3) в остатке
12 : 10 = 1 целых (2) в остатке
7 : 2 = 3 целых (1) в остатке
*/

/*
static bool IsPalindromeSecond(int number)
  {
    if (number < 10000 || number > 99999)
    {
      System.Console.WriteLine("Число не пятизначное");
      return false;
    }
    int reversNumber = 0;
    for ( int originNumber=number; originNumber >0; originNumber/=10)
    {
      int lastDigin = number  % 10;
      reversNumber = reversNumber * 10 + lastDigin;
      number/=10;
    }
      return reversNumber==number;
  }
}
*/


System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int revN = 0;
for (int i = N; i > 0; i /= 10)
{
    revN = revN * 10 + i % 10;
}
if (N == revN)
    System.Console.WriteLine("Да");
else System.Console.WriteLine("Нет");
