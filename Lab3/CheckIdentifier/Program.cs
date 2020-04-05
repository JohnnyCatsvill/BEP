using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIdentifier
{
    public class Program
    {
        const int GOOD_IDENTIFIER = 0;
        const int BAD_IDENTIFIER = 1;

        public static int Main(string[] args)
        {
            string identifier = args[0];

            for (int i = 0; i < identifier.Length; i++)
            {
                if (i == 0)
                {
                    if (!Char.IsLetter(identifier[i]))
                    {
                        Console.WriteLine("Не начинается с буквы");
                        return BAD_IDENTIFIER;
                    }
                }
                else
                {
                    if (!Char.IsLetter(identifier[i]))
                    {
                        if (!Char.IsDigit(identifier[i]))
                        {
                            Console.WriteLine($"Символ '{identifier[i]}' не является ни буквой, ни цифрой");
                            return BAD_IDENTIFIER;
                        }
                    }
                }
            }
            return GOOD_IDENTIFIER;
        }
    }
}
