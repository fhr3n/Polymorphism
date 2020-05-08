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
            Console.WriteLine("\nCanon Display Dimension : 9.5*12");
        }
        public override void Print()
        {
            Console.WriteLine("Canon Printer Printing....");
        }
    }
}
