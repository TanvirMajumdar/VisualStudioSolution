using System;
using System.Collections.Generic;
using System.Text;

namespace CAssignment
{
    class CAssignment
    {

        public void DisplayArray(int[] inputArray)
        {

            int inputArrayLength = inputArray.Length;
            int[] outputArray= new int[inputArrayLength * 2];

            for(int i=0; i< inputArrayLength*2; i++)
            {
                if (i < inputArrayLength)
                {
                    outputArray[i] = inputArray[i];
                }
                else
                {
                    outputArray[i] = inputArray[i - inputArrayLength];
                }
            }

            Console.WriteLine("Input numbers");

            for (int i = 0; i < inputArrayLength; i++)
            {
                Console.Write(inputArray[i] + "\t");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Output numbers");

            for (int i = 0; i < inputArrayLength*2; i++)
            {
                Console.Write(outputArray[i]+"\t");
            }


        }

    }
}
