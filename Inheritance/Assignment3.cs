using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public interface IPrintable
    {
        void Print();
    }
    public interface IScannable
    {
        void Scan();
    }
    public class PrinterScanner : IPrintable, IScannable
    {
        public void Print()
        {
            Console.WriteLine("Printing document");
        }
        public void Scan()
        {
            Console.WriteLine("Scanning document");
        }
    }
}
