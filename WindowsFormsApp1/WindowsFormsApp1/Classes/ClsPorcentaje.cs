using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class ClsPorcentaje
    {
        public double Porcentaje(double num1, double num2)
        {
            double P;
            P = (num1/100)*num2;
            return P;
        }
    }
}
