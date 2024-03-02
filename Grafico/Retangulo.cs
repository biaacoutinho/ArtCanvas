// Beatriz Juliato Coutinho    - RA: 22121
// Benneth urich Ramos Damasio - RA: 22122

using System.Drawing;

namespace Grafico
{
    class Retangulo : Ponto
    {
        int altura, largura;

        public int Altura { get => altura; set => altura = value; }
        public int Largura { get => largura; set => largura = value; }

        public Retangulo (int x, int y, int largura, int altura, Color novaCor) : base (x, y, novaCor)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public override void desenhar(Color corDesenho, Graphics g)  // desenha o retangulo na tela
        {
            Pen pen = new Pen(corDesenho, 3);
            g.DrawRectangle(pen, base.X, base.Y, largura, altura);
        }

        // usado para definir como as informações do retângulo serão salvas no arquivo texto
        public override string ToString()
        {
            return transformaString("rt", 5) +
                   transformaString(X, 5) +
                   transformaString(Y, 5) +
                   transformaString(Cor.R, 5) +
                   transformaString(Cor.G, 5) +
                   transformaString(Cor.B, 5) +
                   transformaString(Largura, 5) +
                   transformaString(Altura, 5);
        }
    }
}
