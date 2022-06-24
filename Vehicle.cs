using System;
using System.Collections.Generic;
using System.Text;

namespace labaa_2._4
{
    abstract class Vehicle 
    {
        //Підрахувати час і вартість перевезення пасажирів і вантажів кожним транспортним засобом
        private protected virtual double Speed { get; }
        private protected virtual double km_Price { get; }
        private protected virtual double kg_Price { get; }
        public int GetTime(int length)
        {
            return Convert.ToInt32(Math.Round((length / this.Speed) * 60));
        }             
        public int Passengers_Price(int length, int passengers)
        {
            return (Convert.ToInt32(Math.Round(km_Price * length))) * passengers;
        }
        public int Goods_Price(int weight)
        {
            return Convert.ToInt32(Math.Round(kg_Price * weight));
        }

        public int Length_Check(string length)
        {
            bool int_check = false;
            int checked_length = 0;
            do
            {
                int_check = int.TryParse(length, out checked_length);
                if (int_check == false)
                {
                    Console.Write("Length: ");
                    length = Console.ReadLine();
                }
            }
            while (int_check != true);

            return checked_length;
        }
    }
}
