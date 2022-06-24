using System;
using System.Collections.Generic;

namespace labaa_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Створити суперклас Транспортний засіб і підкласи
            //Автомобіль, Велосипед, Повозка, Одноколісний велосипед.
            //Підрахувати час і вартість перевезення пасажирів і 
            //вантажів кожним транспортним засобом.

            var car = new Car();
            var bike = new Bike();
            var wagon = new Wagon();
            var unicycle = new Unicycle();            

            string option;

            do
            {
                Console.WriteLine("1 - Car | 2 - Bike | 3 - Wagon | 4 - Unicycle");
                Console.Write("Choose the Vehicle to calculate: ");
                string vehicle = Console.ReadLine();
                Console.WriteLine();

                string length, passengers, weight;
                int checked_length = 0;

                switch (vehicle)
                {
                    case "1":
                        Console.Write("Enter Length(km.) to Get Time: ");
                        length = Console.ReadLine();
                        checked_length = car.Length_Check(length);
                        Console.WriteLine($"TIME: {car.GetTime(checked_length)}m.");
                        Console.WriteLine();

                        Console.Write("Enter count of passengers(p<5): ");
                        passengers = Console.ReadLine();
                        Console.WriteLine($"PRICE for PASSENGERS: {car.Passengers_Price(checked_length, car.Passengers_Check(passengers))}UAH.");
                        Console.WriteLine();

                        Console.Write("Enter weight of goods(g<21kg.): ");
                        weight = Console.ReadLine();
                        Console.WriteLine($"PRICE for GOODS: {car.Goods_Price(car.Weight_Check(weight))}UAH.\n");


                        break;
                    case "2":
                        Console.Write("Enter Length(km.) to Get Time: ");
                        length = Console.ReadLine();
                        checked_length = bike.Length_Check(length);
                        Console.WriteLine($"TIME: {bike.GetTime(checked_length)}m.");
                        Console.WriteLine();

                        Console.Write("Enter count of passengers(p<3): ");
                        passengers = Console.ReadLine();
                        Console.WriteLine($"PRICE for PASSENGERS: {bike.Passengers_Price(checked_length, bike.Passengers_Check(passengers))}UAH.");
                        Console.WriteLine();

                        Console.Write("Enter weight of goods(g<11kg.): ");
                        weight = Console.ReadLine();
                        Console.WriteLine($"PRICE for GOODS: {bike.Goods_Price(bike.Weight_Check(weight))}UAH.\n");


                        break;
                    case "3":
                        Console.Write("Enter Length(km.) to Get Time: ");
                        length = Console.ReadLine();
                        checked_length = wagon.Length_Check(length);
                        Console.WriteLine($"TIME: {wagon.GetTime(checked_length)}m.");
                        Console.WriteLine();

                        Console.Write("Enter count of passengers(p<8): ");
                        passengers = Console.ReadLine();
                        Console.WriteLine($"PRICE for PASSENGERS: {wagon.Passengers_Price(checked_length, wagon.Passengers_Check(passengers))}UAH.");
                        Console.WriteLine();

                        Console.Write("Enter weight of goods(g<16kg.): ");
                        weight = Console.ReadLine();
                        Console.WriteLine($"PRICE for GOODS: {wagon.Goods_Price(wagon.Weight_Check(weight))}UAH.\n");


                        break;
                    case "4":
                        Console.Write("Enter Length(km.) to Get Time: ");
                        length = Console.ReadLine();
                        checked_length = unicycle.Length_Check(length);
                        Console.WriteLine($"TIME: {unicycle.GetTime(checked_length)}m.");
                        Console.WriteLine();

                        Console.Write("Enter count of passengers(p<2): ");
                        passengers = Console.ReadLine();
                        Console.WriteLine($"PRICE for PASSENGERS: {unicycle.Passengers_Price(checked_length, unicycle.Passengers_Check(passengers))}UAH.");
                        Console.WriteLine();

                        Console.Write("Enter weight of goods(g<9kg.): ");
                        weight = Console.ReadLine();
                        Console.WriteLine($"PRICE for GOODS: {unicycle.Goods_Price(unicycle.Weight_Check(weight))}UAH.\n");


                        break;
                }

                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("1 - Calculate | 2 - Exit");
                option = Console.ReadLine();
                Console.Clear();

                Console.ReadLine();
            }
            while (option != "2");
        }
    }
}
