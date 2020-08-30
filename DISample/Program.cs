using DISample.Battery;
using DISample.Battery.Interfaces;
using DISample.DIContainer;
using DISample.Mobile;
using System;

namespace DISample
{
    class Program
    {
        static IDIContainer _dIContainer = RegisterDI();

        static void Main(string[] args)
        {

            MobilePhone phone = new AsusPhone(new SamsungBattery());
            phone.TryReplaceBattery();

            Console.WriteLine(" ");

            phone = new IPhoneX(new SamsungBattery());
            phone.TryReplaceBattery();

            //IBattery battery = _dIContainer.Resolve<ISamsungBattery>();

            //MobilePhone phone = new AsusPhone(battery);
            //phone.TryReplaceBattery();

            //Console.WriteLine(" ");

            //phone = new IPhoneX(battery);
            //phone.TryReplaceBattery();
        }

        static IDIContainer RegisterDI()
        {
            IDIContainer container = new MyDIContainer();
            container.Register<ISamsungBattery, SamsungBattery>();
            return container;
        }
    }
}
