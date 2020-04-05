using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordStrength;
using Xunit;

namespace PasswordStrength.Tests
{
    public class PasswordStrengthTests
    {
        [Fact]
        public void ShouldReturnFourTimesMoreThanGivenLengthForAllSymbols()
        {
            int symbolsAmount = 6;
            int expected = 24;
            int actual = Program.AddStrengthForAllSymbols(symbolsAmount);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnFourTimesMoreThanGivenLengthForDigits()
        {
            int digitsAmount = 2;
            int expected = 8;
            int actual = Program.AddStrengthForAllDigits(digitsAmount);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnTwoTimesMoreThanRangeBetweenPasswordLengthAndUpperAmount()
        {
            int passwordLength = 8;
            int upperAmount = 2;
            int expected = 12;
            int actual = Program.AddStrengthForPasswordThatContainUpperRegister(passwordLength, upperAmount);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnTwoTimesMoreThanRangeBetweenPasswordLengthAndLowerAmount()
        {
            int passwordLength = 12;
            int lowerAmount = 0;
            int expected = 24;
            int actual = Program.AddStrengthForPasswordThatContainLowerRegister(passwordLength, lowerAmount);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnMinusSumOfLettersCauseThereIsNoDigits()
        {
            int upperAmount = 2;
            int lowerAmount = 8;
            int digitAmount = 0;
            int expected = -10;
            int actual = Program.RemoveStrengthForPasswordThatContainOnlyLetters(digitAmount, lowerAmount, upperAmount);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnMinusSumOfDigitsCauseThereIsNoLetters()
        {
            int upperAmount = 0;
            int lowerAmount = 0;
            int digitAmount = 8;
            int expected = -8;
            int actual = Program.RemoveStrengthForPasswordThatContainOnlyDigits(digitAmount, lowerAmount, upperAmount);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnMinusSumOfRepeatedSymbols()
        {
            short[] upperLetters = { 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 }; //there -2
            short[] lowerLetters = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 3, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0 }; //there -5
            short[] digits = { 0, 1, 0, 0, 0, 0, 0, 0, 3, 0 }; //there -3
            int expected = -10;
            int actual = Program.RemoveStrengthForRepeatedSymbols(ref upperLetters, ref lowerLetters, ref digits);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnExpectedPasswordStrength()
        {
            string[] input = { "abcd1a" };
            int expected = 40;
            int actual = Program.Main(input);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnExpectedSymbolAmounts()
        {
            string input = "AaB09zzZ";

            short[] upperLetters = new short[26];
            short[] lowerLetters = new short[26];
            short[] digits = new short[10];

            int expectedUpperAmount = 3;
            int expectedLowerAmount = 3;
            int expectedDigitAmount = 2;

            int actualUpperAmount = 0;
            int actualLowerAmount = 0;
            int actualDigitAmount = 0;

            Program.InvestigatePasswordChars(input, ref upperLetters, ref lowerLetters, ref digits, ref actualUpperAmount, ref actualLowerAmount, ref actualDigitAmount);
            Assert.Equal(expectedUpperAmount, actualUpperAmount);
            Assert.Equal(expectedLowerAmount, actualLowerAmount);
            Assert.Equal(expectedDigitAmount, actualDigitAmount);
        }

        [Fact]
        public void ShouldReturnExpectedSymbolArrays()
        {
            string input = "AaB09zzZ";

            short[] expectedUpperSymbols = { 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
            short[] expectedLowerSymbols = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2 };
            short[] expectedDigitSymbols = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 };

            short[] actualUpperSymbols = new short[26];
            short[] actualLowerSymbols = new short[26];
            short[] actualDigitSymbols = new short[10];

            int upperAmount = 0;
            int lowerAmount = 0;
            int digitAmount = 0;

            Program.InvestigatePasswordChars(input, ref actualUpperSymbols, ref actualLowerSymbols, ref actualDigitSymbols, ref upperAmount, ref lowerAmount, ref digitAmount);
            Assert.Equal(expectedUpperSymbols, actualUpperSymbols);
            Assert.Equal(expectedLowerSymbols, actualLowerSymbols);
            Assert.Equal(expectedDigitSymbols, actualDigitSymbols);
        }

    }
}
