using DataStructuresAndAlgorithms.CustomDataTypeCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public static class Algorithms
    {
        public static int SeqSearch(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int SeqSearchWitPos(int[] array,int value, int occurence)
        {
            int count = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    if (count < occurence)
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

        public static int SeqSearchLast(int[] array, int value)
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

        public static int BinarySearch(int[] array, int value)
        {
            int upperBound = array.Length - 1;  
            int lowerBound = 0;
            int mid;

            while(upperBound >= lowerBound)
            {
                mid = (upperBound + lowerBound) / 2;

                if (array[mid] == array[value])
                {
                    return mid;
                }

                if (array[mid] > array[value])
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

        public static int RecursiveBinarySearch(int[] array, int value, int lower, int upper)
        {
            if(lower > upper)
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
                    return RecursiveBinarySearch(array, value, lower, mid - 1);
                }
                else if(value == array[mid])
                {
                    return mid;
                }
                else
                {
                    return RecursiveBinarySearch(array, value, mid + 1, upper);
                }

            }
        }
    }
}
