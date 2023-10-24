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
    //Clase que representa un ser vivo.
    //QGJ. 02/05/2023
    //------------------------------------------------------------------------
    public partial class DlgPractica2 : Form
    {
        //------------------------------------------------------------------------
        //Atributos.
        //------------------------------------------------------------------------
        Thread ProcesoColision;
        protected bool Colision;

        //------------------------------------------------------------------------
        //Contructor.
        //------------------------------------------------------------------------
        public DlgPractica2()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += DlgPractica2_FormClosing;
        }

        //------------------------------------------------------------------------
        //remueve todos los objetos al cerrar
        //------------------------------------------------------------------------
        private void DlgPractica2_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Colision = false;
            if (ProcesoColision != null && ProcesoColision.IsAlive)
            {
                ProcesoColision.Join();
                ProcesoColision = null;
            }
        }

        //------------------------------------------------------------------------
        //Crea un zombie.
        //------------------------------------------------------------------------
        private void BtnZombie_Click(object sender, EventArgs e)
        {
            CZombie Zombie;

            Zombie = new CZombie(this.PnlArea);
            Zombie.Nacer();
            Zombie.Desplazar();
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
        //Crea un zombie romero.
        //------------------------------------------------------------------------
        private void BtnZombieRomero_Click(object sender, EventArgs e)
        {
            CZombieRomero Zombie;
            Zombie = new CZombieRomero(this.PnlArea);
            Zombie.Nacer();
            Zombie.Desplazar();
        }

        //------------------------------------------------------------------------
        //Inicia el sistema de colision.
        //------------------------------------------------------------------------
        private void BtnColision_Click(object sender, EventArgs e)
        {
            ProcesoColision = new Thread(() =>
            {
                int[] Localizacion;
                int[] Localizacion2;

                Localizacion = new int[4];
                Localizacion2 = new int[4];

                Colision = true;

                while (Colision)
                {
                    //Etapa 1: Obtiene coordenadas y procesa colores
                    foreach (var Control in this.PnlArea.Controls)
                    {
                        if (Control.GetType() == typeof(CZombie) ||
                        Control.GetType() == typeof(CZombieRomero))
                        {
                            CZombie Zombie;

                            Zombie = (CZombie)Control;
                            Localizacion = Zombie.GetAreaLocalizacion();

                            /*
                            Thread.Sleep(100);
                            Zombie.BackColor = Color.GreenYellow;
                            Zombie.Text = Localizacion[0].ToString() + "," + Localizacion[1].ToString();
                            Thread.Sleep(100);
                            Zombie.BackColor = Color.Yellow;
                            Zombie.Text = Localizacion[0].ToString() + "," + Localizacion[1].ToString();
                            */
                        }
                    }
                    //Etapa 2: compara coordenadas.
                    for (int i = 0; i < this.PnlArea.Controls.Count; i++)
                    {
                        Control Control1;
                        Control Control2;
                        int Z1X1, Z1Y1, Z1X2, Z1Y2;
                        int Z2X1, Z2Y1, Z2X2, Z2Y2;

                        Control1 = this.PnlArea.Controls[i];

                        if (i >= this.PnlArea.Controls.Count - 1)
                        {
                            continue;
                        }

                        Control2 = this.PnlArea.Controls[i + 1];

                        if ((Control1.GetType() == typeof(CZombie) ||
                        Control1.GetType() == typeof(CZombieRomero)) &&
                        (Control2.GetType() == typeof(CZombie) ||
                        Control2.GetType() == typeof(CZombieRomero)))
                        {
                            CZombie Zombie1;
                            CZombie Zombie2;

                            Zombie1 = (CZombie)Control1;
                            Localizacion = Zombie1.GetAreaLocalizacion();

                            Zombie2 = (CZombie)Control2;
                            Localizacion2 = Zombie2.GetAreaLocalizacion();

                            Z1X1 = Localizacion[0];
                            Z1Y1 = Localizacion[1];
                            Z1X2 = Localizacion[2];
                            Z1Y2 = Localizacion[3];

                            Z2X1 = Localizacion2[0];
                            Z2Y1 = Localizacion2[1];
                            Z2X2 = Localizacion2[2];
                            Z2Y2 = Localizacion2[3];

                            //condicion para detectar la colision.
                            if ((Z2X1 >= Z1X1 - 49 && Z2X1 <= Z1X1) &&
                               (Z2Y1 >= Z1Y1 - 49 && Z2Y1 <= Z1Y1))
                            {
                                if (Zombie1.GetType() == typeof(CZombie) && Zombie2.GetType() == typeof(CZombieRomero))
                                {
                                    Zombie1.Morir();
                                }
                                else if (Zombie2.GetType() == typeof(CZombie) && Zombie1.GetType() == typeof(CZombieRomero))
                                {
                                    Zombie2.Morir();
                                }
                            }
                        }
                    }
                }
            });
            ProcesoColision.Start();
        }

    }
}
