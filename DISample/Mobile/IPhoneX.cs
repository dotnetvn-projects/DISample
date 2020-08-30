using DISample.Battery.Interfaces;
using System;

namespace DISample.Mobile
{
    internal class IPhoneX : MobilePhone
    {
        public IPhoneX(IBattery battery) : base(battery, MobilePhoneManufacture.IPHONE)
        {
        }

        public override void TryReplaceBattery()
        {
            if (Battery.IsSupport(this))
            {
                Console.WriteLine($"Yeah (-_-), the battery of '{Battery.BatteryInfo.Manufacturer}' can be used for your IPhoneX");
            }
            else
            {
                Console.WriteLine($"Oh Man >.<, the battery of '{Battery.BatteryInfo.Manufacturer}' can not be used for IPhoneX");
            }
        }
    }
}