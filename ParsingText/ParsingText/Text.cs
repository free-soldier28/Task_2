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
            foreach (var proposal in proposals)
            {
                Console.WriteLine(proposal.Value);
            }
        }

        public List<Proposal> Parse()
        {
            string pattern = "([А-ЯA-Z].*?\\. | [А-ЯA-Z].*?\\! | [А-ЯA-Z].*?\\?)";
            string[] substrings = Regex.Split(Value, pattern);

            foreach (string match in substrings)
            {
                proposals.Add(new Proposal(match.Trim()));
            }

            return proposals;
        }


        //public LinkedList<Proposal> Parse(string value)
        //{
        //    string[] arrayProposals = value.Split(new[] { ".", "?", "!", "..." }, StringSplitOptions.RemoveEmptyEntries);

        //    foreach (var proposal in arrayProposals)
        //    {
        //        proposals.AddLast(new Proposal(proposal.Trim('\n')));
        //    }

        //    return proposals;
        //}

    }
}
