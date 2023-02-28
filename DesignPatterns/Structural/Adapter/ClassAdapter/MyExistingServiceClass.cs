using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.ClassAdapter
{
    public class MyExistingServiceClass
    {
        public void show()
        {
            Console.WriteLine("Inside Service method show()");
        }
    }
}
