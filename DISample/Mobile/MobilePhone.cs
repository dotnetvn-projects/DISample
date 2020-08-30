using DISample.Battery.Interfaces;

namespace DISample.Mobile
{
    internal abstract class MobilePhone
    {
        public MobilePhoneManufacture Manufacture { get; }
        public IBattery Battery { get; }

        public MobilePhone(IBattery battery, MobilePhoneManufacture manufacture)
        {
            Battery = battery;
            Manufacture = manufacture;
        }

        public abstract void TryReplaceBattery();
    }
}