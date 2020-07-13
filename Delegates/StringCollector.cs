using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class StringCollector
    {
        static List<string> StringCollection = new List<string>();
        static public void AddToStringCollector(string str) => StringCollection.Add(str);
    }
}
