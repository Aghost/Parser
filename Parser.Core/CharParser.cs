using System;
using System.Text;
using System.Collections.Generic;
using Parser.Core.Types;

using static System.Console;

namespace Parser.Core
{
    public static class CharParser
    {
        public static Token[] ParseString(string input) {
            List<Token> tokens = new();
            StringBuilder tokenbuilder = new();

            for (int i = 0; i < input.Length;) {
                if (input[i] >= 48 && input[i] <= 57) {
                    tokenbuilder.Clear();

                    while (i < input.Length && input[i] >= 48 && input[i] <= 57) {
                        tokenbuilder.Append(input[i]);
                        i++;
                    }

                    Token t = new('N', tokenbuilder.ToString());
                    tokens.Add(t);
                } else if (input[i] == 42 || input[i] == 43 || input[i] == 45 || input[i] == 47) {
                    Token t = new(input[i], input[i].ToString());
                    tokens.Add(t);
                    i++;
                } else if (input[i] >= 56 && input[i] <= 90) {
                    tokenbuilder.Clear();

                    while (i < input.Length &&
                            (input[i] >= 56 && input[i] <= 90 ||
                            input[i] >= 97 && input[i] <= 122)) {
                        tokenbuilder.Append(input[i]);
                        i++;
                    }

                    Token t = new('F', tokenbuilder.ToString());
                    tokens.Add(t);
                } else {
                    i++;
                }
            }

            return tokens.ToArray();
        }
    }
}
