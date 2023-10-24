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
    public class CFiguraGeometrica : CFigura
    {
        //------------------------------------------------------------------------
        //Atributos.
        //------------------------------------------------------------------------
        //NOTA: poner un atributo protected hace que solo las clases que heredan
        //de esta clase puedan acceder a este atributo.
        protected double Area;
        protected bool AreaCalculada;

        //------------------------------------------------------------------------
        //Contructor.
        //------------------------------------------------------------------------
        public CFiguraGeometrica(Color Color, string Nombre) : base(Color, Nombre)
        {
            Area = 0;
            AreaCalculada = false;
        }

        //------------------------------------------------------------------------
        //Obtiene el area de un cuadrilatero.
        //------------------------------------------------------------------------
        public double GetArea()
        {
            //NOTA: Regresara -1 en caso de no haber sido aun calculado.
            //de lo contrario regresara el area de la figura geometrica.
            if (AreaCalculada)
                return Area;
            else
                return -1;
        }

        //------------------------------------------------------------------------
        //Obtiene el area de la figura geometrica.
        //------------------------------------------------------------------------
        public virtual void CalculaArea()
        {
            AreaCalculada = true;
        }
    }
}
