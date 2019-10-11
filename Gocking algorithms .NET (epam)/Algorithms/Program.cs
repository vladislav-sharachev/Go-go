using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        private static Object binarySearch (int[] list, int item)
        {
            int low = 0;
            int high = list.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = list[mid];
                if (guess == item)
                {
                    return mid;
                }
                if (guess > item)
                {
                    high = mid - 1;
                } else
                {
                    low = low + 1;
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(binarySearch(list, 2));
        }
    }
}
