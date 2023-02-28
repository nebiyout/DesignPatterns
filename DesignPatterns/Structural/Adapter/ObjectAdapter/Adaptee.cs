using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.ObjectAdapter
{
    public class Adaptee
    {
        public void MethodB()
        {
            Console.WriteLine("MethodB() is called");
        }
    }
}
