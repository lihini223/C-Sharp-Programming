using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class FindValues
    {
        
        public double FindArea(double radius)
        {
            double area = radius * radius * 3.14;
            return area;
        }
      
        public double FindCircumference(double radius)
        {
            double circumference = 2 * radius * 3.14;
            return circumference;
        }
    }
}

