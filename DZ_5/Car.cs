using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_5
{
    abstract class Car
    {
        protected Garage _garage;
        protected string  _brand {get;set;}
        protected string  _model {get;set;}
        protected string  _color {get;set;}
        protected string  _body {get;set;}
        public void wash()
        {
            Console.Write($"Машина {_brand} {_model} ");
            _wash();
        }
        protected void init(string brand, string model, string color, string body)
        {
            this._brand = brand;
            this._model = model;
            this._color = color;
            this._body = body;
            this._wash = _garage.get_washer();
        }
        public void show_info_car()
        {
            Console.WriteLine($"Марка: {_brand}, модель: {_model}.");
            Console.WriteLine($"Цвет кузова: {_color}.");
            Console.WriteLine($"Тип кузова: {_body}.");
            Console.WriteLine($"Гараж: {_garage._name}.");
            
        }
        protected Washing _wash;
        
    }
    public delegate void Washing();
    
    class Car1 : Car 
    {

        public Car1(string brand,string model,string color,string body)
        {
            this._garage = new Romashka();
            this.init(brand, model, color, body);
        }
    }
   
    class Car2 : Car
    {
        public Car2(string brand, string model, string color, string body)
        {
            
            this._garage = new Romashka();
            this.init(brand, model, color, body);
        }
    }
    class Car3 : Car
    {
        public Car3(string brand, string model, string color, string body)
        {
            
            this._garage = new Lutik();
            this.init(brand, model, color, body);
        }
    }
    class Car4 : Car
    {
        public Car4(string brand, string model, string color, string body)
        {
            
            this._garage = new Oduvanchik();
            this.init(brand, model, color, body);
        }
    }
    class Car5 : Car
    {

        public Car5(string brand, string model, string color, string body)
        {
           
            this._garage = new Oduvanchik();
            this.init(brand, model, color, body);
        }
    }
}
