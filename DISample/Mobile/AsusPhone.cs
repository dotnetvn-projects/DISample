using DISample.Battery.Interfaces;
using System;

namespace DISample.Mobile
{
    internal class AsusPhone : MobilePhone
    {
        public AsusPhone(IBattery battery) : base(battery, MobilePhoneManufacture.ASUS)
        {
        }

        public override void TryReplaceBattery()
        {
            if (Battery.IsSupport(this))
            {
                Console.WriteLine($"Yeah (-_-), the battery of '{Battery.BatteryInfo.Manufacturer}' can be used for your Asus Phone");
            }
            else
            {
                Console.WriteLine($"Oh Man >.<, the battery of '{Battery.BatteryInfo.Manufacturer}' can not be used for your Asus Phone");
            }
        }
    }
}