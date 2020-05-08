using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon display dimension : 9.5*12");
        }
    }
}
