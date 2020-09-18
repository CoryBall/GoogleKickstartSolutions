using System;
using System.Collections.Generic;

namespace GoogleKickStart._2020.Round_D
{
    public static class RecordBreaker
    {
        public static void Run()
        {
            var numberOfTests = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < numberOfTests; i++)
            {
                var visitors = new List<int>();

                var numberOfDays = Convert.ToInt32(Console.ReadLine());

                var numbers = (Console.ReadLine())?.Split(' ');

                for (var j = 0; j < numbers?.Length; j ++)
                    visitors.Add(int.Parse(numbers[j]));
                
                Console.WriteLine($"Case #{i+1}: {NumberOfRecordDays(visitors)}");
            }
        }

        private static int NumberOfRecordDays(IReadOnlyList<int> visitors)
        {
            var pastRecord = 0;
            var numberRecords = 0;
            for (var i = 0; i < visitors.Count; i++)
            {
                var newRecord = i == 0 || visitors[i] > pastRecord;
                var largerThanNext = i == visitors.Count - 1 || visitors[i] > visitors[i + 1];

                if (newRecord && largerThanNext) numberRecords++;

                if (newRecord) pastRecord = visitors[i];
            }

            return numberRecords;
        }
    }
}