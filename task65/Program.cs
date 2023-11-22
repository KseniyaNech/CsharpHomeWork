// 65. Задайте значения M и N. 
// Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N.


Console.Clear();

void digitDiapas (int max, int start)// переменная макс - это число от пользователя, два числа от которого мы идем и до какого идем
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
digitDiapas(10, 5);