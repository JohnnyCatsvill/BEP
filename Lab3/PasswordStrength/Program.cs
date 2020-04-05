using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordStrength
{
    public class Program
    {
        public static void InvestigatePasswordChars(string password, ref short[] upperLetters, ref short[] lowerLetters, ref short[] digits, ref int upperAmount, ref int lowerAmount, ref int digitAmount)
        {
            foreach (char ch in password)
            {
                int charNum = (int)ch;
                if ((int)'A' <= charNum && charNum <= (int)'Z')
                {
                    upperAmount++;
                    upperLetters[charNum - (int)'A']++;
                }
                else if ((int)'a' <= (int)ch && (int)ch <= (int)'z')
                {
                    lowerAmount++;
                    lowerLetters[charNum - (int)'a']++;
                }
                else if (Char.IsDigit(ch))
                {
                    digitAmount++;
                    digits[charNum - (int)'0']++;
                }
            }
        }

        public static int AddStrengthForAllSymbols(int passwordLength)
        {
            return 4 * (passwordLength);
        }

        public static int AddStrengthForAllDigits(int digitAmount)
        {
            return 4 * digitAmount;
        }

        public static int AddStrengthForPasswordThatContainUpperRegister(int passwordLength, int upperAmount)
        {
            return 2 * (passwordLength - upperAmount);
        }

        public static int AddStrengthForPasswordThatContainLowerRegister(int passwordLength, int lowerAmount)
        {
            return 2 * (passwordLength - lowerAmount);
        }

        public static int RemoveStrengthForPasswordThatContainOnlyLetters(int digitAmount, int lowerAmount, int upperAmount)
        {
            if (digitAmount == 0)
            {
                return -(lowerAmount + upperAmount);
            }
            else
            {
                return 0;
            }
        }

        public static int RemoveStrengthForPasswordThatContainOnlyDigits(int digitAmount, int lowerAmount, int upperAmount)
        {
            if (upperAmount + lowerAmount == 0)
            {
                return -(digitAmount);
            }
            else
            {
                return 0;
            }
        }

        public static int RemoveStrengthForRepeatedSymbols(ref short[] upperLetters, ref short[] lowerLetters, ref short[] digits)
        {
            int toRemove = 0;
            foreach (int i in upperLetters.Concat(lowerLetters).Concat(digits))
            {
                if (i > 1)
                {
                    toRemove -= i;
                }
            }
            return toRemove;
        }

        public static int CalculatePasswordStrength(ref short[] upperLetters, ref short[] lowerLetters, ref short[] digits, int upperAmount, int lowerAmount, int digitAmount)
        {
            int passwordLength = upperAmount + lowerAmount + digitAmount;
            int passwordStrength = 0;

            passwordStrength += AddStrengthForAllSymbols(passwordLength);
            passwordStrength += AddStrengthForAllDigits(digitAmount);
            passwordStrength += AddStrengthForPasswordThatContainUpperRegister(passwordLength, upperAmount);
            passwordStrength += AddStrengthForPasswordThatContainLowerRegister(passwordLength, lowerAmount);
            passwordStrength += RemoveStrengthForPasswordThatContainOnlyLetters(digitAmount, lowerAmount, upperAmount);
            passwordStrength += RemoveStrengthForPasswordThatContainOnlyDigits(digitAmount, lowerAmount, upperAmount);
            passwordStrength += RemoveStrengthForRepeatedSymbols(ref upperLetters, ref lowerLetters, ref digits);
            
            return passwordStrength;
        }

        public static int Main(string[] args)
        {
            string password = args[0];

            short[] upperLetters = new short[26];
            short[] lowerLetters = new short[26];
            short[] digits = new short[10];

            int upperAmount = 0;
            int lowerAmount = 0;
            int digitAmount = 0;

            InvestigatePasswordChars(password, ref upperLetters, ref lowerLetters, ref digits, ref upperAmount, ref lowerAmount, ref digitAmount);

            return CalculatePasswordStrength(ref upperLetters, ref lowerLetters, ref digits, upperAmount, lowerAmount, digitAmount);
        }
    }
}
