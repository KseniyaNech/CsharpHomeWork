
//Задайте двумерный массив размером м*н, заполнений случайными цифрами

int [,] Get2DArray(int row, int col)//создаем двумерный массив с двумя переменными
{
    int[,] array = new int[row, col];//создаем переменную массива с двумя размерами
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array [i, j] = new Random().Next(0, 11);
        }
    }
    return array;
}

// void Print2DArray(int[,] arr)// создаем метод для печати (на вход принимает массив)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)//чтобы пройтись по строкам
//     {
//         for (var j = 0; j < arr.GetLength(1); j++)
//         {
//             System.Console.Write(arr[i,j]+ "\t");//вывод на экран
//         }
//         System.Console.WriteLine();
//     }
// }

 int[,] user2DArray = Get2DArray(3,4);//заполняем его методом Get2DArray отдаем строки и столбцы





void PrintMatrix(int[,] arr)
{
    System.Console.Write("[ ] \t");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        System.Console.Write($"[{j}] \t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        System.Console.Write($"[{i}] \t");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
        Console.ForegroundColor = ConsoleColor.Cyan;
        System.Console.Write(" " + arr[ i, j] + "\t");
        Console.ResetColor();
        }
        System.Console.WriteLine();
    }
    Console.ResetColor();
}
PrintMatrix(user2DArray);