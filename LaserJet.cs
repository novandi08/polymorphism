using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon display dimension : 12*12");
        }
    }
}
