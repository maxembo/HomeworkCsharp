using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public abstract class MobilePhone : IPhone
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int CameraResolutuion { get; set; }

        public void SendMessage()
        {
            Console.WriteLine("Отправляем сообщение");
        }

        public void Call()
        {
            Console.WriteLine("Звоним");
        }

        public abstract void ConnectToWiFi();

        public abstract void ConnectToBluetooth();


    }
}
