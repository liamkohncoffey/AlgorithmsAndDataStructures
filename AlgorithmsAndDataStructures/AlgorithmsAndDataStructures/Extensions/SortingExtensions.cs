using System;

namespace AlgorithmsAndDataStructures.Extensions
{
    public static class SortingExtensions
    {
        private static void SelectionSort(this int[] arrayNumbers)
        {
            for (var j = 0; j < arrayNumbers.Length; j++)
            {
                var key = j;
                for (var index = j + 1; index < arrayNumbers.Length; index++)
                {
                    if (arrayNumbers[key] > arrayNumbers[index])
                    {
                        key = index;
                    }
                }

                var temp = arrayNumbers[j];
                arrayNumbers[j] = arrayNumbers[key];
                arrayNumbers[key] = temp;
            }
        }
        
        private static void InsertionSortDesc(this int[] arrayNumbers)
        {
            for (var j = 0; j < arrayNumbers.Length; j++)
            {
                var key = arrayNumbers[j];
                var i = j - 1;
                while (i >= 0 && arrayNumbers[i] < key)
                {
                    arrayNumbers[i + 1] = arrayNumbers[i];
                    i = i - 1;
                }

                arrayNumbers[i + 1] = key;
            }
        }
        
        private static void InsertionSort(this int[] arrayNumbers)
        {
            for (var j = 2; j < arrayNumbers.Length; j++)
            {
                var key = arrayNumbers[j];
                var i = j - 1;
                while (i >= 0 && arrayNumbers[i] > key)
                {
                    arrayNumbers[i + 1] = arrayNumbers[i];
                    i = i - 1;
                }

                arrayNumbers[i + 1] = key;
            }
        }
        
        private static void InsertionSortSortBackwards(this int[] arrayNumbers)
        {
            for (var j = arrayNumbers.Length - 2; j >= 0; j--)
            {
                var key = arrayNumbers[j];
                var i = j + 1;
                while (i <= arrayNumbers.Length - 1 && arrayNumbers[i] < key)
                {
                    arrayNumbers[i - 1] = arrayNumbers[i];
                    i = i + 1;
                }

                arrayNumbers[i - 1] = key;
            }
        }

        public static void MergeSort(this int[] arrayNumbers)
        {
            arrayNumbers.MergeSortRecursion(0, arrayNumbers.Length - 1);
        }
        
        private static void MergeSortRecursion(this int[] arrayNumbers, int p, int r)
        {
            if (p >= r)
            {
                return;
            }

            var q = (p + r) / 2;
            arrayNumbers.MergeSortRecursion(p, q);
            arrayNumbers.MergeSortRecursion( q + 1, r);
            Merge(arrayNumbers, p, q, r);
        }

        private static void Merge(this int[] arrayNumbers, int p, int q, int r)
        {
            var n1 = q - p + 1;
            var n2 = r - q;

            var leftArray = new int[n1 + 1];
            var rightArray = new int[n2 + 1];

            for (int l = 1; l < n1 + 1; l++)
            {
                leftArray[l - 1] = arrayNumbers[p + l - 1];
            }
            
            for (int k = 1; k < n2 + 1; k++)
            {
                rightArray[k - 1] = arrayNumbers[q + k];
            }
            
            leftArray[n1] = Int32.MaxValue;
            rightArray[n2] = Int32.MaxValue;

            var i = 0;
            var j = 0;

            for (int k = p; k <= r; k++)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arrayNumbers[k] = leftArray[i];
                    i = i + 1;
                }
                else
                {
                    arrayNumbers[k] = rightArray[j];
                    j = j + 1;
                }
            }
        }
    }
}