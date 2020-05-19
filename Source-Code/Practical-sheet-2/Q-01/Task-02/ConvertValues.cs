using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiloMeter_to_Meter
{
    class ConvertValues
    {
        public void KilometerToMeter(double km)
        {
            double meter;

            meter = km * 1000;

            Console.WriteLine("{0} km = {1} m", km, meter);

        }
    }
}

