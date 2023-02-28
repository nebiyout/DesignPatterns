using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }
}
