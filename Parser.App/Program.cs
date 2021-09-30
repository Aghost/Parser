using System;
using System.Text;
using System.Collections.Generic;
using Parser.Core.Types;

using static System.Console;
using static Parser.Core.CharParser;

namespace Parser.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Token[] tk = ParseString(args.Length < 1 ? "Banaan(12+23-45)" : String.Join("", args));

            foreach(Token token in tk) {
                WriteLine($"{token.type} {token.tvalue}");
            }
        }
    }

}
