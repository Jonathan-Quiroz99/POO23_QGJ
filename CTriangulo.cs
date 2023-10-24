using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_QGJ
{
    //------------------------------------------------------------------------
    //Clase que representa un triangulo.
    //QGJ. 14/03/2023
    //------------------------------------------------------------------------
    public class CTriangulo : CPoligono
    {
        //------------------------------------------------------------------------
        //Atributos.
        //------------------------------------------------------------------------
        protected double Base;
        protected double Altura;

        //------------------------------------------------------------------------
        //Contructor.
        //------------------------------------------------------------------------
        public CTriangulo(Color Color, double Base, double Altura, string Nombre) : base(Color, Nombre)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        //------------------------------------------------------------------------
        //Obtiene el area del triangulo.
        //------------------------------------------------------------------------
        public override void CalculaArea()
        {
            base.CalculaArea();

            Area = Base * Altura / 2;
        }
    }
}
