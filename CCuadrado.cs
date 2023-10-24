using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_QGJ
{
    //------------------------------------------------------------------------
    //Clase que representa un cuadrado.
    //QGJ. 14/03/2023
    //------------------------------------------------------------------------
    public class CCuadrado : CCuadrilatero
    {
        //------------------------------------------------------------------------
        //Atributos.
        //------------------------------------------------------------------------


        //------------------------------------------------------------------------
        //Contructor.
        //------------------------------------------------------------------------
        public CCuadrado(Color Color, double Lado) : 
            base(Color, "Cuadrado", Lado, Lado) 
        {
            
        }        
    }
}
