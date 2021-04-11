using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_5
{
    abstract class Garage
    {
        protected CarWash moika;
        public string _name { get; set; }
        public int _count  { get; set;}
        public Washing get_washer()
        {
            return this.moika.Wash;
        }
        
    }

    class Romashka : Garage
    {
       public Romashka()
       {
            this._name = "Ромашка";
            this._count = 2;
            this.moika = new Shilo();
       }
    }

    class Lutik : Garage
    {
        public Lutik()
        {
            this._name = "Лютик";
            this._count = 1;
            this.moika = new Shilo();
        }
    }

    class Oduvanchik : Garage
    {
        public Oduvanchik()
        {
            this._name = "Одуванчик";
            this._count = 2;
            this.moika = new Mylo();
        }
    }
}
