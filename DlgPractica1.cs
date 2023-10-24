using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO23A_QGJ
{
    //------------------------------------------------------------------------
    //Dialogo de la practica 1.
    //QGJ. 07/02/2023
    //------------------------------------------------------------------------
    public partial class DlgPractica1 : Form
    {
        //------------------------------------------------------------------------
        //Atributos.
        //------------------------------------------------------------------------

        //------------------------------------------------------------------------
        //Constructor.
        //------------------------------------------------------------------------
        public DlgPractica1()
        {
            InitializeComponent();
        }

        //------------------------------------------------------------------------
        //Boton que crea 3 calculadoras en variables independientes.
        //------------------------------------------------------------------------
        private void BtnCalculadora_Click(object sender, EventArgs e)
        {
            CCalculadoraBasica MiCalculadora1;
            CCalculadoraBasica MiCalculadora2;
            CCalculadoraBasica MiCalculadora3;

            double Resultado;

            List<CCalculadoraBasica> MiListaCalculadoras;
            MiListaCalculadoras = new List<CCalculadoraBasica>();

            //Se crean las calculadoras.                        
            MiCalculadora1 = new CCalculadoraBasica(2, 3);//Suma = 5
            MiCalculadora2 = new CCalculadoraBasica(4, 5);//Suma = 9
            MiCalculadora3 = new CCalculadoraBasica(6, 7);//Suma = 13


            //Se realizan operaciones.
            Resultado = MiCalculadora1.Suma();
            MessageBox.Show("el resultado de la suma en calc 1 es " + Resultado.ToString());

            Resultado = MiCalculadora2.Suma();
            MessageBox.Show("el resultado de la suma en calc 2 es " + Resultado.ToString());

            Resultado = MiCalculadora3.Suma();
            MessageBox.Show("el resultado de la suma en calc 3 es " + Resultado.ToString());

            Resultado = MiCalculadora1.Resta();
            MessageBox.Show("el resultado de la resta es " + Resultado.ToString());

            Resultado = MiCalculadora1.Multiplicacion();
            MessageBox.Show("el resultado multiplicacion es " + Resultado.ToString());

            Resultado = MiCalculadora1.Division();
            MessageBox.Show("el resultado division es " + Resultado.ToString());
        }

        //------------------------------------------------------------------------
        //Boton que crea 100 iteraciones de una calculadora.
        //------------------------------------------------------------------------
        private void BtnCalculadora100I_Click(object sender, EventArgs e)
        {
            CCalculadoraBasica Mical;

            double Resultado;
            double operador;

            List<CCalculadoraBasica> MiListaCalculadoras;
            MiListaCalculadoras = new List<CCalculadoraBasica>();

            //Se crean las calculadoras.
            operador = 1;
            for (int i = 0; i < 100; i++)
            {
                Mical = new CCalculadoraBasica(operador, operador + 1);
                Resultado = Mical.Multiplicacion();
                MiListaCalculadoras.Add(Mical);//se agrega a la lista MilistaCalculadoras.
                operador = operador + 2;
            }

            //Recorre la lista de calculadoras para obtener su resultado.
            double Sumatoria;

            Sumatoria = 0;

            foreach (CCalculadoraBasica CalculadoraAux in MiListaCalculadoras)
            {
                Sumatoria = Sumatoria + CalculadoraAux.GetResultado();
            }

            MessageBox.Show("El resultado de la lista es " + Sumatoria);
        }
        //------------------------------------------------------------------------
        //Al dar Click al boton Figura.
        //------------------------------------------------------------------------
        private void BtnFigura_Click(object sender, EventArgs e)
        {
            //            int HashCode;
            double Resultado;
            //           string ResultadoMV;
            string Nombre;
            CTriangulo MiTriangulo;
            CCuadrado MiCuadrado;
            CRectangulo MiRectangulo;
            //           CPentagono MiPentagono;
            //           CHexagono MiHexagono;

            MiCuadrado = new CCuadrado(Color.Red, 10);
            MiCuadrado.CalculaArea();
            Nombre = MiCuadrado.GetNombre();
            Resultado = MiCuadrado.GetArea();
            MessageBox.Show("Hola soy " + Nombre + " y mi area es: " + Resultado);

            MiRectangulo = new CRectangulo(Color.Blue, 10, 20);
            MiRectangulo.CalculaArea();
            Nombre = MiRectangulo.GetNombre();
            Resultado = MiRectangulo.GetArea();
            MessageBox.Show("Hola soy " + Nombre + " y mi area es: " + Resultado);

            MiTriangulo = new CTrianguloEquilatero(Color.Green, 30, 50);
            MiTriangulo.CalculaArea();
            Nombre = MiTriangulo.GetNombre();
            Resultado = MiTriangulo.GetArea();
            MessageBox.Show("Hola soy " + Nombre + " y mi area es: " + Resultado);

            MiTriangulo = new CTrianguloIsoceles(Color.Yellow, 65, 70);
            MiTriangulo.CalculaArea();
            Nombre = MiTriangulo.GetNombre();
            Resultado = MiTriangulo.GetArea();
            MessageBox.Show("Hola soy " + Nombre + " y mi area es: " + Resultado);

            MiTriangulo = new CTrianguloEscaleno(Color.White, 400, 230);
            MiTriangulo.CalculaArea();
            Nombre = MiTriangulo.GetNombre();
            Resultado = MiTriangulo.GetArea();
            MessageBox.Show("Hola soy " + Nombre + " y mi area es: " + Resultado);

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
