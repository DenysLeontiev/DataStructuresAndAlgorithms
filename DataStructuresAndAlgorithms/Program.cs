using DataStructuresAndAlgorithms.CustomDataTypeCollection;
using System;

namespace DataStructuresAndAlgorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            CArray nums = new CArray(6);

            var random = new Random();

            for (int i = 0; i <= 5; i++)
            {
                nums.Insert(random.Next(10,100));
            }

            nums.DisplayElements();

            Console.WriteLine("Sorted: ");

            nums.InsertionSort();

            nums.DisplayElements();
        }
    }
}
