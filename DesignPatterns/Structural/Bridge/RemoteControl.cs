using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class RemoteControl
    {
        protected IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }
        public void togglePower()
        {
            if (device.isEnabled())
                device.disable();
            else
                device.enable();
        }

        public void volumeDown()
        {
            device.setVolume(device.getVolume() - 10);
        }
        public void volumeUp()
        {
            device.setVolume(device.getVolume() + 10);
        }
        public void channelDown()
        {
            device.setChannel(device.getChannel() - 1);
        }
        public void channelUp()
        {
            device.setChannel(device.getChannel() + 1);
        }
    }
}
