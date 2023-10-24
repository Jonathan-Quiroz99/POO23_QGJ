using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_QGJ
{
    //------------------------------------------------------------------------
    //Clase que representa una calculadora basica.
    //QGJ. 07/02/2023
    //------------------------------------------------------------------------
    internal class CCalculadoraBasica
    {
        //------------------------------------------------------------------------
        //Atributos.
        //------------------------------------------------------------------------
        private double Operador1;
        private double Operador2;
        private double Resultado;

        //------------------------------------------------------------------------
        //Contructor.
        //------------------------------------------------------------------------
        public CCalculadoraBasica(double Operador1, double Operador2) 
        {
            this.Operador1 = Operador1;
            this.Operador2 = Operador2;
        }

        //------------------------------------------------------------------------
        //Suma los operandos.
        //------------------------------------------------------------------------
        public double Suma()
        {
            Resultado = Operador1 + Operador2;
            return Resultado;
        }

        //------------------------------------------------------------------------
        //Resta los operandos.
        //------------------------------------------------------------------------
        public double Resta()
        {
            Resultado = Operador1 - Operador2;
            return Resultado;
        }

        //------------------------------------------------------------------------
        //Divide los operandos.
        //------------------------------------------------------------------------
        public double Division()
        {
            if(Operador2 != 0)
            {
                Resultado = Operador1 / Operador2;
            }
            else
            {
                Resultado = -1; //Error.
            }
            
            return Resultado;
        }

        //------------------------------------------------------------------------
        //Multiplica los operandos.
        //------------------------------------------------------------------------
        public double Multiplicacion()
        {
            Resultado = Operador1 * Operador2;
            return Resultado;
        }
        //------------------------------------------------------------------------
        //Obtiene el resultado de la calculadora en este momento
        //------------------------------------------------------------------------
        public double GetResultado()
        {
            return Resultado;
        }
    }
}
