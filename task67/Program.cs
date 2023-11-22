// 67. Напишите программу, которая будет 
// принимать на вход число и возвращать сумму его цифр.


Console.Clear();
 
int Summ (int num)
{
    if(num == 0)
    {
        return 0;
    }
    else
    {
        return num % 10 + Summ(num/10);// 123 остаток от деления 3+(12)
    }
}
 int result = Summ(5555);
 System.Console.WriteLine(result);