using System;

namespace RemoveDuplicates
{
    class Program
    {
        static bool ArgumentsEnoughForProgram(ref string[] arguments)
        {
            if (arguments.Length != 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static void RemoveCharDuplicates(ref string sin, ref string sout)
        {
            for (int i = 0; i < sin.Length; i++)
            {
                bool is_find = false;
                for (int j = 0; j < i; j++)
                {
                    if (sin[i] == sin[j])
                    {
                        is_find = true;
                    }
                }
                if (!is_find)
                {
                    sout += sin[i];
                    
                }
            }
        }

        static void Main(string[] args)
        {
            if (ArgumentsEnoughForProgram(ref args))
            {
                string cin = args[0];
                string cout = "";
                RemoveCharDuplicates(ref cin, ref cout);
                Console.WriteLine(cout);
            }
            else
            {
            Console.WriteLine("Incorrect number of arguments!");
            }
        }
    }
}