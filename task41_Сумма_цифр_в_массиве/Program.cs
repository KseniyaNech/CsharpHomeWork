/*41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

// Console.Clear(); //Очищает консоль

// int[] GetMassive(int size) //Создет массив
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//     }
//     return array;
// }
 
// void PrintArray(int[] arr) //Печатает массив
// {
//     Console.ForegroundColor = ConsoleColor.Magenta ; //Цвет квадратных скобок
//     System.Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.ForegroundColor = ConsoleColor.Green; //Цвет цифр в массиве
//         Thread.Sleep(200);
//         System.Console.Write(arr[i]);
//         if (i < arr.Length - 1)
//             System.Console.Write(", ");
//     }
//     Console.ForegroundColor = ConsoleColor.Magenta ;
//     System.Console.Write("]");
//     Console.ResetColor();
//}

//  void QuantityPositiv(int[] arr) //Метод подсчета
// {
//     int count = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0) count++; //ведет счет количества элементов в массиве
// }
//     System.Console.WriteLine("Количество цифр больше нуля: " + count);
// }

// int[] userArray = GetMassive(7); //Вывод всех методов
// PrintArray(userArray);
// System.Console.WriteLine();
// QuantityPositiv(userArray);

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Thread.Sleep(1);
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.WriteLine("]");
    Console.ResetColor();
}

int userSize = Prompt("Enter array size: ");
int[] userArray = GetArray(userSize);
PrintArray(userArray);

int CountPositivDigits(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result ++;
    }
    return result;
}
int count = CountPositivDigits(userArray);
System.Console.WriteLine();
System.Console.WriteLine($"Positive Digits > 0 = {count}");


// решение от Романа
// System.Console.Write("Укажите количество чисел: ");
// int value = int.Parse(System.Console.ReadLine());

// int count = 0;

// for(int i = 0; i < value; i++)
// {
//     System.Console.Write("Введите число: ");
//     if(int.Parse(System.Console.ReadLine()) > 0 ) count++;
// }

// System.Console.WriteLine("Чисел со значением больше нуля было введено: " + count);