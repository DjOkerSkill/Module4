using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int change;

            for (int i=0; i < arr.Length; i++)
            {
                for (int j = 1+i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        change = arr[j];
                        arr[j] = arr[i];
                        arr[i] = change;
                    }
                }
                Console.Write(arr[i]+" ");
            }
        }
        
    }
}
