using System;
using System.Collections.Generic;
using System.Text;

namespace labaa_2._4_RW
{
    class Unicycle : Vehicle
    {
        public Unicycle(string Name, double Speed, double km_Price, double kg_Price)
        {
            this.Name = Name;
            this.Speed = Speed;
            this.km_Price = km_Price;
            this.kg_Price = kg_Price;
        }
    }
}
