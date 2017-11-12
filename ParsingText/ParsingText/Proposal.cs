using System;
using ParsingText.Interface;
using System.Collections.Generic;

namespace ParsingText
{
    public class Proposal: Word, IParsable
    {
        //private LinkedList<PunctuationMark> punctuationMark = new LinkedList<PunctuationMark>();
        private List<Word> words = new List<Word>();

        public Proposal()
        {
        }

        public Proposal(string value)
        {
            Value = value;
        }

        public List<Word> GetProposal()
        {
            return words;
        }

        public void AddWord(string value)
        {
            words.Add(new Word(value));
        }
        public void PrintProposal()
        {
            foreach (var word in words)
            {
                Console.WriteLine(word.Value);
            }
        }

        public int GetCountWords()
        {
            return words.Count;
        }

        public void Parse(string value)
        {
            PunctuationMark _punctuationMarks = new PunctuationMark();
            string[] arrayWords = value.Split(_punctuationMarks.GetPunctuationMark(), StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in arrayWords)
            {
                words.Add(new Word(word));
            }

        }

    }
}
