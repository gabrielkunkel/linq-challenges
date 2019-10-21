using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqChallenges
{
    public static class LinqChallenge
    {

        public static List<string> FilterForSubString (List<string> words, string subCheck)
        {


            var filteredWords =  words.Where(w => w.Contains(subCheck)).ToList();
            return filteredWords;
          
        }


        
        // go through list
        // filter for substring "th" list.Contains




    }
}
