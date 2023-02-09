/*
Author: Anthony Gregorio
Date: 2/28/2023
Description: C# Console Application using Arrays
*/



using System;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
     
            int n = 25;

            int[] fibonacci = new int[n];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

       
            for (int i = 2; i < n; i++)
            {
            
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
            }


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Fibonacci number (" + i + ") = " + fibonacci[i]);
            }
        }
    }
}