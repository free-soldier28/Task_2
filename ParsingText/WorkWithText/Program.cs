using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
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

            List<Proposal> Proposals = text.Parse();
            text.PrintText();

            //Console.WriteLine();
            //OffersInAscendingOrder(Proposals);

            Console.WriteLine();
            InterrogativeSentences(Proposals, 4);

            //Console.WriteLine();
            //text.PrintText();




            // Вывод предложений в порятке возрастания количества слов
            void OffersInAscendingOrder(List<Proposal> _poposals)
            {
                var proposals = _poposals;
                if (proposals.Any())
                {
                    var temp = proposals.OrderBy(x => x.Parse().Count());

                    foreach (var tempProposal in temp)
                    {
                        Console.WriteLine(tempProposal.Value);
                    }
                }
            }


            // Вывод слов без повторений заданной длины в вопросительных предложениях 
            void InterrogativeSentences(List<Proposal> _proposals, int _length)
            {
                var proposals = _proposals;

                foreach (var proposal in proposals.Where(x => x.Value.Contains("?")))
                {
                    var words = proposal.Parse();
                    var temp = words.GroupBy(x => x.Value).Where(x => x.Key.Length == _length);

                    foreach (var word in temp)
                    {
                        Console.WriteLine(word.Key);
                    }
                }
            }


            Console.ReadKey();
        }
    }
}
