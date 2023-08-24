using DataStructuresAndAlgorithms.CustomDataTypeCollection;
using System;

namespace DataStructuresAndAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3, 2, 4, 7, 8,213,3544, 4, 3,2, 65, 56  };

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}: {array[i]}");
            }

            Console.WriteLine();

            Console.WriteLine(Algorithms.SeqSearchLast(array, 1));
        }
    }
}
