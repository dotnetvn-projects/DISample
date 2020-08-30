using DISample.Mobile;
using System;
using System.Collections.Generic;
using System.Text;

namespace DISample.Battery.Interfaces
{
    interface IBattery
    {
        BatteryInfo BatteryInfo { get; set; }
        bool IsSupport(MobilePhone mobile);
    }
}
