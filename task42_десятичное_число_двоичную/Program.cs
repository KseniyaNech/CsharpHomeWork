﻿/*42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

void InBinaryCode(int numb)//это метод который должен вернуть воидовскую переменную
{
    string result = "";
    int binary = 0;
    for (int i = numb; i > 0; i/=2)
    {
        binary = i % 2;
        result = binary + result;
    }
    System.Console.Write(result);
}
InBinaryCode(6);



// Решение Романа
/*
int DecToBinary(int num)
{
    int result = 0;
    int temp = 1;
    while(num > 0)
    {
        result += num % 2 * temp;
        num /= 2;
        temp *= 10;
    }
    return result;
}
*/