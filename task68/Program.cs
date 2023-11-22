// 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// Функция Аккермана
// A(m, n) = n + 1, если m = 0
// A(m, n) = A(m — 1, 1), если m ≠ 0 и n = 0
// A(m, n) = A(m — 1, A(m, n — 1)), если m ≠ 0 и n ≠ 0

Console.Clear();

int Akkerman(int first, int second)
{
    if(first == 0)
    {
        return second + 1;
    }
    else if(second == 0)
    {
        return Akkerman(first - 1, 1);
    }
    else
    {
        return Akkerman(first - 1, Akkerman(first, second - 1));
    }
}

int result = Akkerman(3, 2);
System.Console.WriteLine(result);