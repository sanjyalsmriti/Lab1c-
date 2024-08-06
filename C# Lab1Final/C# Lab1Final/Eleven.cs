//using System;

//class MatrixMultiplication
//{
//    static void Main()
//    {
//        Console.WriteLine("Starting matrix multiplication program...");

//        // Input matrix dimensions and values
//        int[,] matrixA = ReadMatrix("A");
//        int[,] matrixB = ReadMatrix("B");

//        // Print input matrices
//        Console.WriteLine("Matrix A:");
//        PrintMatrix(matrixA);
//        Console.WriteLine("Matrix B:");
//        PrintMatrix(matrixB);

//        try
//        {
//            // Multiply the matrices
//            int[,] result = MultiplyMatrices(matrixA, matrixB);

//            // Print the result
//            Console.WriteLine("Resultant Matrix:");
//            PrintMatrix(result);
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"An error occurred: {ex.Message}");
//        }

//        // Keep the console open
//        Console.WriteLine("Press Enter to exit...");
//        Console.ReadLine();
//    }

//    static int[,] ReadMatrix(string name)
//    {
//        Console.WriteLine($"Enter dimensions for matrix {name}:");
//        Console.Write("Rows: ");
//        int rows = int.Parse(Console.ReadLine());
//        Console.Write("Columns: ");
//        int columns = int.Parse(Console.ReadLine());

//        int[,] matrix = new int[rows, columns];

//        Console.WriteLine($"Enter values for matrix {name}:");
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < columns; j++)
//            {
//                Console.Write($"Element [{i},{j}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        return matrix;
//    }

//    static int[,] MultiplyMatrices(int[,] a, int[,] b)
//    {
//        int rowsA = a.GetLength(0);
//        int colsA = a.GetLength(1);
//        int rowsB = b.GetLength(0);
//        int colsB = b.GetLength(1);

//        if (colsA != rowsB)
//        {
//            throw new InvalidOperationException("Matrix dimensions do not match for multiplication.");
//        }

//        int[,] result = new int[rowsA, colsB];

//        for (int i = 0; i < rowsA; i++)
//        {
//            for (int j = 0; j < colsB; j++)
//            {
//                result[i, j] = 0;
//                for (int k = 0; k < colsA; k++)
//                {
//                    result[i, j] += a[i, k] * b[k, j];
//                }
//            }
//        }

//        return result;
//    }

    //static void PrintMatrix(int[,] matrix)
    //{
    //    int rows = matrix.GetLength(0);
    //    int cols = matrix.GetLength(1);

    //    for (int i = 0; i < rows; i++)
    //    {
    //        for (int j = 0; j < cols; j++)
    //        {
    //            Console.Write(matrix[i, j] + "\t");
    //        }
    //        Console.WriteLine();
    //    }
  //  }
//}

