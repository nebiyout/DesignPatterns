using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.ObjectAdapter
{
    public class Client
    {
        private ITarget target;

        public Client(ITarget target)
        {
            this.target = target;
        }

        public void MakeRequest()
        {
            target.MethodA();
        }
    }

}
