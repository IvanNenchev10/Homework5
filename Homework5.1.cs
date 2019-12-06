using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication137
{
    class Program
    {
        static int findMax(int[] arr)
        {
            int max = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if(max<arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
        static int[] CreateArray(int[] arr)
        {
            int n;
            Console.WriteLine("Enter number of elements in the array:");
            n = int.Parse(Console.ReadLine());
            arr = new int[n];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter element {0}", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        static void PrintArray(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
        static void Main()
        {
            int[] arr = null;
            arr=CreateArray(arr);
            PrintArray(arr);
            Console.WriteLine("Maximum element in the array is:{0}", findMax(arr));
        }
    }
}
