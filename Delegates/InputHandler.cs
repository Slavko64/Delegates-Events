using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class InputHandler
    {
        public InputHandler()
        {
            AddToCollector ToStringCollection = new AddToCollector(StringCollector.AddToStringCollector);
            AddToCollector ToAlphaNumbericCollection = new AddToCollector(AlphaNumbericCollector.AddToAlphaNumbericCollector);
            bool IsHasDigit;
            string str = Console.ReadLine();
            while(str != null)
            {
                IsHasDigit = false;
                 foreach (var item in str)
                     if(char.IsDigit(item) == true)
                        {
                            ToAlphaNumbericCollection(str);
                            IsHasDigit = true;
                            break;
                        }
                if (IsHasDigit == false)
                    ToStringCollection(str);
                str = Console.ReadLine();
            }
        }
    }
}
