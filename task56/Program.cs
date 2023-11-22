// Напишите программу для работы с матрицей целых чисел.
// Реализуйте класс Answer, который содержит следующие статические методы:
// SumOfRow(int[,] matrix, int row): Метод для вычисления суммы элементов в заданной 
// строке row матрицы matrix. Метод принимает двумерный массив целых чисел matrix и номер 
// строки row, а возвращает целое число - сумму элементов в данной строке.
// MinimumSumRow(int[,] matrix): Метод для определения строки с наименьшей суммой элементов. 
// Метод принимает двумерный массив целых чисел matrix и возвращает массив из двух элементов: 
// номер строки с наименьшей суммой (нумерация начинается с 0) и саму сумму.
// Аргументы, передаваемые в метод/функцию:

// '9, 1, 7; 1, 2, 3; 4, 5, 6'
// На выходе:
// Исходная матрица:
// 9   1   7   
// 1   2   3   
// 4   5   6   
// Сумма наименьшей строки (строка 2): 6
// Сумма элементов в строке 2: 6

   
int[,] matrix = {{2,3,8}, {5,1,1}, {9,1,4}};

Console.WriteLine();

int index = 0;
int minsum = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;

        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
                sumRow +=matrix[i,j];
            }
        Console.WriteLine($" Сумма элементов {sumRow}");
        
        if(i == 0) minsum = sumRow;
        else if(sumRow < minsum)
            {
                minsum = sumRow;
                index = i;
            }
    }

    string line = string.Empty;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        line += matrix[index, j] + " ";
    }
    System.Console.WriteLine();
    Console.WriteLine($"Строка с минимальной суммой элементов равна {index + 1}. ");
System.Console.WriteLine();

           
           
           
           
           
           
        
           
          