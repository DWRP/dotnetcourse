namespace ClassAndObjetcs.Heranca
{
    public class Ponto
    {
        public int x, y;
        
        private int distancia;

        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public string Printar()
        {
            return "X: "+this.x.ToString() + " Y: " + this.y.ToString();
        }

        protected void CalcularDistancia()
        {
            CalcularDistancia2();
        }
        private void CalcularDistancia2()
        {
            //Faz alguma coisa
        }
        public virtual void CalcularDistancia3()
        {
            //Faz alguma coisa
        }
    
    }
}