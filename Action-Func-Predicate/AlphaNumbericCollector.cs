using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Func_Predicate
{
    class AlphaNumbericCollector
    {
        static List<string> AlphaNumbericCollection = new List<string>();
        static public void AddToAlphaNumbericCollector(string str) => AlphaNumbericCollection.Add(str);
    }
}
