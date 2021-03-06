// Copyright (c) 2014-2017 Silicon Studio Corp. All rights reserved. (https://www.siliconstudio.co.jp)
// See LICENSE.md for full license information.
using GoldParser;

using Irony.Parsing;

namespace SiliconStudio.Shaders.Grammar
{
    internal class NamedBlockKeyTerm : DynamicKeyTerm
    {
        public NamedBlockKeyTerm(string text, string name)
            : base(text, name)
        {
        }

        public override void Match(Tokenizer toknizer, out Token token)
        {
            var parser = toknizer.GoldParser;

            var location = toknizer.Location;
            var nextSymbol = parser.ReadToken();

            while (nextSymbol.SymbolType == SymbolType.WhiteSpace || nextSymbol.Index == (int)TokenType.NewLine)
                nextSymbol = parser.ReadToken();

            if (nextSymbol.Index != (int)TokenType.LeftCurly)
            {
                token = new Token(Grammar.SyntaxError, location, parser.TokenText, "Expecting '{'");
                return;
            }

            var startPosition = parser.CharPosition;

            bool rightCurlyFound = false;
            int length = 0;
            for (int i = parser.CharPosition; i < parser.TextBuffer.Length; i++, length++)
            {
                if (parser.TextBuffer[i] == '}')
                {
                    rightCurlyFound = true;
                    break;
                }
            }

            if (!rightCurlyFound)
            {
                token = new Token(Grammar.SyntaxError, location, parser.TokenText, "Closing '}' not found");
                return;                
            }

            token = new Token(this, location, parser.TextBuffer.Substring(startPosition, length), null);

            // Move the parser
            parser.MoveBy(length+1);
        }
    }
}
