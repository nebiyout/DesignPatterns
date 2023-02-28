﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class SecureNestProxy : INest
    {
        private readonly INest nest;

        public SecureNestProxy(INest nest)
        {
            this.nest = nest;
        }

        public void Access(string name)
        {
            if (name == "TRex" || name == "Gigantosaurus")
            {
                throw new UnauthorizedAccessException($"{name} is not allowed to access the nest.");
            }
            else
            {
                this.nest.Access(name);
            }
        }
    }
}
