using System;
using System.Diagnostics;
using AlgorithmsAndDataStructures.Extensions;

namespace AlgorithmsAndDataStructures
{
    static class Program
    {
        public static int[] ArrayNumbers;
        public static Stopwatch StopWatch;

        static Program()
        {
            ArrayNumbers = ArrayNumbers.GenerateArrayOfNumbers(100000);
            StopWatch = new Stopwatch();
        }
        
        static void Main(string[] args)
        {
            StopWatch.Start();
            Console.WriteLine(String.Join(",", ArrayNumbers));
            
            
            ArrayNumbers.MergeSort();
            //arrayNumbers.SelectionSort();
            
            
            Console.WriteLine(String.Join(",", ArrayNumbers));
            Console.WriteLine("RunTime " + StopWatch.StopAndConsoleWriteLine());
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}