using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class Invoice
    {
        public void Sendinvoice()
        {
            Console.WriteLine("Invoice Send Successfully");
        }
    }
}
