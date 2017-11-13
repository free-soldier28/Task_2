using System;
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

            //text.Parse();
            //text.PrintText();

            //OffersInAscendingOrder(text.Parse());
            InterrogativeSentences(text.Parse(), 4);



            // Вывод предложений в порятке возрастания количества слов
            void OffersInAscendingOrder(List<Proposal> Proposals)
            {
                if (Proposals.Any())
                {
                    var proposals = Proposals.OrderBy(x => x.Parse().Count());

                    foreach (var proposal in proposals)
                    {
                        Console.WriteLine(proposal.Value);
                    }
                }
            }


            // Вывод слов без повторений заданной длины в вопросительных предложениях 
            void InterrogativeSentences(List<Proposal> Proposals, int length)
            {
                var proposals = Proposals.Where(x => x.Value.Contains("?"));

                foreach (var proposal in proposals)
                {
                    var words = proposal.Parse();
                    words.Where(x => x.GetCountSymbol() == length).GroupBy(z => z.Value);

                    foreach (var word in words)
                    {
                        Console.WriteLine(word.Value);
                    }
                }

            }


            Console.ReadKey();
        }
    }
}
