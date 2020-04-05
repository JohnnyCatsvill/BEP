using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckIdentifier;
using Xunit;

namespace CheckIdentifier.Tests
{
    public class CheckIdentifier
    {
        const int GOOD_IDENTIFIER = 0;
        const int BAD_IDENTIFIER = 1;

        [Fact]
        public void ShouldBeGoodBecauseOfFirstSymbolIsLetterDigitsInTheEnd()
        {
            string[] input = { "LetterFirstDigitsLast101" };
            int expected = GOOD_IDENTIFIER;
            int actual = Program.Main(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldBEGoodBecauseOfFirstSymbolIsLetterDigitsBetweenLetters()
        {
            string[] input = { "letterF1rstD1g1tsBetween" };
            int expected = GOOD_IDENTIFIER;
            int actual = Program.Main(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldBeBadBecauseOfFirstDigitSymbol()
        {
            string[] input = { "101FirstDigits" };
            int expected = BAD_IDENTIFIER;
            int actual = Program.Main(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldBeBadBecauseOfFirstNorDigitNorLetterSymbol()
        {
            string[] input = { "_IsntLetterIsntDigit" };
            int expected = BAD_IDENTIFIER;
            int actual = Program.Main(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldBeBadBecauseOfAnyNorDigitNorLetterSymbol()
        {
            string[] input = { "Isn't_Letter-Isn't_Digit_Between" };
            int expected = BAD_IDENTIFIER;
            int actual = Program.Main(input);
            Assert.Equal(expected, actual);
        }
    }
}
