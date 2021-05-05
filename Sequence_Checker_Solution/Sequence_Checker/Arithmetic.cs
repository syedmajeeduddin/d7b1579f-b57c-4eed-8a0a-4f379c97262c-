using System;
using System.Linq;

namespace Numbers.Calculation
{
    public static class Arithmetic
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strSequence">Input String</param>
        /// <returns></returns>
        public static string GetIncreasingSequence(string strSequence)
        {
            int first = 0; int last = 0; int start = 0;
            int end = 0;

            if (string.IsNullOrWhiteSpace(strSequence))
                return null;

            int[] array = strSequence.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

            for (int iterator = 1; iterator < array.Length; ++iterator)
            {
                // Check if this next element is no longer increasing
                if (array[iterator] <= array[iterator - 1])
                {
                    // No longer increasing.
                    // Update the largest found array, if applicable
                    if (end - start > last - first)
                    {
                        // This was a longer sequence
                        last = end;
                        first = start;
                    }

                    // Reset for the next sequence
                    start = iterator;
                    end = iterator;
                }
                else
                {
                    // Still increasing, update the end
                    end = iterator;
                }
            }

            // Save the sequence to a new array
            int[] outCome = new int[last - first + 1];
            for (int loop = first; loop <= last; ++loop)
            {
                outCome[loop - first] = array[loop];
            }

            return string.Join(" ", outCome);
        }


    }

}
