using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public class Factory
    {
        public static IShape getShape(string type)
        {
            switch(type.ToLower())
            {
                case "circle":
                    return new Square();

                case "rectangle":
                    return new Rectangle();

                default:
                    return null;
            }
        }
    }
}
