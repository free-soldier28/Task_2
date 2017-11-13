using System;
using ParsingText.Interface;
using System.Collections.Generic;

namespace ParsingText
{
    public class Proposal : Word, IParsable<Word>
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


        public List<Word> Parse()
        {
            PunctuationMark _punctuationMarks = new PunctuationMark();
            string[] arrayWords = Value.Split(_punctuationMarks.GetPunctuationMark(), StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in arrayWords)
            {
                words.Add(new Word(word));
            }

            return words;
        }

    }
}
