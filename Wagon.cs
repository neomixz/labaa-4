using System;
using System.Collections.Generic;
using System.Text;

namespace labaa_2._4
{
    class Wagon : Vehicle //Кибитка
    {
        private protected override double Speed => 12;
        private protected override double km_Price => 5.5;
        private protected override double kg_Price => 15;
        public int Passengers_Check(string passengers)
        {
            bool int_check = false;
            int checked_passengers = 0;
            do
            {
                int_check = int.TryParse(passengers, out checked_passengers);
                if (int_check == false || checked_passengers > 7)
                {
                    Console.Write("Passengers: ");
                    passengers = Console.ReadLine();
                }
            }
            while (int_check != true || checked_passengers > 7); ;

            return checked_passengers;
        }
        public int Weight_Check(string weight)
        {
            bool int_check = false;
            int checked_weight = 0;
            do
            {
                int_check = int.TryParse(weight, out checked_weight);
                if (int_check == false || checked_weight > 15)
                {
                    Console.Write("Weight: ");
                    weight = Console.ReadLine();
                }
            }
            while (int_check != true || checked_weight > 15);

            return checked_weight;
        }
    }
}
