using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class CalculateValues
    {
        public double Addition(double n1, double n2)
        {
            double total;
            total = n1 + n2;
            return total; 
        }

        public double Substraction(double n1, double n2)
        {
            double sub;
            sub = n1 - n2;
            return sub;
        }

        public double Multiplication(double n1, double n2)
        {
            double product;
            product = n1 * n2;
            return product;
        }

        public double Division(double n1, double n2)
        {
            double div;
            div = n1 / n2;
            return div;
        }
    }
}
