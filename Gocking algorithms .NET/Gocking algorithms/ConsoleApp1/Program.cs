using System;

namespace ConsoleApp1
{
    class Program
    {
        private static Object binarySearch(int[] list, int item)
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
            int[] myList = {1, 2, 3, 4, 5, 7, 10, 15};

            Console.WriteLine(binarySearch(myList, 2));
        }
    }
}
