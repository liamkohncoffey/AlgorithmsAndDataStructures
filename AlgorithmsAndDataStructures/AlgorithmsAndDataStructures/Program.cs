using System;

namespace AlgorithmsAndDataStructures
{
    static class Program
    {
        static void Main(string[] args)
        {
            var arrayNumbers = new int[]
            {
                5, 2, 4, 6, 1, 3, 8, 7, 9, 2
            };

            arrayNumbers.InsertionSortDesc();


            Console.WriteLine("Done");
            Console.ReadKey();
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
            for (var j = 0; j < arrayNumbers.Length; j++)
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
    }
}