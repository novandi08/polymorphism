using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class PrinterWindows
    {
        public string Namaprinter { get; set; }

        public virtual void Show()
        {
            Console.WriteLine();
        }
        public virtual void Print()
        {
            Console.WriteLine("Canon printer printing......");
        }
    }
}
