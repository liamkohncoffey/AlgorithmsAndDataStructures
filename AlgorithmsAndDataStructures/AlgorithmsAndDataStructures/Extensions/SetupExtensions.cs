using System;
using System.Diagnostics;

namespace AlgorithmsAndDataStructures.Extensions
{
    public static class SetupExtensions
    {
        public static string StopAndConsoleWriteLine(this Stopwatch stopWatch)
        {
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            return elapsedTime;
        }

        public static int[] GenerateArrayOfNumbers(this int[] arrayOfNumbers, int length)
        {
            arrayOfNumbers  = new int[length]; 

            Random randNum = new Random();
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = randNum.Next(0, length);
            }

            return arrayOfNumbers;
        }
    }
}