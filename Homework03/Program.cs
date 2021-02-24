using System;

namespace Homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lower Triangular Matrix

            //int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }};
            //lowerTriangularMatrix(mas, 3, 3);

            // Merge Arrays

            //int[] arr = { 1, 2, 20, 6, 0 };
            //int[] arrcopy;
            //int[] arr2 = { 4, 5 };
            //int[] arr2copy;
            //int[] sumOfBothArrays;
            //int lenghtOfArrSum = 0;
            //int item = 0;
            //if (arr.Length > arr2.Length)
            //{
            //    lenghtOfArrSum = arr.Length;
            //    sumOfBothArrays = new int[arr.Length];
            //    arr2copy = new int[lenghtOfArrSum];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (item < arr2.Length)
            //        {
            //            arr2copy[i] = arr2[item];
            //            item++;
            //        }
            //        else
            //        {
            //            item = 0;
            //            i--;
            //        }
            //    }
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        sumOfBothArrays[i] = arr[i] + arr2copy[i];
            //        Console.WriteLine("The sum of both arrays is: " + sumOfBothArrays[i]);
            //    }
            //}
            //else if (arr.Length < arr2.Length)
            //{
            //    lenghtOfArrSum = arr2.Length;
            //    sumOfBothArrays = new int[arr2.Length];
            //    arrcopy = new int[lenghtOfArrSum];
            //    for (int i = 0; i < arr2.Length; i++)
            //    {
            //        if (item < arr.Length)
            //        {
            //            arrcopy[i] = arr[item];
            //            item++;
            //        }
            //        else
            //        {
            //            item = 0;
            //            i--;
            //            continue;
            //        }
            //    }
            //    for (int i = 0; i < arr2.Length; i++)
            //    {
            //        sumOfBothArrays[i] = arr2[i] + arrcopy[i];
            //        Console.WriteLine("The sum of both arrays is: " + sumOfBothArrays[i]);
            //    }

            //}
            //else if (arr.Length == arr2.Length)
            //{
            //    sumOfBothArrays = new int[arr.Length];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        sumOfBothArrays[i] = arr[i] + arr2[i];
            //        Console.WriteLine("The sum of both arrays is: " + sumOfBothArrays[i]);
            //    }
            //}

            // Delete element from Array

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] arrCopy = new int[arr.Length-1];
            //Console.Write("Which element do you want to delete: ");
            //int element = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < arrCopy.Length; i++)
            //{
            //    arrCopy[i] = arr[i];
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (element == i)
            //    {
            //        if (element == arrCopy.Length)
            //        {
            //            for (int k = element-1; k < arrCopy.Length; k++)
            //            {
            //                arrCopy[k] = arr[8];
            //            }
            //        }
            //        for (int j = element; j < arrCopy.Length; j++)
            //        {
            //                arrCopy[j] = arr[j + 1];
            //        }
            //        break;
            //    }
            //}
            //foreach (var item in arrCopy)
            //{
            //    Console.WriteLine(item);
            //}


            //Check whether two rectangles are overlapping.

            //  i could not do it

        }

        //static void lowerTriangularMatrix(int[,] matrix, int height, int width)
        //{
        //    for (int i = 0; i < height; i++)
        //    {
        //        for (int j = 0; j < width; j++)
        //        {
        //            if (i < j)
        //            {
        //                Console.Write("0" + " ");
        //            }
        //            else
        //            {
        //                Console.Write(matrix[i, j] + " ");
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
