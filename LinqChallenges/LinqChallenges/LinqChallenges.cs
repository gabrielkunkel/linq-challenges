using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqChallenges
{
    public static class LinqChallenge
    {

        public static List<string> FilterForSubString(List<string> words, string subCheck)
        {
          return words.Where(w => w.Contains(subCheck)).ToList();
        }

        public static List<string> FilterDuplicates(List<string> names)
        {
          return names.Distinct().ToList();
        }

        public static double AverageGrades(List<string> gradeStrings)
        {

            // average
            // min/ max (rid lowesr)


            //gradeStrings.Select(s => s.Split(',').Select(g => Double.Parse(g)));

            List<double> numberGrades = new List<double>();
            foreach(string set in gradeStrings)
            {
                string[] grades = set.Split(',');

                grades.ToList();

                List<double> numbers = new List<double>();

                foreach (string numString in grades)
                {
                    numbers.Add(Double.Parse(numString));
                }
                numbers.Remove(numbers.Min());
                numberGrades.Add(numbers.Average());
                
                
                
            }



            return numberGrades.Average();

        }




    }
}
