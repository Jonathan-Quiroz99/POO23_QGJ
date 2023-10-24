using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_QGJ
{
    //------------------------------------------------------------------------
    //Clase que representa un triangulo Isoceles.
    //QGJ. 30/03/2023
    //------------------------------------------------------------------------
    public class CTrianguloIsoceles : CTriangulo
    {
        //------------------------------------------------------------------------
        //Atributos.
        //------------------------------------------------------------------------


        //------------------------------------------------------------------------
        //Contructor.
        //------------------------------------------------------------------------
        public CTrianguloIsoceles(Color Color, double Base, double Altura) : 
            base(Color, Base, Altura, "Triangulo Isoceles")
        {

        }
    }
}
