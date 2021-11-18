using System;

namespace CAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            CAssignment cAssignment = new CAssignment();

            int inputArrayLength;

            Console.WriteLine("Enter length of the input Array");
            inputArrayLength = Int32.Parse(Console.ReadLine());

            if (inputArrayLength <= 0)
            {
                Console.WriteLine("Array length is invalid. Program is exiting...");
                System.Environment.Exit(0);
            }
            else 
            { 
            int[] inputArray = new int[inputArrayLength];

            Console.WriteLine("Now Give " + inputArrayLength + " numbers for input array: ");

            for (int i = 0; i < inputArrayLength; i++)
            {
                inputArray[i] = Int32.Parse(Console.ReadLine());
            }

            cAssignment.DisplayArray(inputArray);
            }

        }
    }
}
