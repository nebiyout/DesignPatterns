using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class Tv : IDevice
    {
        private bool isDisabled = false;
        private int channel = -1;
        private int volume = 0;

        public void disable()
        {
            Console.WriteLine("Tv disabled");
            isDisabled = true;
        }

        public void enable()
        {
            Console.WriteLine("Tv enabled");
            isDisabled = false;
        }

        public int getChannel()
        {
            return channel;
        }

        public int getVolume()
        {
            return volume;
        }

        public bool isEnabled()
        {
            return !isDisabled;
        }

        public void setChannel(int channel)
        {
            this.channel = channel;
        }

        public void setVolume(int percent)
        {
            this.volume = percent;   
        }
    }
}
