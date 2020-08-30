using DISample.Battery;
using DISample.Battery.Interfaces;
using DISample.DIContainer;
using DISample.Mobile;
using System;

namespace DISample
{
    internal class Program
    {
        private static IDIContainer _dIContainer = RegisterDI();

        private static void Main(string[] args)
        {
            //IBattery battery = new SamsungBattery();

            //MobilePhone phone = new AsusPhone(battery);
            //phone.TryReplaceBattery();

            //Console.WriteLine(" ");

            //phone = new IPhoneX(battery);
            //phone.TryReplaceBattery();

            IBattery battery = _dIContainer.Resolve<ISamsungBattery>();

            MobilePhone phone = new AsusPhone(battery);
            phone.TryReplaceBattery();

            Console.WriteLine(" ");

            phone = new IPhoneX(battery);
            phone.TryReplaceBattery();
        }

        private static IDIContainer RegisterDI()
        {
            IDIContainer container = new MyDIContainer();
            container.Register<ISamsungBattery, SamsungBattery>();
            return container;
        }
    }
}