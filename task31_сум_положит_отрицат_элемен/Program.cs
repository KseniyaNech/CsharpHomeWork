// 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка 
// [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел 
// равна 29, сумма отрицательных равна -20


Console.Clear();

int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Thread.Sleep(200);
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Cyan;
    System.Console.Write("]");
    Console.ResetColor();
}

void SumArray(int[] arr)
{
    int summPos = 0;
    int summNeg = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) summPos = summPos + arr[i];
        else summNeg = summNeg + arr[i];
    }
    System.Console.WriteLine("Сумма положительных чисел в массиве равна:" + summPos);
    System.Console.Write("Сумма отрицательных чисел в массиве равна:" + summNeg);
}

int[] userArray = GetRnd(12);
PrintArray(userArray);
System.Console.WriteLine();
SumArray(userArray);



/*
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве 
[3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20.


int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(min, max + 1);
    }
    return arr;
}

void Output(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int SumPositiv(int[] abrakadabra)
{
    int sum = 0;
for (int i = 0; i < abrakadabra.Length; i++)
{
    if (abrakadabra[i]>0)
    {
        sum = abrakadabra[i] + sum;
    }
}
    return sum;
}

int SumNegativ(int[] ahalaimahalai)
{
    int sum = 0;
for (int i = 0; i < ahalaimahalai.Length; i++)
{
    if (ahalaimahalai[i]<0)
    {
        sum = ahalaimahalai[i] + sum;
    }
}
    return sum;
}

int[] arr = CreateArray(12, -9, 9);

Output(arr);

int sump = SumPositiv(arr);
int sumn = SumNegativ(arr);
System.Console.WriteLine();
Console.WriteLine($"Сумма положительных равна: {sump}, Сумма отрицательных равна: {sumn}");
*/