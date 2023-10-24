using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_QGJ
{
    //------------------------------------------------------------------------
    //Clase que representa un Rectangulo.
    //QGJ. 14/03/2023
    //------------------------------------------------------------------------
    public class CRectangulo : CCuadrilatero
    {
        //------------------------------------------------------------------------
        //Atributos.
        //------------------------------------------------------------------------


        //------------------------------------------------------------------------
        //Contructor.
        //------------------------------------------------------------------------
        public CRectangulo(Color Color, double Lado1, double Lado2) : 
            base(Color, "Rectangulo", Lado1, Lado2)
        {
            
        }
    }
}
