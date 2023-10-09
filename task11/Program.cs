/*11. Напишите программу, которая выводит случайное трёхзначное 
число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int num = new Random().Next(100, 1000);

System.Console.WriteLine("Сегенерировано трехзначное число: " + num);

int temp = num % 10;

num /= 100;
num = num * 10 + temp;

System.Console.Write("Удаляем вторую цифру: ");
System.Console.WriteLine(num);