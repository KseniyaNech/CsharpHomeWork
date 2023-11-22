// 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();

int digitDiapas(int start, int end)
{
    if(start == end)
    {
        return end;
    }
    else
    {
        return start + digitDiapas(start + 1, end);
    }
}
int result = digitDiapas(1, 5);
System.Console.WriteLine(result);
