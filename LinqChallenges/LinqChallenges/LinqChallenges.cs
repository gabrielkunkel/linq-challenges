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
            return gradeStrings
                .Select(s => s.Split(',')
                    .Select(g => Double.Parse(g))
                        .OrderBy(a => a).Skip(1).Average()) 
                .Average();
        }

        public static string CompressString(string input)
        {

            return "fuck you";
        }




    }
}
