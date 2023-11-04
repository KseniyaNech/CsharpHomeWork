// 51. Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали 
// с индексами (0,0); (1;1) и т.д.

Console.Clear();

int[,] Get2DArray(int row, int col)//создаем двумерный массив с двумя переменными
{
    int[,] array = new int[row, col];//создаем переменную массива с двумя размерами
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
    }
    return array;
}

void Print2DArray(int[,] arr)// создаем метод для печати (на вход принимает массив)
{
    for (int i = 0; i < arr.GetLength(0); i++)//чтобы пройтись по строкам
    {
        for (var j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");//вывод на экран
        }
        System.Console.WriteLine();
    }
}

int SummaDiag(int[,] arr)
{
    int result = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        result += arr[i, i];
    }
    return result;
}

int[,] user2DArray = Get2DArray(3, 3);//заполняем его методом Get2DArray отдаем строки и столбцы
Print2DArray(user2DArray);
int summ = SummaDiag(user2DArray);
System.Console.WriteLine();
System.Console.WriteLine(summ);
