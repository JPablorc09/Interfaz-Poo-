using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaz
{
    class Cuadrado : IFigura
    {
       private int lado;

        public Cuadrado(int lado)
        {
            this.lado = lado;
        }

        public decimal Area()
        {
           return lado* lado;
        }

        public decimal perimetro()
        {
            return lado * 4;
        }
    }
}
