namespace POO23A_QGJ
{
    //------------------------------------------------------------------------
    //Clase que representa un cuadrilatero.
    //QGJ. 14/03/2023
    //------------------------------------------------------------------------
    public class CCuadrilatero : CPoligono// esta clase hereda de la clase CPoligono
    {
        //------------------------------------------------------------------------
        //Atributos.
        //------------------------------------------------------------------------
        private double Lado1;
        private double Lado2;
        

        //------------------------------------------------------------------------
        //Contructor.
        //------------------------------------------------------------------------
        public CCuadrilatero(Color Color, string Nombre, double Lado1, double Lado2): base(Color, Nombre)
        {
            this.Lado1 = Lado1;
            this.Lado2 = Lado2;
            NumLados = 4;

        }

        //------------------------------------------------------------------------
        //Calcula el area de un cuadrilatero.
        //------------------------------------------------------------------------
        public double CalculaAreaOriginal()
        {
            Area = Lado1 * Lado2;
            AreaCalculada = true;

            return Area;
        }

        //------------------------------------------------------------------------
        //Asigna el valor de los lados de cuadrilateros.
        //------------------------------------------------------------------------
        public void SetLados(Color Color, double Lado1, double Lado2)
        {
            this.Lado1 = Lado1;
            this.Lado2 = Lado2;
        }

        //------------------------------------------------------------------------
        //Obtiene el area del cuadrilatero.
        //------------------------------------------------------------------------
        public override void CalculaArea()
        {
            base.CalculaArea();
            Area = Lado1 * Lado2;
        }
    }
}
