using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.ObjectAdapter
{
    public class Adapter : ITarget
    {
        private Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }
        public void MethodA()
        {
            _adaptee.MethodB();
        }
    }
}
