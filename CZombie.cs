using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace POO23A_QGJ
{
    //------------------------------------------------------------------------
    //Clase que representa un zombie.
    //QGJ. 02/05/2023
    //------------------------------------------------------------------------
    public class CZombie: Button
    {
        //------------------------------------------------------------------------
        //Atributos.
        //------------------------------------------------------------------------

        //Atributos de nacimiento.
        private int XNacimiento;
        private int YNacimiento;

        //Atributos de navegacion.
        protected int Velocidad;

        //Atributos de Area de Desplazamiento.
        protected Control AreaDesplazamiento;
        private bool Norte;
        private bool Sur;
        private bool Este;
        private bool Oeste;

        //Atributos de control.
        private bool Nacido;
        private bool Muerto;
        private bool RegresarACasa;

        //Atributos de ejecucion.
        protected Thread ProcesoVida;

        //------------------------------------------------------------------------
        //Contructor.
        //------------------------------------------------------------------------
        public CZombie(Control AreaDesplazamiento): base()
        {
            Random Aleatorio;

            Aleatorio = new Random();
            XNacimiento = Aleatorio.Next(0, AreaDesplazamiento.Width - 41);
            YNacimiento = Aleatorio.Next(0, AreaDesplazamiento.Height - 41);

            //Inicializa atributos del area de vuelo.
            this.AreaDesplazamiento = AreaDesplazamiento;
            this.AreaDesplazamiento.Controls.Add(this);

            //Construye Zombie.
            Zombie();

            //Inicializa Atributos.
            Nacido = false;
            Muerto = false;
            RegresarACasa = false;
            Norte = false;
            Sur = true;
            Este = true;
            Oeste = false;
            Velocidad = 50;

            ProcesoVida = null;            

            //Metodo manejador del click.
            Click += new EventHandler(Identificar);
        }

        //------------------------------------------------------------------------
        //Incrementa el buffer
        //------------------------------------------------------------------------
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EXCOMPOSITED = 0x02000000;
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EXCOMPOSITED;
                return cp;
            }
        }

        //------------------------------------------------------------------------
        //Metodo para generar el zombie.
        //------------------------------------------------------------------------
        public void Zombie()
        {
            Location = new Point(XNacimiento, YNacimiento);
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Name = "Zombie";
            Size = new Size(50, 50);
            DoubleBuffered = true;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BringToFront();
            Tag = "zombie1";
        }

        //------------------------------------------------------------------------
        //Devuelve coordenadas del zombie.
        //------------------------------------------------------------------------
        public void Identificar(object sender, EventArgs e)
        {
            int[] Localizacion;

            Localizacion = GetAreaLocalizacion();

            MessageBox.Show("Localizacion + " + Localizacion[0] + ", " + Localizacion[1] +
                ", " + Localizacion[2] + ", " + Localizacion[3]);
        }

        //------------------------------------------------------------------------
        //Desplaza el ser vivo a una velocidad determinada.
        //------------------------------------------------------------------------
        public void Desplazar()
        {
            int X;
            int Y;

            //Desplaza el zombie por un tiempo indefinido
            //NOTA: se utiliza un hilo de ejecucion el cual debera de ser
            //finalizado al termino del programa.

            ProcesoVida = new Thread(() =>
            {
                while (!Muerto)
                {
                    if (Nacido)
                    {
                        //Posicion inicial
                        X = Location.X;
                        Y = Location.Y;

                        //Calcula desplazamiento
                        if (Norte)
                        {
                            Y = Y - 1;
                        }
                        if (Sur)
                        {
                            Y = Y + 1;
                        }
                        if (Este)
                        {
                            X = X + 1;
                        }
                        if (Oeste)
                        {
                            X = X - 1;
                        }
                        //Procesa el rebote.
                        if(X <= 0)
                        {
                            Oeste = false;
                            Este = true;
                        }
                        if(X >= AreaDesplazamiento.Width - 50)
                        {
                            Este = false;
                            Oeste = true;                            
                        }
                        if(Y <= 0)
                        {
                            Norte = false;
                            Sur = true;
                        }
                        if(Y >= AreaDesplazamiento.Height - 50)
                        {
                            Sur = false;
                            Norte = true;
                        }

                        //Posicion final
                        Location = new Point(X, Y);
                        Thread.Sleep(this.Velocidad);                        
                    }
                }
            });
            ProcesoVida.Start();           
        }

        //------------------------------------------------------------------------
        //Quita al zombie del programa
        //------------------------------------------------------------------------
        public void Morir()
        {            
            Thread ProcesoMuerte;
            ProcesoMuerte = new Thread(() =>
            {
                Muerto = true;
                Visible = false;
                AreaDesplazamiento.Controls.Remove(this);
                AreaDesplazamiento.Invalidate();
            });
            ProcesoMuerte.Start();            
        }

        //------------------------------------------------------------------------
        //Da vida al zombie despues de un momento
        //------------------------------------------------------------------------
        public void Nacer()
        {
            Thread ProcesoEjecucion;
            Image ColorNAcimiento;            

            ColorNAcimiento = this.ColorNAcimiento();

            ProcesoEjecucion = new Thread(() =>
            {
                Thread.Sleep(1500);
                Nacido = true;
                BackgroundImage = ColorNAcimiento;
                
            });
            ProcesoEjecucion.Start();
        }

        //------------------------------------------------------------------------
        //Dibuja el zombie al momento de nacer
        //------------------------------------------------------------------------
        protected virtual Image ColorNAcimiento()
        {
            Bitmap BGImage = Properties.Resources.zombie1;
            return BGImage;
        }

        //------------------------------------------------------------------------
        //Termina el ser vivo
        //------------------------------------------------------------------------
        protected override void Dispose(bool disposing)
        {
            Muerto = true;
            base.Dispose(disposing);            
        }

        //------------------------------------------------------------------------
        //Obtener el area de localizacion del zombie
        //------------------------------------------------------------------------
        public int[] GetAreaLocalizacion()
        {
            int[] Localizacion;

            Localizacion = new int[4];

            Localizacion[0] = Location.X;
            Localizacion[1] = Location.Y;
            Localizacion[2] = Location.X + 50;
            Localizacion[3] = Location.Y + 50;

            return Localizacion;
        }
    }
}
