/*
Напишите программу для работы с матрицей целых чисел.
Реализуйте класс MatrixOperations, который содержит следующие статические методы:
PrintMatrix(int[,] matrix): Метод для вывода матрицы на экран. Он принимает на вход 
двумерный массив целых чисел matrix и выводит его элементы в виде таблицы.
SortRowsDescending(int[,] matrix): Метод для сортировки строк матрицы по убыванию. 
Он принимает на вход двумерный массив целых чисел matrix и сортирует каждую строку матрицы так,
чтобы элементы в каждой строке шли по убыванию.

Аргументы, передаваемые в метод/функцию:
'9, 1, 7; 1, 2, 3; 4, 5, 6'
На выходе:
Исходная матрица:
9   1   7   
1   2   3   
4   5   6   
Матрица с упорядоченными по убыванию строками:
9   7   1   
3   2   1   
6   5   4
*/

Console.Clear();
int[,] matrix = {{9, 1, 7}, {1, 2, 3}, {4, 5, 6} };

Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
    }
    

for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = matrix.GetLength(1) - 1; j > 0; j--)
            {
                for (int k = 0; k < j; k++)
                    {
                        if (matrix[i, k] < matrix[i, k + 1])
                        {
                            int temp = matrix[i, k];
                            matrix[i, k] = matrix[i, k + 1];
                            matrix[i, k + 1] = temp;
                        }
                    }
            }
            Console.WriteLine();
    }

for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
    }
        