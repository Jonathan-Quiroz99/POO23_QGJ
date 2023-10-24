using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_QGJ
{
    //------------------------------------------------------------------------
    //Clase que representa un triangulo equilatero.
    //QGJ. 30/03/2023
    //------------------------------------------------------------------------
    public class CTrianguloEquilatero : CTriangulo
    {
        //------------------------------------------------------------------------
        //Atributos.
        //------------------------------------------------------------------------


        //------------------------------------------------------------------------
        //Contructor.
        //------------------------------------------------------------------------
        public CTrianguloEquilatero(Color Color, double Base, double Altura) : 
            base(Color, Base, Altura, "Triangulo Equilatero")
        {

        }
    }
}
