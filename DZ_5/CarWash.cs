using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_5
{
    abstract class CarWash
    {
        public string _nazvanie { get; set; }
        public int _price { get; set; }
        public  void Wash()
        {
            Console.WriteLine($" помыта на автомойке {_nazvanie} за цену {_price} ");
        }

    };
    class Shilo : CarWash
    {
        public Shilo()
        {
            this._nazvanie = "Шило";
            this._price = 450;
        }
    }

    class Mylo : CarWash
    {
        public Mylo()
        {
            this._nazvanie = "Мыло";
            this._price = 510;
        }
           }
}
