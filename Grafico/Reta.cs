// Beatriz Juliato Coutinho    - RA: 22121
// Benneth urich Ramos Damasio - RA: 22122

using System.Drawing;

namespace Grafico
{
    class Reta : Ponto
    {
        private Ponto pontoFinal;
        public ListaSimples<Ponto> Pontos { get; set; }

        public Ponto PontoFinal { get { return pontoFinal; } set => pontoFinal = value; }

        public Reta(int x1, int y1, int x2, int y2, Color novaCor) : base(x1, y1, novaCor)
        {
            pontoFinal = new Ponto(x2, y2, novaCor);
            Pontos = new ListaSimples<Ponto>();
        }

        public override void desenhar(Color corDesenho, Graphics g)  // desenha a reta na tela
        {
            Pen pen = new Pen(corDesenho, 3);
            g.DrawLine(pen, base.X, base.Y, pontoFinal.X, pontoFinal.Y);
        }

        // usado para definir como as informações da reta serão salvas no arquivo texto
        public override string ToString()
        {
            return transformaString("ln", 5) +
                   transformaString(X, 5) +
                   transformaString(Y, 5) +
                   transformaString(Cor.R, 5) +
                   transformaString(Cor.G, 5) +
                   transformaString(Cor.B, 5) +
                   transformaString(pontoFinal.X, 5) +
                   transformaString(pontoFinal.Y, 5);
        }

        public void AdicionarReta(Ponto pontoInicial, Ponto pontoFinal)
        {
            Pontos.Adicionar(pontoInicial);
            Pontos.Adicionar(pontoFinal);
        }
    }
}
