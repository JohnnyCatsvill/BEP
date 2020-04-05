using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RemoveExtraBlanks
{
    public class Program
    {
        public static void ExtraBlankRemover(ref string fin, ref string fout)
        {
            char spacingSymbol = ' ';
            bool lastSymbolIsSpace = false;
            for (int i = 0; i < fin.Length; i++)
            {
                char ch = fin[i];
                if (ch != ' ' && ch != '\t')
                {
                    if (lastSymbolIsSpace)
                    {
                        if (spacingSymbol != 'N')
                        {
                            fout += spacingSymbol;
                        }
                        lastSymbolIsSpace = false;
                    }
                    fout += ch;
                }
                else
                {
                    if (!lastSymbolIsSpace)
                    {
                        spacingSymbol = ch;
                        if (i == 0)
                        {
                            spacingSymbol = 'N';
                        }
                        lastSymbolIsSpace = true;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            string inputPath = args[0];
            string outputPath = args[1];

            string fin = System.IO.File.ReadAllText(inputPath);
            string res = "";

            ExtraBlankRemover(ref fin, ref res);
            
            System.IO.File.WriteAllText(outputPath, res);
        }
    }
}
