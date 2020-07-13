using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Func_Predicate
{
    class StringCollector
    {
        static List<string> StringCollection = new List<string>();
        static public void AddToStringCollector(string str) => StringCollection.Add(str);
    }
}
