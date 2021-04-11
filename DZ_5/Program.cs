using System;

namespace DZ_5
{
    //Лукьянчикова Ульяна Алексеевна БСБО-15-18
    class Program
    {
        static void Main(string[] args)
        {
            Car1 a = new Car1("Ford", "Focus", "Белый", "Пикап");
            Car5 b = new Car5("Shevrolet", "Lachetti", "Черный", "Седан");
            Car3 c = new Car3("Bugatty", "Veron", "Розовый", "Спорткар");
            a.show_info_car();
            a.wash();
            b.wash();
            c.wash();
        }
    }
}
