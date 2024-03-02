// Beatriz Juliato Coutinho    - RA: 22121
// Benneth urich Ramos Damasio - RA: 22122

using System.Drawing;

namespace Grafico
{
    class Circulo : Ponto
    {
        int raio;

        public int Raio
        {
            get { return raio; }
            set { raio = value; }
        }
        public Circulo(int xCentro, int yCentro, int novoRaio, Color novaCor) : base(xCentro, yCentro, novaCor) 
        {
            raio = novoRaio;
        }
        public void setRaio(int novoRaio)
        {
            raio = novoRaio;
        }
        public override void desenhar(Color corDesenho, Graphics g)
        {
            Pen pen = new Pen(corDesenho, 3);
            g.DrawEllipse(pen, base.X - raio, base.Y - raio, 2 * raio, 2 * raio);
        }

        public override string ToString()
        {
            return transformaString("cr", 5) +
                   transformaString(X, 5) +
                   transformaString(Y, 5) +
                   transformaString(Cor.R, 5) +
                   transformaString(Cor.G, 5) +
                   transformaString(Cor.B, 5) +
                   transformaString(Raio, 5);
        }
    }
}
