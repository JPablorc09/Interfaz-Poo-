using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaz
{
    class Rectangulo : IFigura
    {
        private int largo;
        private int ancho;

        public Rectangulo(int ancho,int largo)
        {
            this.ancho = ancho;
            this.largo = largo;
        }

        public decimal Area()
        {
            return largo * ancho;
        }

        public decimal perimetro()
        {
            return 2*(largo+ancho);
        }
    }
}
