using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POO23A_QGJ
{
    //------------------------------------------------------------------------
    //Clase que representa un zombie romero.
    //QGJ. 09/05/2023
    //------------------------------------------------------------------------
    internal class CZombieRomero : CZombie
    {
        

        //------------------------------------------------------------------------
        //Contructor.
        //------------------------------------------------------------------------
        public CZombieRomero(Control AreaDesplazamiento) : base(AreaDesplazamiento)
        {
            Velocidad = 1;
        }

        protected override Image ColorNAcimiento()
        {
            //return Color.FromArgb(255, 0, 0);
            Bitmap BGImage = Properties.Resources.zombie2;
            return BGImage;
        }

    }
}
