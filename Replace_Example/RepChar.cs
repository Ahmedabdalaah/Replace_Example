using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace_Example
{
    internal class RepChar
    {
        public string replace(string original, char old, char neww)
        {
            string output = original.Replace(old, neww);
            return output;
        }
    }
}
