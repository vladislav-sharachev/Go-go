using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    class NewTryBinarySearh
    {
        private static object binarySearch(int[] list, int item)
        {
            int low = 0;
            int high = list.length - 1;
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
                }
                else
                {
                    low = mid + 1;
                }
            }
            return null;
        }
        static void Main(string[] args)
        {
            int[] list = { 1, 2, 3, 54, 66 };

            Console.WriteLine(binarySearch(list, 2));
        }
    }
}
