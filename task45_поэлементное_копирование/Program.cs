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


int[] CopyArray(int[] arr)
{
    int[] newArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[i];
    }
    return newArray;
}


int[] arrayUser = GetMassive(10); //Вывод всех методов
PrintArray(arrayUser);
System.Console.WriteLine();
int[] userCopy = CopyArray(arrayUser);
PrintArray(CopyArray(userCopy));


// Console.Clear();

// int[] GetRandArray(int size, int start, int end)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(start, end + 1);
//     }
//     return array;
// }

// void PrintArray(int[] arr)
// {
//     System.Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i]);
//         if (i < arr.Length - 1)
//             System.Console.Write(", ");
//     }
//     System.Console.Write("]");
//     System.Console.Write(" ");
// }

// System.Console.Write("Ввести размер массива: ");
// int userSize = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Ввести диапазон массива от: ");
// int userStart = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Ввести диапазон массива до: ");
// int userEnd = Convert.ToInt32(Console.ReadLine());
// int[] userArray = GetRandArray(userSize, userStart, userEnd);
// PrintArray(userArray);

// Console.ForegroundColor = ConsoleColor.Green;
// System.Console.Write("-> ");

// int[] CopyArray(int[] array)
// {
//     Console.ForegroundColor = ConsoleColor.Blue;
//     int[] newArray = new int[array.Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         newArray[i] = array[i];
//     }
//     return newArray;
// }
// PrintArray(CopyArray(userArray));




