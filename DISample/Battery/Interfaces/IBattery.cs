using DISample.Mobile;

namespace DISample.Battery.Interfaces
{
    internal interface IBattery
    {
        BatteryInfo BatteryInfo { get; set; }

        bool IsSupport(MobilePhone mobile);
    }
}