using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingText.Interface
{
    internal interface IParsable<T>
    {
        List<T> Parse();
    }
}
