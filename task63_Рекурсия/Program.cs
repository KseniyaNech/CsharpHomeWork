// 63. Задайте значение N. 
// Напишите программу, которая выведет все натуральные 
// числа в промежутке от 1 до N.

Console.Clear();

void digitDiapas (int max, int start = 1)// переменная макс - это число от пользователя, два числа от которого мы идем и до какого идем
{
    if(start > max)//условие выхода из функции
    {
        return;
    }
    else 
    {
        System.Console.Write(start + " ");
        digitDiapas(max, start + 1);
    }
}
digitDiapas(5);