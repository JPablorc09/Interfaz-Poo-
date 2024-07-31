using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFigura cuadrado = new Cuadrado(100);
            Console.WriteLine($"El area del cuadrado es {cuadrado.Area()}" +
                $"\n  y su perimetro es {cuadrado.perimetro()}");
            Console.ReadKey();

            IFigura triangulo = new TrianguloRectangulo(100,100);
            Console.WriteLine($"El area del Triangulo Rectangulo es {triangulo.Area()}" +
                $"\n  y su perimetro es {triangulo.perimetro()}");
            Console.ReadKey();

            IFigura rectangulo = new Rectangulo(5, 10);
            Console.WriteLine($"El area del Rectangulo es {rectangulo.Area()}" +
                $"\n  y su perimetro es {rectangulo.perimetro()}");
            Console.ReadKey();

            IFigura circulo = new Circulo(10);
            Console.WriteLine($"El area del Circulo es {circulo.Area()}" +
               $"\n  y su perimetro es {circulo.perimetro()}");
            Console.ReadKey();

        }
    }
}
