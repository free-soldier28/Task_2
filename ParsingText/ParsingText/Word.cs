using System;
using System.Collections.Generic;
using ParsingText.Interface;

namespace ParsingText
{
    public class Word: Symbol
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

        public void parse(string word)
        {
            foreach (var symbol in word)
            {
                symbols.Add(new Symbol(symbol));
            }  
        }
    }
}
