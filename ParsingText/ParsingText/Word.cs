using System;
using System.Collections.Generic;
using System.Threading;
using ParsingText.Interface;

namespace ParsingText
{
    public class Word : Symbol, IParsable<Symbol>
    {
        public string Value { get; set; } = null;

        private List<Symbol> symbols = new List<Symbol>();


        public Word()
        {

        }


        public Word(string value)
        {
            Value = value;
        }


        public List<Symbol> GetWord()
        {
            return symbols;
        }


        public int GetCountSymbol()
        {
            return symbols.Count;
        }


        public void PrintWord()
        {
            foreach (var symbol in symbols)
            {
                Console.WriteLine(symbol);
            }
        }


        public List<Symbol> Parse()
        {
            foreach (var symbol in Value)
            {
                symbols.Add(new Symbol(symbol));
            }

            return symbols;
        }
    }
}
