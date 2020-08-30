using DISample.Battery;
using DISample.Battery.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DISample.Mobile
{
    abstract class MobilePhone
    {
        public MobilePhoneManufacture Manufacture { get; }
        public IBattery Battery { get;}

        public MobilePhone(IBattery battery, MobilePhoneManufacture manufacture)
        {
            Battery = battery;
            Manufacture = manufacture;
        }

        public abstract void TryReplaceBattery();
    }
}
