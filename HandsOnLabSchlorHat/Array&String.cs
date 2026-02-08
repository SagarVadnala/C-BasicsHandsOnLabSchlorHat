using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace HandsOnLabSchlorHat
{
    public class Array_String
    {
        public void AvgArrayElements()
        {
            int[] Nums = { 1, 2, 3, 4, 5, 6, 7 };
            int sum = 0;
            for (int i = 0; i < Nums.Length; i++)
            {
                sum += Nums[i];

            }
            int avg = sum / Nums.Length;
            Console.WriteLine($"AVg :{avg}");
        }

        public void LargestArrayElements()
        {
            int[] Nums = { 1, 2, 3, 8, 5, 6, 7 };
            int max = 0;
            for (int i = 0; i < Nums.Length; i++)
            {
                if (Nums[i] > max)
                {
                    max = Nums[i];
                }
            }

            Console.WriteLine($"MAX is  :{max}");
        }
        public void RotateMatrixRight()
        {
            int[,] matrix = {{1,2,3},
                            {4,5,6},
                            { 7,8,9} };
            RotateMat(matrix);

            PrintMatrix(matrix);
        }

        static void RotateMat(int[,] matrix)
        {
            int n = matrix.GetLength(0);

            //transpose the matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = temp;
                }
            }

            // Reverse rows
            for (int i = 0; i < n; i++)
            {
                int left = 0, right = n - 1;
                while (left < right)
                {
                    int temp = matrix[i, left];
                    matrix[i, left] = matrix[i, right];
                    matrix[i, right] = temp;
                    left++;
                    right--;
                }
            }
        }
        static void PrintMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.WriteLine();
            }

        }
    }
}
