using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.CustomDataTypeCollection
{
    public class CArray
    {
        private int[] array;
        private int upper;
        private int numberOfElemets;

        public CArray(int size)
        {
            array = new int[size];
            upper = size - 1;
            numberOfElemets = 0;
        }

        public void Insert(int element)
        {
            array[numberOfElemets] = element;
            numberOfElemets++;
        }

        public void DisplayElements()
        {
            for (int i = 0; i < upper; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public void Clear()
        {
            for (int i = 0; i < upper; i++)
            {
                array[i] = 0;
            }

            numberOfElemets = 0;
        }

        public void BubbleSort()
        {
            int temp;
            for (int outer = upper; outer >= 1; outer--)
            {
                for (int inner = 0; inner < outer - 1; inner++)
                {
                    if (array[inner] > array[inner + 1])
                    {
                        temp = array[inner];
                        array[inner] = array[inner + 1];
                        array[inner + 1] = temp;
                    }
                }
                this.DisplayElements();
                Console.WriteLine();
            }
        }

        public void SelectionSort()
        {
            int temp;
            int min; // index of minimum element

            for (int outer = 0; outer <= upper; outer++)
            {
                min = outer;

                for (int inner = outer + 1; inner <= upper; inner++)
                {
                    if (array[inner] < array[min])
                    {
                        min = inner;
                    }
                }

                temp = array[min];
                array[min] = array[outer];
                array[outer] = temp;
            }
        }

        public void InsertionSort()
        {
            int temp;
            int inner;

            for (int outer = 1; outer <= upper; outer++)
            {
                temp = array[outer];
                inner = outer;

                while (inner > 0 && array[inner - 1] >= temp)
                {
                    array[inner] = array[inner - 1];
                    inner -= 1;
                }

                array[inner] = temp;
            }
        }

        public int BinarySearch(int value)
        {
            int upperBound = array.Length - 1;
            int lowerBound = 0;
            int mid;

            while (lowerBound <= upperBound)
            {
                mid = (upperBound + lowerBound) / 2;

                if (array[mid] == value)
                {
                    return mid;
                }

                if (array[mid] > value)
                {
                    upperBound = mid + 1;
                }
                else
                {
                    lowerBound = mid - 1;
                }
            }

            return -1;
        }

        public int RecursiveBinarySearch(int value, int lower, int upper)
        {
            if (lower > upper)
            {
                return -1;
            }
            else
            {
                upper = array.Length - 1;
                lower = 0;
                int mid = (int)(upper + lower) / 2;

                if (value < array[mid])
                {
                    return RecursiveBinarySearch(value, lower, mid - 1);
                }
                else if (value == array[mid])
                {
                    return mid;
                }
                else
                {
                    return RecursiveBinarySearch(value, mid + 1, upper);
                }

            }
        }

        public int SeqSearch(int value, int index)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    if(count < index)
                    {
                        count++;
                    }
                    else
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
        public int SeqSearchLastElement(int value)
        {
            int currentLastPosition = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    currentLastPosition = i;
                }
            }

            return currentLastPosition;
        }

    }
}
