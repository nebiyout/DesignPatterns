using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device) { }

        public void mute()
        {
            device.setVolume(0);
        }
    }
}
