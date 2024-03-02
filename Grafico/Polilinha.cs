// Beatriz Juliato Coutinho    - RA: 22121
// Benneth urich Ramos Damasio - RA: 22122

using System.Drawing;
using System.Windows.Forms;

namespace Grafico
{
    class Polilinha : Ponto
    { 

        ListaSimples<Ponto> pontos = new ListaSimples<Ponto>();

        public Polilinha(int x1, int y1, Color novaCor) : base(x1, y1, novaCor)
        {
            AdicionarPonto(new Ponto(base.X, base.Y, base.Cor));
        }

        public override void desenhar(Color corDesenho, Graphics g)  
        {
            Pen pen = new Pen(corDesenho, 3);

            pontos.IniciarPercursoSequencial();

            while (pontos.PodePercorrer())  // percorre a lista lgada de pontos e vai desenhando retas na tela, desenhando, assim, uma polilinha
            {
                var ponto = pontos.Atual;

                if (ponto.Prox != null) 
                    g.DrawLine(pen, ponto.Info.X, ponto.Info.Y, ponto.Prox.Info.X, ponto.Prox.Info.Y); // as retas sao compostas pelo ponto atual e o proximo da lista
            }
        }

        public override string ToString()   
        {
            var lista = pontos.Lista(); 
            string formatoArquivo = transformaString("pl", 5) +                // no inicio do formatoArquivo, são salvos o tipo de elemento que aquela linha do arquivo representa
                                    transformaString(pontos.QuantosNos(), 5); // e quantos pontos (informacao referente a qauntos pontos) há nessa linha (informação util para quando o usuario abrir o arquivo)

            // percorre a lista de pontos e vai adicionando as informações de todos eles em uma linha, que será salva, posteriormente, em um arquivo texto
            foreach (var ponto in lista)
            {
                formatoArquivo += transformaString(ponto.X, 5) +
                                  transformaString(ponto.Y, 5) +
                                  transformaString(ponto.Cor.R, 5) +
                                  transformaString(ponto.Cor.G, 5) +
                                  transformaString(ponto.Cor.B, 5);
            }
            return formatoArquivo;
        }
        public void AdicionarPonto(Ponto ponto)
        {
            pontos.InserirAposFim(new NoLista<Ponto>(ponto));  // adiciona o ponto passado como paramentro na lista ligada de pontos
        }
    }
}
