using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class Singleton
    {
        private static Singleton singleton = null;
        private static readonly Object obj = new object();

        private Singleton() { }

        public static Singleton GetSingleton()
        {
            lock (obj)
            {
                if (singleton == null)
                    singleton = new Singleton();
            }

            return singleton;
        }
    }
}
