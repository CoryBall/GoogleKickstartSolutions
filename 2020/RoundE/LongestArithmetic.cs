using System;
using System.Collections.Generic;

namespace GoogleKickStart._2020.Round_E
{
    public static class LongestArithmetic
    {
    public static void Run()
    {
        var numberOfTests = Convert.ToInt32(Console.ReadLine());

        for (var i = 0; i < numberOfTests; i++)
        {
            var array = new List<int>();

            var arrayLength = Convert.ToInt32(Console.ReadLine());

            var numbers = (Console.ReadLine())?.Split(' ');

            for (var j = 0; j < numbers?.Length; j++)
                array.Add(int.Parse(numbers[j]));

            Console.WriteLine($"Case #{i + 1}: {LargestSubarray(array)}");
        }
    }

    private static int LargestSubarray(IReadOnlyList<int> array)
    {
        var difference = 0;
        var length = 0;
        var longestSubArray = 0;

        for (int i = 1; i < array.Count; i++)
        {
            if (array[i] - array[i - 1] == difference)
            {
                length++;
            }
            else
            {
                difference = array[i] - array[i - 1];
                if (length > longestSubArray) longestSubArray = length;
                length = 2;
            }
        }

        return length > longestSubArray ? length : longestSubArray;
    }
    }
}