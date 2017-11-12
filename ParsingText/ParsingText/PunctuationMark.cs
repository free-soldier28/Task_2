using System.Linq;

namespace ParsingText
{
    public class PunctuationMark: Symbol
    {
        private char[] marks = new char[] { ' ', '.', ',', '!', '?', ':', ';', '-', '(', ')', '«', '»'};

        public PunctuationMark()
        {

        }

        public char[] GetPunctuationMark()
        {
            return marks;
        }
    }
}
