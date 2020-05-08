using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Impl;

namespace Polymorphism
{
    public class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon display dimension : 10*11");
        }

        
        
    }
}
