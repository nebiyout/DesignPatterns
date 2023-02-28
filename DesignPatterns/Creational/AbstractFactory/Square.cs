﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Square : IAbstractShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Square");
        }
    }
}
