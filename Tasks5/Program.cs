using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер матрицы M ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите размер матрицы N");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[m, n];

            int[] arrnew = new int[0];

            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(-10, 21);
                    Console.Write($"{matrix[i, j],4}");
                    if (matrix[i, j] >= 1 && matrix[i, j] <= 10)
                    {
                        Array.Resize(ref arrnew, arrnew.Length + 1);
                        arrnew[arrnew.Length - 1] = matrix[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Одномерный массив {string.Join(", ", arrnew)}");

            int pro = 1;
            for (int i = 0; i < arrnew.Length; i++)
            {
                pro *= arrnew[i];
            }
            Console.WriteLine($"Произведение элементов полученного одномерного массива {pro}");
            Console.ReadLine();
        }
    }
}
