/*11. Напишите программу, которая выводит случайное трёхзначное 
число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

Console.Clear();

int num = new Random().Next(100, 1000);
System.Console.WriteLine("Сегенерировано трехзначное число: " + num);

int first = num / 100;
int last = num % 10;
int result = first * 10 + last;

System.Console.Write("Удаляем вторую цифру: ");
System.Console.WriteLine(result);