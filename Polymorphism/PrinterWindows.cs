using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class PrinterWindows
    {
        public string nama = "Printer";
        public string dimensi = "15x15";

        public virtual void Show()
        {
            Console.WriteLine(nama + " Display Dimension : " + dimensi);
        }
        public virtual void Print()
        {
            Console.WriteLine(nama + " Printer Printing....");
        }
    }
}
