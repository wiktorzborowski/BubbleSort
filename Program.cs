using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] {66,55,79,9,1,88,33,55};

            string inputResult = string.Join(",", intArray);
                
            Console.WriteLine("Unsorted array: " + inputResult);

            for (int pass = 1; pass < intArray.Length; pass++)
            {
                for (int i = 0; i < intArray.Length - 1; i++)
                {
                    if(intArray[i] > intArray[i + 1])
                    {
                        Swap(intArray, i, i + 1);
                    }
                }
            }

            string outputResult = string.Join(",", intArray);
                
            Console.WriteLine("Sorted array:" + outputResult);
        }

        private static void Swap(int[] ar, int pos1, int pos2)
        {
            int a = ar[pos1];
            ar[pos1] = ar[pos2];
            ar[pos2] = a;
        }
    }
}
