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
            double kilometer;

            Console.WriteLine("Convert Kilometers to meters");
            
            Console.Write("Enter Kilometers to convert:");
            kilometer = Convert.ToDouble(Console.ReadLine());

            ConvertValues convertKM = new ConvertValues();
            convertKM.KilometerToMeter(kilometer);
           
            Console.ReadKey();
        }
    }
}

