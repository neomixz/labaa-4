using System;
using System.Collections.Generic;
using System.Text;

namespace labaa_2._4_RW
{
    class Garage
    {
        public List<Vehicle> vehicles { get; set; }

        public void AverageSpeed()
        {
            int speed1 = 0, speed2 = 0, speed3 = 0, speed4 = 0;
            int n1 = 0, n2 = 0, n3 = 0, n4 = 0;

            foreach (var item in vehicles)
            {
                Car car = item as Car;
                Bike bike = item as Bike;
                Wagon wagon = item as Wagon;
                Unicycle unicycle = item as Unicycle;

                if (car != null)
                {
                    speed1 += Convert.ToInt32(Math.Round(item.Speed));
                    n1 += 1;
                }
                else if (bike != null)
                {
                    speed2 += Convert.ToInt32(Math.Round(item.Speed));
                    n2 += 1;
                }
                else if (wagon != null)
                {
                    speed3 += Convert.ToInt32(Math.Round(item.Speed));
                    n3 += 1;
                }
                else if (unicycle != null)
                {
                    speed4 += Convert.ToInt32(Math.Round(item.Speed));
                    n4 += 1;
                }               
            }

            Console.WriteLine($"Average Cars's Speed: {speed1 / n1}"+
                              $"\nAverage Bikes's Speed: {speed2 / n2}" +
                              $"\nAverage Wagon's Speed: {speed3 / n3}" +
                              $"\nAverage Unicycle's Speed: {speed4 / n4}"
                              ); 
        }
        

    }
}
