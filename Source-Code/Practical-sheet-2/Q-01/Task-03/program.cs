using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiloMeter_to_Meter
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilometer,meter;

            Console.WriteLine("Convert Kilometers to meters");
            
            Console.Write("Enter Kilometers to convert:");
            kilometer = Convert.ToDouble(Console.ReadLine());
            
            ConvertValues convertKM = new ConvertValues();
            meter = convertKM.KilometerToMeter(kilometer);

            Console.WriteLine("{0} km = {1} m", kilometer,meter);


            Console.ReadKey();
        }
    }
}

