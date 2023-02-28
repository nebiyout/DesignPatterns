using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public interface IDevice
    {
       bool isEnabled();
       void enable();
       void disable();
       int getVolume();
       void setVolume(int percent);
       int getChannel();
       void setChannel(int channel);
    }
}
