// Beatriz Juliato Coutinho    - RA: 22121
// Benneth urich Ramos Damasio - RA: 22122

using System.Drawing;

namespace Grafico
{
    class Elipse : Circulo  // classe Elipse deriva de Circulo
    {
        int segundoRaio;

        public int SegundoRaio
        {
            get { return segundoRaio; }
            set { segundoRaio = value; }
        }
        public Elipse(int xCentro, int yCentro, int primeiroRaio, int segundoRaio, Color novaCor) : base(xCentro, yCentro, primeiroRaio, novaCor)
        {
            this.segundoRaio = segundoRaio;
        }
        public override void desenhar(Color corDesenho, Graphics g)  // desenha a elipse na tela
        {
            Pen pen = new Pen(corDesenho, 3);
            g.DrawEllipse(pen, base.X - Raio, base.Y - segundoRaio, Raio * 2, SegundoRaio * 2);
        }

        // usado para definir como as informações da elipse serão salvas no arquivo texto
        public override string ToString()
        {
            return transformaString("ep", 5) +
                   transformaString(X, 5) +
                   transformaString(Y, 5) +
                   transformaString(Cor.R, 5) +
                   transformaString(Cor.G, 5) +
                   transformaString(Cor.B, 5) +
                   transformaString(Raio, 5) +
                   transformaString(SegundoRaio, 5);
        }
    }
}
