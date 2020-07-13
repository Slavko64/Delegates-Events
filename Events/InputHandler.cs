using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    delegate void AddToCollector(string str);
    class InputHandler
    {
        public event AddToCollector AddingToAlphaNumericCollector;
        public event AddToCollector AddingToStringCollector;
        public InputHandler()
        {
            bool IsHasDigit;
            string str = Console.ReadLine();
            while (str != null)
            {
                IsHasDigit = false;
                foreach (var item in str)
                    if (char.IsDigit(item) == true)
                    {
                        AddingToAlphaNumericCollector += new AddToCollector(AlphaNumbericCollector.AddToAlphaNumbericCollector);
                        AddingToAlphaNumericCollector(str);
                        AddingToAlphaNumericCollector -= new AddToCollector(AlphaNumbericCollector.AddToAlphaNumbericCollector);
                        IsHasDigit = true;
                        break;
                    }
                if (IsHasDigit == false)
                {
                    AddingToStringCollector += new AddToCollector(StringCollector.AddToStringCollector);
                    AddingToStringCollector(str);
                    AddingToStringCollector -= new AddToCollector(StringCollector.AddToStringCollector);
                }
                str = Console.ReadLine();
            }
        }
    }
}
