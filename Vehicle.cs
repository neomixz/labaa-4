using System;
using System.Collections.Generic;
using System.Text;

namespace labaa_2._4_RW
{
    abstract class Vehicle
    {
        public string Name;
        public double Speed { get; set; }
        private protected double km_Price { get; set; }
        private protected double kg_Price { get; set; }

        public int GetTime(int length)
        {
            return Convert.ToInt32(Math.Round((length / Speed) * 60.0));
        }
        public int Passengers_Price(int length, int passengers)
        {
            return Convert.ToInt32(Math.Round(km_Price * length * passengers));
        }
        public int Goods_Price(int weight)
        {
            return Convert.ToInt32(Math.Round(kg_Price * weight));
        }
    }
}
