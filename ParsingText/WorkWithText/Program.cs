using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ParsingText;

namespace WorkWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();

            using (StreamReader file = new StreamReader("TextFile.txt", Encoding.Default))
            {
                text.Value = file.ReadToEnd();
            }

            OffersInAscendingOrder(text.Parse());


            // Вывод предложений в порятке возрастания количества слов
            void OffersInAscendingOrder(List<Proposal> Proposals)
            {
                if (Proposals != null)
                {
                    var proposals = Proposals.OrderBy(x => x.Parse().Count());

                    foreach (var proposal in proposals)
                    {
                        Console.WriteLine(proposal.Value);
                    }
                }
            }


            // Вывод слов задданой длины в вопросительных предложениях 
            //void InterrogativeSentences(int length)
            //{
            //    Proposal temp = new Proposal();

            //    foreach (var proposal in proposals)
            //    {
            //        if (proposal.Value.EndsWith("?"))
            //        {
            //            proposal.Parse();

            //            foreach (var word in proposal.GetProposal())
            //            {
            //                if (word.GetCountSymbol() == length)
            //                {
            //                    temp.AddWord(word.Value);
            //                }
            //            }
            //            //temp.GetProposal().GroupBy(x => x.Value);
            //            temp.PrintProposal();
            //            temp = null;
            //        }

            //    }
            //}

            Console.ReadKey();
        }
    }
}
