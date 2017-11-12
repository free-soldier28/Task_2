using System;
using System.IO;
using System.Text;
using ParsingText;

namespace WorkWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            Proposal proposal = new Proposal();
            Word word = new Word();

            using (StreamReader file = new StreamReader("TextFile.txt", Encoding.Default))
            {
                text.Value = file.ReadToEnd();  
            }

            text.Parse(text.Value);
            

            //text.PrintProposals((text.Parse(text.Value)));
            text.Parse(text.Value);
            //text.PrintProposals(text.GetProposals());
           //text.OffersInAscendingOrder();
           text.InterrogativeSentences(4);



            Console.ReadKey();
        }
    }
}
