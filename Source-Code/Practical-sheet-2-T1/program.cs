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
            ConvertValues convertKM = new ConvertValues();
            convertKM.KilometerToMeter();
            Console.ReadKey();
        }
    }
