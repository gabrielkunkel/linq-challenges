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






  }
}
