// 49. Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

Console.Clear();


int[,] Get2DArray(int row, int col)//создаем двумерный массив с двумя переменными
{
    int[,] array = new int[row, col];//создаем переменную массива с двумя размерами
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(0, 10);
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

int[,] Sqare2DEven(int[,] arr1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            if (j % 2 == 0 & i % 2 == 0) arr1[i,j]*= arr1[i,j];
        }
    }
    return arr1;
}

int[,] user2DArray = Get2DArray(3, 4);//заполняем его методом Get2DArray отдаем строки и столбцы
Print2DArray(user2DArray);
int[,] user3DArray = Sqare2DEven(user2DArray);
System.Console.WriteLine();
Print2DArray(user3DArray);