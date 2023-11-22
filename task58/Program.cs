// Реализуйте класс MatrixOperations, который содержит следующие статические методы:
// MultiplyIfPossible(int[,] matrixA, int[,] matrixB): 
// Метод для проверки, возможно ли умножения двух матриц matrixA и matrixB. 
// Если число столбцов в матрице matrixA не равно числу строк в матрице matrixB, 
// то выводится сообщение "It is impossible to multiply." В противном случае, 
// вызывается метод MatrixMultiplication для умножения матриц, и результат выводится с помощью метода 
// PrintMatrix.
// MatrixMultiplication(int[,] matrixA, int[,] matrixB): 
// Метод для умножения двух матриц matrixA и matrixB. Метод возвращает новую матрицу, 
// которая представляет собой результат умножения матрицы matrixA на матрицу matrixB.
// PrintMatrix(int[,] matrix): Метод для вывода матрицы на консоль.
// Если аргументы не переданы, программа использует матрицы по умолчанию. 
// Если аргументы переданы, программа парсит их в двумерные массивы целых чисел и 
// выполняет умножение матриц.

// Аргументы, передаваемые в метод/функцию:
// '1,2;3,4'
// На выходе:
// Исходная матрица:
// 1   2   
// 3   4   
// Matrix B:
// 5   6   
// 7   8   
// Multiplication result:
// 19  22  
// 43  50

Console.Clear();
int[,] matrixA = {{1, 2}, {3, 4}};

for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
            {
                Console.Write(matrixA[i, j] + "\t");
            }
            Console.WriteLine();
    }

Console.WriteLine();
int[,] matrixB = {{5, 6,}, {7, 8,}, {10, 11}};

for (int i = 0; i < matrixB.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                Console.Write(matrixB[i, j] + "\t");
            }
            Console.WriteLine();
    }

void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)

      { 
      if(matrixA.GetLength(1) != matrixB.GetLength(0)) Console.WriteLine("Матрицы умножить нельзя. ");
      else PrintMatrix(MatrixMultiplication(matrixA, matrixB));
    }
    
MultiplyIfPossible(matrixA, matrixB);

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {  
        int rows1 = matrixA.GetLength(0);
        int cols1 = matrixA.GetLength(1);
        int cols2 = matrixB.GetLength(1);

        int[,] result = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                for (int k = 0; k < cols1; k++)
                {
                    result[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return result;
    }

void PrintMatrix(int[,] matrix)
    {  
      for(int i = 0; i < matrix.GetLength(0); i++)
      {
        for(int j = 0; j < matrix.GetLength(1); j++ )
        {
          Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
      }
    }

