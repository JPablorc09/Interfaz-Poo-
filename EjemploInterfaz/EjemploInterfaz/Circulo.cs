using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaz
{
    class Circulo : IFigura
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public decimal Area()
        {
            return Convert.ToDecimal(Math.PI * Math.Pow(radio, 2));
        }

        public decimal perimetro()
        {
            return Convert.ToDecimal(2 * Math.PI * radio);
        }
    }
}
