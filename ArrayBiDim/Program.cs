using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables 
            float[,] matrix;
            int rows, cols;
            float sumOfMeans = 0;

            // Ask user for dimensions
            Console.Write("Number of rows: ");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Number of cols: ");
            cols = int.Parse(Console.ReadLine());

            // Create array with sizes give by user
            matrix = new float[rows, cols];

            // Ask user for numbers to each position of the array
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    string aux;
                    Console.Write($"Value in ({r},{c}): ");
                    aux = Console.ReadLine();
                    matrix[r,c] = float.Parse(aux);
                }
            }

            // Calculate the mean of the values in each line
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                float aux = 0;
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    aux += matrix[r,c];
                }
                aux /= matrix.GetLength(1);
                Console.WriteLine($"Mean of the current row {r} : {aux}");
                sumOfMeans += aux;
            }

            // Calculate the sum of the means and show it
            Console.WriteLine($"Sum of the means is {sumOfMeans}");

        }
    }
}
