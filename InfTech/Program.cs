using System;

namespace InfTech
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter M");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter data");
            int[,] a = ReadMatrix(n);
            Console.WriteLine("Matrix A is filled");
            int[,] b = ReadMatrix(m);
            Console.WriteLine("Matrix B is filled");
            int sum = SumDiagonale(a) + SumDiagonale(b);
            Console.WriteLine($"Summary of elements on main diagonale = {sum}");
        }

        static int[,] ReadMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] row = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(row[j]);
                }
            }
            return matrix;
        }

        static int SumDiagonale(int[,] matrix)
        {
            int sum = 0;
            for(int i = 0; i < matrix.Length; i++)
            {
                sum += matrix[i, i];
            }
            return sum;
        }
    }
}
