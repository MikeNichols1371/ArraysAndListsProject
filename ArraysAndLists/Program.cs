using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    class Program
    {
        public static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] myArray1 = new int[10];
            int index = 0;
            for (int i = 1; i <= 10; i++)
            {
                myArray1[index] = i;
                index++;
            }
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evenNum = new List<int>();

            var oddNum = new List<int>();

            foreach (var num in myArray1)
            {
                if (num % 2 == 0)
                {
                    evenNum.Add(num);
                }
                else
                {
                    oddNum.Add(num);                
                }
            }

            

            foreach (var num in evenNum)
            {
                Console.WriteLine(num);
            }

            foreach (var num in oddNum)
            {
                Console.WriteLine(num);
            }
            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
