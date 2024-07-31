using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaz
{
    class TrianguloRectangulo : IFigura
    {
        int ladoA; int ladoB; decimal hipotenusa;

        
        private decimal CalcularHipotenusa(int bas,int altura)    
        {
            return Convert.ToDecimal(Math.Sqrt((double)(ladoA * ladoA + ladoB * ladoB)));
        }
        //constructor
        public TrianguloRectangulo(int ladoA, int ladoB)
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.hipotenusa = CalcularHipotenusa(ladoA,ladoB);
        }

        public decimal Area()
        {
            return ladoA * ladoB / 2;
        }

        public decimal perimetro()
        {
            return ladoA+ladoB+hipotenusa;
        }
    }
}
