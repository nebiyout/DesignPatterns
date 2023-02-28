using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class RoundedFactory : IAbstractFactory
    {
        public IAbstractShape getShape(string type)
        {
            switch(type.ToLower())
            {
                case "square":
                    return new RoundedSquare();

                case "rectangle":
                    return new RoundedRectangle();

                default:
                    return null;
            }
        }
    }
}
