using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPhone> phone = new List<IPhone>();

            phone.Add(new SmartPhone()
            { Model = "Samsung Galaxy S20", OC = "Android", CameraResolutuion = 56, Color = "черный", Memory = 256 });

            phone.Add(new SmartPhone()
            { Model = "Huawei P30", OC = "Android", CameraResolutuion = 40, Color = "синий", Memory = 512 });

            phone.Add(new SmartPhone()
            { Model = "IPhone 12", OC = "IOS", CameraResolutuion = 36, Color = "фиолетовый", Memory = 128 });

            foreach (var phones in phone)
            {
                Console.WriteLine($"\nМодель: {phones.Model}");
                phones.SendMessage();
                phones.Call();

                if (phones is SmartPhone)
                {
                    SmartPhone smartPhone = (SmartPhone)phones;
                    smartPhone.TakePhoto();
                    smartPhone.PlayGames();
                }

                Console.WriteLine();
            }
        }
    }
}
