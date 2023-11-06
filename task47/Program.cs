// Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.


Console.Clear();

double[,] Get2DArray(int row, int col)
{
    double[,] array = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(-5, 5);
        }
    }
    return array;
}

void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.WriteLine(array[i, j] + "\t");
        }
         System.Console.WriteLine();
    }
}

double[,] user2DArray = Get2DArray(3, 4);
Print2DArray(user2DArray);


// Console.Clear();


// double[,] Get2DArray(int row, int col)//создаем двумерный массив с двумя переменными
// {
//     double[,] array = new double[row, col];//создаем переменную массива с двумя размерами
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             array[i, j] = new Random().Next(-5, 5);
//         }
//     }
//     return array;
// }

// void Print2DArray(double[,] arr)// создаем метод для печати (на вход принимает массив)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)//чтобы пройтись по строкам
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             System.Console.Write(arr[i, j] + "\t");//вывод на экран
//         }
//         System.Console.WriteLine();
//     }
// }

// double[,] user2DArray = Get2DArray(3, 4);//заполняем его методом Get2DArray отдаем строки и столбцы
// Print2DArray(user2DArray);