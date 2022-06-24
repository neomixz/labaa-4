using System;
using System.Collections.Generic;

namespace labaa_2._4_RW
{
    class Program
    {
        static void Main(string[] args)
        {
            var garage = new Garage()
            {
                vehicles = new List<Vehicle> { new Car("BMW", 110, 1.8, 20), new Bike("CUBE", 20, 16.6, 29),
                             new Wagon("Non-Stop Povozka", 12, 5.5, 15), new Unicycle("Tsyrk Unicycle", 14, 30, 15), 
                                new Car("Mustang", 220, 2.9, 15), new Bike("Ukrayina", 55, 20, 35),
                                new Wagon("Kin' veze", 17, 7.6, 19), new Unicycle("One koleso", 34, 50, 23)
                }
            };



            //foreach (var item in garage.vehicles)
            //{
            //    Console.WriteLine(item.Name);
            //
            //    Console.Write("Enter Route's Length(km.): ");
            //    int lenth = int.Parse(Console.ReadLine());
            //    Console.WriteLine("TIME: " + item.GetTime(lenth) + "m.");
            //
            //    Console.Write("Enter Passengers' Count: ");
            //    int passengers = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Price for Passengers: " + item.Passengers_Price(lenth, passengers) + "UAH");
            //
            //    Console.Write("Enter Goods' Weight(kg.): ");
            //    int weight = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Price for Goods: " + item.Goods_Price(weight) + "UAH\n");
            //}

            Console.ReadKey();

            garage.AverageSpeed();


            
        }
    }
}
