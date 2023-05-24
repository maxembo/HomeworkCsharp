using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class SmartPhone : MobilePhone
    {
        public int Memory { get; set; }
        public string OC { get; set; }

        public override void ConnectToBluetooth()
        {
            Console.WriteLine("Подключаемся к блютузу");
        }

        public override void ConnectToWiFi()
        {
            Console.WriteLine("Подключаемся к wi-fi");
        }

        public void TakePhoto()
        {
            Console.WriteLine("Cфотографируемся");
        }

        public void PlayGames()
        {
            Console.WriteLine("Играем в игры");
        }

    }
}
