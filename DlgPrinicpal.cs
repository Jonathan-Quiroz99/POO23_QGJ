using System.Drawing.Text;

namespace POO23A_QGJ
{
    //------------------------------------------------------------------------
    //Dialogo principal del proyecto de practicas de POO 23A.
    //QGJ. 24/01/2023
    //------------------------------------------------------------------------
    public partial class DlgPrinicpal : Form
    {
        //------------------------------------------------------------------------
        //Atributos.
        //------------------------------------------------------------------------
        private int Altura;
        private int Anchura;
        public bool BGCanMove;

        //------------------------------------------------------------------------
        //Contructor.
        //------------------------------------------------------------------------
        public DlgPrinicpal()
        {
            InitializeComponent();
            Altura = 920;
            Anchura = 1080;
            Text = "Jonathan Quiroz Garcia";
        }

        public void BackGroundAnimation()
        {
            if (BGCanMove == true)
            {
                PbBackground.Visible = true;
            }
            else
            {
                PbBackground.Visible = false;
            }
        }

        //------------------------------------------------------------------------
        //Al click abre Practica 1.
        //------------------------------------------------------------------------
        private void BtnPractica1_Click(object sender, EventArgs e)
        {
            DlgPractica1 Practica1;

            Practica1 = new DlgPractica1();
            BGCanMove = false;
            BackGroundAnimation();
            Practica1.ShowDialog();

            BGCanMove = true;
            BackGroundAnimation();
        }

        private void PnlPractica1_MouseLeave(object sender, EventArgs e)
        {
            PbPractica1.BackgroundImage = null;
            LblPractica1.Text = "";
        }

        private void PnlPractica1_MouseEnter(object sender, EventArgs e)
        {
            PbPractica1.BackgroundImage = Properties.Resources.torre11;
            PbPractica1.BringToFront();

            LblPractica1.Text = "Act 1";
            LblPractica1.BringToFront();
        }

        private void PbPractica2_MouseEnter(object sender, EventArgs e)
        {
            PbPractica2.BackgroundImage = Properties.Resources.torre2;
            PbPractica2.BringToFront();
            LblPractica2.Text = "Act 2";
            LblPractica2.BringToFront();

        }

        private void PbPractica2_MouseLeave(object sender, EventArgs e)
        {
            PbPractica2.BackgroundImage = null;
            LblPractica2.Text = "";
        }

        private void PbPractica3_MouseEnter(object sender, EventArgs e)
        {
            PbPractica3.BackgroundImage = Properties.Resources.torre3;
            PbPractica3.BringToFront();

            LblPractica3.Text = "Act 3";
            LblPractica3.BringToFront();
        }

        private void PbPractica3_MouseLeave(object sender, EventArgs e)
        {
            PbPractica3.BackgroundImage = null;
            LblPractica3.Text = "";
        }

        private void PbPractica2_Click(object sender, EventArgs e)
        {
            DlgPractica2 Practica2;

            Practica2 = new DlgPractica2();
            BGCanMove = false;
            BackGroundAnimation();
            Practica2.ShowDialog();

            Practica2.Close();

            BGCanMove = true;
            BackGroundAnimation();
        }
    }
}