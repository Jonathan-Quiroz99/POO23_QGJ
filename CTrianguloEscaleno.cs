using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_QGJ
{
    //------------------------------------------------------------------------
    //Clase que representa un triangulo escaleno.
    //QGJ. 30/03/2023
    //------------------------------------------------------------------------
    public class CTrianguloEscaleno : CTriangulo
    {
        //------------------------------------------------------------------------
        //Atributos.
        //------------------------------------------------------------------------


        //------------------------------------------------------------------------
        //Contructor.
        //------------------------------------------------------------------------
        public CTrianguloEscaleno(Color Color, double Base, double Altura): 
            base(Color, Base, Altura, "Triangulo Escaleno")
        {

        }
    }
}
