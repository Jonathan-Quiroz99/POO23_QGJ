using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_QGJ
{
    //------------------------------------------------------------------------
    //Clase que representa una figura geometrica.
    //QGJ. 14/03/2023
    //------------------------------------------------------------------------
    public class CFigura : Object
    {
        //------------------------------------------------------------------------
        //Atributos.
        //------------------------------------------------------------------------
        protected string Nombre;
        protected Color color;

        //------------------------------------------------------------------------
        //Contructor.
        //------------------------------------------------------------------------
        public CFigura(Color Color, String Nombre) 
        {
            this.color = Color;
            this.Nombre = Nombre;
        }

        //------------------------------------------------------------------------
        //Dibuja una figura.
        //------------------------------------------------------------------------
        public void Dibujarse()
        {

        }

        //------------------------------------------------------------------------
        //obtiene el nombre de la figura.
        //------------------------------------------------------------------------
        public string GetNombre()
        {
            return Nombre;
        }
    }
}
