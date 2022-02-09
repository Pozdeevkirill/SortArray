using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 6, 2, 1, 10, 10,10,23, 1, 4 };//Output 2, 6
            NonRecurring(array);
            Console.ReadLine();
        }
        static void NonRecurring(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)//Сортировака массива 
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        var b = arr[i];
                        arr[i] = arr[j];
                        arr[j] = b;
                    }
                }
            }
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("***********");
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    if (i < arr.Length - 1)
                    {
                        if (arr[i] != arr[i + 1])
                            Console.WriteLine(arr[i]);
                    }
                    else
                    {
                        if (arr[i] != arr[i - 1])
                            Console.WriteLine(arr[i]);
                    }
                }
            }
        }
    }
}
