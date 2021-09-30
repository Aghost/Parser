using System;
using System.Text;
using System.Collections.Generic;

using static System.Console;

namespace Parser.Core.Types
{
    public struct Token {
        public char type { get; set; }
        public string tvalue { get; set;}

        public Token(char t, string v) {
            this.type = t;
            this.tvalue = v;
        }
    };
}
