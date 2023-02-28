using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class AbstractFactory
    {
        public static IAbstractFactory GetShapeFactory(bool isRounded)
        {
            if (isRounded)
                return new RoundedFactory();
            else
                return new StandardFactory();
        }
    }
}
