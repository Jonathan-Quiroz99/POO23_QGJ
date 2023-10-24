using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_QGJ
{
    //------------------------------------------------------------------------
    //Clase que representa una silla.
    //QGJ. 21/02/2023
    //------------------------------------------------------------------------
    internal class CSilla
    {
        //------------------------------------------------------------------------
        //Atributos.
        //------------------------------------------------------------------------
        private int material; //1= madera, 2= metal, 3=plastico.
        private float resistencia; //1000 N de resistencia, 1500 N de resistencia, 2000 N de resistencia.
        private float temp; // -100C a 400C calor.
        private int clavos; //1= acero al carbon, 2= aluminio, 3= laton, 4= hierro, 5= cobre
        private int pintura; //1= rojo, 2= amarillo, 3= blanco, 4= verde, 5= azul, 6= transparente
        private int edad; // tiempo que lleva existiendo el objeto

        //------------------------------------------------------------------------
        //Constructor.
        //------------------------------------------------------------------------
        public CSilla(int material, float resitencia, float temp, int clavos, int pintura, int edad) 
        {
            this.material = material;
            this.resistencia = resitencia;
            this.temp = temp;
            this.clavos = clavos;
            this.pintura = pintura;
            this.edad = edad;
        }

        //------------------------------------------------------------------------
        //Funcion para hincharse.
        //------------------------------------------------------------------------
        public float Hincharse() 
        {
            return 0;
        }

        //------------------------------------------------------------------------
        //Funcion para Astillarse.
        //------------------------------------------------------------------------
        public int Astillarse()
        {
            return 0;
        }

        //------------------------------------------------------------------------
        //Funcion para carbonizase.
        //------------------------------------------------------------------------
        public float Carbonizarse()
        {
            return 0;
        }

        //------------------------------------------------------------------------
        //Funcion para romperse.
        //------------------------------------------------------------------------
        public float Romperse()
        {
            return 0;
        }

        //------------------------------------------------------------------------
        //Funcion para decolorarse.
        //------------------------------------------------------------------------
        public float Decolorarse()
        {
            return 0;
        }

        //------------------------------------------------------------------------
        //Funcion para despintarse.
        //------------------------------------------------------------------------
        public float Despintase()
        {
            return 0;
        }

    }
}
