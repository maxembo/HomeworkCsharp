using System;

namespace  task1
{
    internal class Program
    {
   
        private static int[,] RectangleMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows,cols];

            if (rows != cols)
                return matrix;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    bool isDiagonal = (i == j);
                    bool isAboveDiagonal = (i < j);
                    bool isBelowDiagonal = (i > j);
                    
                    if (isDiagonal)
                        matrix[i, j] = 1;
                    else if(isAboveDiagonal)
                        matrix[i, j] = i + j;
                    else if (isBelowDiagonal)
                        matrix[i, j] = i - j;
                }
            }
            return matrix;
        }
        
        private static void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine("\nКвадратная матрица:\n");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                } 
                Console.WriteLine();
            }
        }
        private static void Main(String[] args)
        { 
            Console.Write("Введите число строк: ");
            int rows = int.Parse(Console.ReadLine());
            
            Console.Write("\nВведите число столбцов: ");
            int cols = int.Parse(Console.ReadLine());
            
            PrintMatrix(RectangleMatrix(rows,cols));
        }
    }
}
