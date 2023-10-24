using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_QGJ
{
    //------------------------------------------------------------------------
    //Clase que representa un poligono.
    //QGJ. 14/03/2023
    //------------------------------------------------------------------------
    public class CPoligono: CFiguraGeometrica
    {
        //------------------------------------------------------------------------
        //Atributos.
        //------------------------------------------------------------------------
        protected int NumLados;


        //------------------------------------------------------------------------
        //Contructor.
        //------------------------------------------------------------------------
        public CPoligono(Color Color, String Nombre): base(Color, Nombre)
        {
            NumLados = 0;
        }
    }
}
