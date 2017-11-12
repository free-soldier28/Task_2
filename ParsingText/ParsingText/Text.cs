using System;
using System.Collections.Generic;
using System.Linq;
using ParsingText.Interface;
using System.Text.RegularExpressions;

namespace ParsingText
{
    public class Text: Proposal, IParsable
    {
        private List<Proposal> proposals = new List<Proposal>();
        public int Count { get; set; } = 0;

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

        public void PrintText(List<Proposal> value)
        {
            foreach (var proposal in value)
            {
                Console.WriteLine(proposal.Value);
            }
        }


        // Вывод предложений в порятке возрастания количества слов
        public void OffersInAscendingOrder()
        {
            var pr = proposals.OrderBy(x => x.GetCountWords());
            foreach (var propos in pr)
            {
               Console.WriteLine(propos.Value);
            }
        }

        // Вывод слов задданой длины в вопросительных предложениях 
        public void InterrogativeSentences(int length)
        {
           Proposal temp = new Proposal();

            foreach (var proposal in proposals)
            {
                if (proposal.Value.EndsWith("?"))
                {
                    proposal.Parse(proposal.Value);

                    foreach (var word in proposal.GetProposal())
                    {
                        if (word.GetCountSymbol() == length)
                        {
                            temp.AddWord(word.Value);
                        }
                    }
                    //temp.GetProposal().GroupBy(x => x.Value);
                    temp.PrintProposal();
                    temp = null;
                }
                
            }
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

        public void Parse(string value)
        {
            string pattern = "([А-ЯA-Z].*?\\. | [А-ЯA-Z].*?\\! | [А-ЯA-Z].*?\\?)";
            string[] substrings = Regex.Split(value, pattern);

            foreach (string match in substrings)
            {
                proposals.Add(new Proposal(match.Trim()));
                Count++;
            }
        }

    }
}
