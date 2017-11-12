using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingText
{
    public class Reader
    {
        private static string PathToFile { get; set; } = null;
        private string Text { get; set; } = null;
        private StreamReader sr;


        public Reader()
        {

        }

        public Reader(string path)
        {
            PathToFile = path;
        }

        public void SetReader(string PathToFile)
        { 
            sr = new StreamReader(PathToFile);

            sr.Close();
        }
    }
}
