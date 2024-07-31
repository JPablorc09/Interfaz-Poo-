using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploInterfaz
{
    //es como un contrato se deben implementar si o si estos metodos o los que allan en una clase interface
    interface IFigura
    {
        //no se ponen atributos porque para el area y el perimetro son diferentes para las figuras geometricas
        decimal Area();
        decimal perimetro();
    }
}
