using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Sorting
{
    class QuickSortDescending : ISorter
    {
        public void Sort(int[] array)
        {
            SortDescending(array);
        }
        public static void SortDescending(int[] array)
        {
            QuickSortRecursiveDescending(array, 0, array.Length - 1);
        }

        private static void QuickSortRecursiveDescending(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = PartitionDescending(array, left, right);
                QuickSortRecursiveDescending(array, left, pivotIndex - 1);
                QuickSortRecursiveDescending(array, pivotIndex + 1, right);
            }
        }

        private static int PartitionDescending(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j] > pivot) // Compare with '>'
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, right);
            return i + 1;
        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }

}
