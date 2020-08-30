using DISample.Battery.Interfaces;
using DISample.Mobile;

namespace DISample.Battery
{
    internal class SamsungBattery : ISamsungBattery
    {
        public BatteryInfo BatteryInfo { get; set; }

        public SamsungBattery()
        {
            BatteryInfo = new BatteryInfo
            {
                Manufacturer = BatteryManufacture.SamSung,
                ChargeTime = "2h",
                UseTime = "16h"
            };
        }

        public bool IsSupport(MobilePhone mobile)
        {
            return mobile.Manufacture == MobilePhoneManufacture.SAMSUNG
                || mobile.Manufacture == MobilePhoneManufacture.ASUS;
        }
    }
}