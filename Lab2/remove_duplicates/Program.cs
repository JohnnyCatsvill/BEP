using System;

namespace remove_duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Incorrect number of arguments!");
            }
            else
            {
                string argument = args[0];
                for (int i = 0; i < argument.Length; i++)
                {
                    bool is_find = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (argument[i] == argument[j])
                        {
                            is_find = true;
                        }
                    }
                    if (!is_find)
                    {
                        Console.Write(argument[i]);
                    }
                }
                Console.WriteLine();

            }
        }
    }
}
