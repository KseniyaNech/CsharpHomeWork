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


// решение от Романа
System.Console.Write("Укажите количество чисел: ");
int value = Convert.ToInt32(System.Console.ReadLine());

int count = 0;

for(int i = 0; i < value; i++)
{
    System.Console.Write("Введите число: ");
    if(Convert.ToInt32(System.Console.ReadLine()) > 0 ) count++;
}

System.Console.WriteLine("Чисел со значением больше нуля было введено: " + count);