using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoveExtraBlanks;
using Xunit;

namespace RemoveExtraBlanks.Tests
{
    public class RemoveExtraBlanksTests
    {
        [Fact]
        public void FirstSpacesAndTabsMustBeDeleted()
        {
            string input = "   \t\tSomething left here";
            string expected = "Something left here";
            string actual = "";
            Program.ExtraBlankRemover(ref input, ref actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LastSpacesAndTabsMustBeDeleted()
        {
            string input = "Firstly was this word\t\t    ";
            string expected = "Firstly was this word";
            string actual = "";
            Program.ExtraBlankRemover(ref input, ref actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BetweenWordsSpacesAndTabsMustBeUsedOnlyOnce()
        {
            string input = "Word    wordAfterManySpaces\t\t\twordAfterManyTabs \t\twordAfterSpaceAndDoubleTabs\t   wordAfterTabAndManySpaces";
            string expected = "Word wordAfterManySpaces\twordAfterManyTabs wordAfterSpaceAndDoubleTabs\twordAfterTabAndManySpaces";
            string actual = "";
            Program.ExtraBlankRemover(ref input, ref actual);
            Assert.Equal(expected, actual);
        }
    }
}
