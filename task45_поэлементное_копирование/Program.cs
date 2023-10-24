//45. Напишите программу, которая будет создавать копию заданного одномерного
// массива с помощью поэлементного копирования.

Console.Clear(); //Очищает консоль

int[] GetMassive(int size) //Создет массив
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[] arr) //Печатает массив
{
    Console.ForegroundColor = ConsoleColor.Magenta; //Цвет квадратных скобок
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Green; //Цвет цифр в массиве
        Thread.Sleep(100);
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Magenta;
    System.Console.Write("]");
    Console.ResetColor();
}

int[] SourceM (int[] arr)
{
    int source = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        source = arr[i];
    }
    return arr;
}


int[] arrayUser = GetMassive(10); //Вывод всех методов
PrintArray(arrayUser);
System.Console.WriteLine();
PrintArray(SourceM(arrayUser));






