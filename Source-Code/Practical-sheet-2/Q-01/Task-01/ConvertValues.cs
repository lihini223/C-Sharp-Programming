using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiloMeter_to_Meter
{
    class ConvertValues
    {
        public void KilometerToMeter()
        {
            double kilometer,meter;

            Console.WriteLine("Convert Kilometers to meters");

            Console.Write("Enter Kilometers to convert:");
            
            kilometer = Convert.ToDouble(Console.ReadLine());

            meter = kilometer * 1000;

            Console.WriteLine("{0} km = {1} m", kilometer, meter);

        }
    }
}
