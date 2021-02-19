using System;

namespace AlgorithmsAndDataStructures
{
    static class Program
    {
        static void Main(string[] args)
        {
            var arrayNumbers = //new int[]
            //{
            //    2,4,5,7,1,2,3,6
            //};
            GenerateArrayOfNumbers(20, 0, 20);
            
            
            Console.WriteLine(String.Join(",", arrayNumbers));
            arrayNumbers.MergeSort(0, arrayNumbers.Length - 1);
            //arrayNumbers.SelectionSort();
            //arrayNumbers.Merge(0, 4, 8);

            Console.WriteLine(String.Join(",", arrayNumbers));
            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static int[] GenerateArrayOfNumbers(int length, int min = 0, int max = 9)
        {

            // this declares an integer array with 5 elements
            // and initializes all of them to their default value
            // which is zero
            
            int[] test2 = new int[length]; 

            Random randNum = new Random();
            for (int i = 0; i < test2.Length; i++)
            {
                test2[i] = randNum.Next(min, max);
            }

            return test2;
        }

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
                
                Console.WriteLine(String.Join(",", arrayNumbers));
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
                Console.WriteLine(String.Join(",", arrayNumbers));
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
                Console.WriteLine(String.Join(",", arrayNumbers));
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
                Console.WriteLine(String.Join(",", arrayNumbers));
            }
        }

        private static void MergeSort(this int[] arrayNumbers, int p, int r)
        {
            if (p >= r)
            {
                return;
            }

            var q = (p + r) / 2;
            arrayNumbers.MergeSort(p, q);
            arrayNumbers.MergeSort( q + 1, r);
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
            Console.WriteLine("ArrayOfNumbers:" + String.Join(",", arrayNumbers));
            
        }
    }
}