using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Func_Predicate
{
    class InputHandler
    {
        Predicate<string> IsHasDigit = delegate (string str)
        {
            foreach (var item in str)
                if (char.IsDigit(item) == true)
                {
                    return true;
                }
            return false;
        };
        public InputHandler()
        {
            Action<string> action;
            string str = Console.ReadLine();
            while (str != null)
            {
                if (IsHasDigit(str) == true)
                    action = AlphaNumbericCollector.AddToAlphaNumbericCollector;
                else
                    action = StringCollector.AddToStringCollector;
                action(str);
                str = Console.ReadLine();
            }
        }
    }
}
