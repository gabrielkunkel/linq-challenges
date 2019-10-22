using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinqChallenges;
using System.Linq;
using System.Collections.Generic;

namespace LinqChallengesTest
{
  [TestClass]
  public class LinqChallengesTest
  {
    [TestMethod]
    public void FilterForSubString_findwordswithTH_CheckList()
    {
      // arrange
      List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
      string substring = "th";
      List<string> expected = new List<string>() { "the", "this", "tenth", "mathematics" };

      // act
      List<string> actual = LinqChallenge.FilterForSubString(words, substring);

      // assert
      CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void FilterDuplicates()
    {
      // arrange
      List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
      List<string> expected = new List<string>() { "Mike", "Brad", "Nevin", "Ian"};

      // act
      List<string> actual = LinqChallenge.FilterDuplicates(names);

      // assert
      CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void AverageGrades_testAverageGrades_returnsexpected()
    {
            // arrange
            List<string> classGrades = new List<string>() {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55" };
            double expected = 86.125;

        // act
            double actual = LinqChallenge.AverageGrades(classGrades);

        // assert
        Assert.AreEqual(expected, actual);
    }


        [TestMethod]
        public void CompressString_testInput_returnsexpected()
        {
            // arrange
            string input = "Terrill";
            string expected = "E1I1L2R2T1";

            // act
            var actual = LinqChallenge.CompressString(input);

            // assert
            Assert.AreEqual(expected, actual);
        }




    }
}
