using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
     public class Time
    {
        public void time() {

            Stopwatch stopwatch = new Stopwatch();

            // Start the stopwatch
            stopwatch.Start();

            // Your code to measure execution time goes here
            // For example, a time-consuming operation
            for (int i = 0; i < 100000000; i++)
            {
                // Some operation
            }

            // Stop the stopwatch
            stopwatch.Stop();

            // Get the elapsed time in milliseconds
            long elapsedTime = stopwatch.ElapsedMilliseconds;

            // Print the execution time
            Console.WriteLine($"Execution Time: {elapsedTime} milliseconds");

        }
    }
}
