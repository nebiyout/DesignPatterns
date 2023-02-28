using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class StandardFactory : IAbstractFactory
    {
        public IAbstractShape getShape(string type)
        {
            switch(type.ToLower())
            {
                case "square":
                    return new Square();

                case "rectangle":
                    return new Rectangle();

                default:
                    return null;
            }
        }
    }
}
