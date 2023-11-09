/*40. Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
*/

// bool Triangle(int a, int b, int c)
// {
//     if(a + b > c & b + c > a & a + c > b) 
//     {
//         return true;
//     }
//     return false;
// }

// System.Console.WriteLine(Triangle(1, 2, 3));

string Triangle1(int a, int b, int c)
{
    string result = $"Нет, треугольник со сторонами {a}, {b} и {c} не может существовать";
    if(a + b > c & b + c > a & a + c > b) 
    {
        result = $"Да, треугольник со сторонами {a}, {b} и {c} существует";
    }
    return result;
}

System.Console.WriteLine(Triangle1(4, 4, 4));

// Решение от Романа.
// bool IsTriangle(int num1, int num2, int num3)
// {
//     if(num1 <= 0 || num2 <= 0 || num3 <= 0)
//         return false;

//     return num1 + num2 > num3 && num2 + num3 > num1 && num3 + num1 > num2;
// }