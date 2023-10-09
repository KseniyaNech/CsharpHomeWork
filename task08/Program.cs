/*Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), 
а на выходе выводит все чётные числа от 1 до number (включительно), 
разделеные знаком табуляции.
*/

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i < number+1; i=i+2) //Всегда три показателя: точка входа; условие выхода из цикла; шаг
{
    System.Console.Write(i + "\t");
}