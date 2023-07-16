using System.Diagnostics;

namespace Complexxity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            int target = 4;

            for(int i=0; i<array.Length; i++)
            {
                if (target == array[i])
                {
                    Console.WriteLine($"it is in index: {i}");
                }
            }
            sw.Stop();
            TimeSpan ts = sw.Elapsed;

            
            Console.WriteLine("RunTime " + ts.Milliseconds);
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            Console.WriteLine(binarySearch(array, target));
            sw.Stop();
            TimeSpan ts1 = sw1.Elapsed;
            Console.WriteLine("RunTime " + ts1.Milliseconds);
        }

        static int binarySearch(int[] arr, int x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                // Check if x is present at mid
                if (arr[m] == x)
                    return m;

                // If x greater, ignore left half
                if (arr[m] < x)
                    l = m + 1;

                // If x is smaller, ignore right half
                else
                    r = m - 1;
            }

            // If we reach here, then element was
            // not present
            return -1;
        }
    }
}