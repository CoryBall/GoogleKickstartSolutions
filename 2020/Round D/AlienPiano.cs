using System;
using System.Collections.Generic;

namespace GoogleKickStart._2020.Round_D
{
    public static class AlienPiano
    {
        public static void Run()
        {
            var numberOfTests = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < numberOfTests; i++)
            {
                var notes = new List<int>();

                var numberOfNotes = Convert.ToInt32(Console.ReadLine());

                var inputs = (Console.ReadLine())?.Split(' ');

                for (var j = 0; j < inputs?.Length; j ++)
                    notes.Add(int.Parse(inputs[j]));
                
                Console.WriteLine($"Case #{i+1}: {MinimumRulesBroken(notes)}");
            }
        }

        private static int MinimumRulesBroken(IReadOnlyList<int> notes)
        {
            var numberRulesBroken = 0;


            return numberRulesBroken;
        }
        
    }
}