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
                tokenbuilder.Clear();

                if (input[i] >= '0' && input[i] <= '9') {

                    while (i < input.Length && input[i] >= '0' && input[i] <= '9') {
                        tokenbuilder.Append(input[i]);
                        i++;
                    }

                    Token t = new('N', tokenbuilder.ToString());
                    tokens.Add(t);
                } else if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/') {
                    Token t = new(input[i], input[i].ToString());
                    tokens.Add(t);
                    i++;
                } else if (input[i] >= 'A' && input[i] <= 'Z') {
                    while (i < input.Length &&
                            (input[i] >= 'A' && input[i] <= 'Z' ||
                            input[i] >= 'a' && input[i] <= 'z')) {
                        tokenbuilder.Append(input[i]);
                        i++;
                    }

                    Token t = new('F', tokenbuilder.ToString());
                    tokens.Add(t);
                } else if (input[i] == '(') {
                    i++;
                    while (input[i] != ')') {
                        tokenbuilder.Append(input[i]);
                        i++;
                    }

                    Token t = new('E', tokenbuilder.ToString());
                    tokens.Add(t);
                } else {
                    i++;
                }
            }

            return tokens.ToArray();
        }
    }
}
