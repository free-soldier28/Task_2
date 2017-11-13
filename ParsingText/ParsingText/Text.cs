using System;
using System.Collections.Generic;
using System.Linq;
using ParsingText.Interface;
using System.Text.RegularExpressions;

namespace ParsingText
{
    public class Text : Proposal, IParsable<Proposal>
    {
        private List<Proposal> proposals = new List<Proposal>();


        public Text()
        {

        }


        public Text(string value)
        {
            Value = value;
        }


        public List<Proposal> GetText()
        {
            return proposals;
        }


        public int GetCountProposal()
        {
            return proposals.Count;
        }


        public void PrintText()
        {
            int i = 0;
            foreach (var proposal in proposals)
            {
                i++;
                Console.WriteLine(i + ") " + proposal.Value);
            }
        }

        public List<Proposal> Parse()
        {
            string pattern = "([А-ЯA-Z].*?\\. | [А-ЯA-Z].*?\\! | [А-ЯA-Z].*?\\?)";
            //string pattern = "(\\.\s*[A-ZА-Я])";
            string[] substrings = Regex.Split(Value, pattern);

            foreach (string match in substrings)
            {
                if (match.Any())
                {
                    proposals.Add(new Proposal(match.Trim()));
                }
            }

            return proposals;
        }

    }
}
