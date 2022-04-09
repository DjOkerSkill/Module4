using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] {5,-1,6,-3,5,4,-2,-9,-54,76};
            int count = 0;

            foreach (var i in array)
            {
                if (i>0)
                {
                    count ++;
                }
            }
            Console.WriteLine(count);
        }
        
    }
}
