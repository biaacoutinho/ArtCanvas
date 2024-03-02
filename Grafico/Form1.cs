// Beatriz Juliato Coutinho    - RA: 22121
// Benneth urich Ramos Damasio - RA: 22122

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Grafico
{
    public partial class frmGrafico : Form
    {
        // declaração das variáveis:

        bool esperaPonto, esperaInicioReta, esperaFimReta = false;
        bool esperaInicioPolilinha, esperaFimPolilinha, finalizarPolilinha = false;
        bool esperaInicioRetangulo, esperaFinalRetangulo = false;
        bool esperaCentroCirculo, esperaRaioCirculo = false;
        bool esperaPrimeiroPontoElipse, esperaSegundoPontoElipse = false;

        // varias usadas na leitura do arquivo
        int xBase, yBase, corR, corG, corB;

        private ListaSimples<Ponto> figuras = new ListaSimples<Ponto>();

        ColorDialog corEscolhida = new ColorDialog();
        Color corAtual = Color.Black;
        Color corPolilinha = Color.Black;

        private static Ponto p1 = new Ponto(0, 0, Color.Black);
        private static Polilinha novaPolilinha;

        public frmGrafico()
        {
            InitializeComponent();
        }

        // define todas as esperas como false, para que a única variável definida como true (no
        // evento do botão dos desenhos) seja a referente à figura que o usuário deseja fazer
        private void LimparEsperas()
        {
            esperaPonto = false;
            esperaInicioReta = false;
            esperaFimReta = false;
            esperaInicioPolilinha = false;
            esperaFimPolilinha = false;
            finalizarPolilinha = false;
            esperaInicioRetangulo = false;
            esperaFinalRetangulo = false;
            esperaCentroCirculo = false;
            esperaRaioCirculo = false;
            esperaPrimeiroPontoElipse = false;
            esperaSegundoPontoElipse = false;

            btnCor.Enabled = true;
        }

        //  desenha na tela as figuras contidas na lista simples, adicionadas na leitura do arquivo txt
        private void pbAreaDesenho_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            figuras.IniciarPercursoSequencial(); 
            
            while (figuras.PodePercorrer())
            {
               Ponto figuraAtual = figuras.Atual.Info;
               figuraAtual.desenhar(figuraAtual.Cor, g);
            }
        }

        // mostra as coordenadas do mouse do usuário na tela
        private void pbAreaDesenho_MouseMove(object sender, MouseEventArgs e)
        {
            stMensagem.Items[3].Text = e.X + "," + e.Y;
        }

        private void pbAreaDesenho_MouseClick(object sender, MouseEventArgs e)
        {
            if (esperaPonto) 
            {
                p1.Cor = corAtual;
                p1.X = e.X;
                p1.Y = e.Y;
                Ponto novoPonto = new Ponto(p1.X, p1.Y, corAtual);
                figuras.InserirAposFim(new NoLista<Ponto>(novoPonto, null));
                p1.desenhar(p1.Cor, pbAreaDesenho.CreateGraphics());
                stMensagem.Items[1].Text = "Ponto feito com sucesso! Clique para fazer novos pontos.";
            }
            else
            if (esperaInicioReta)
            {
                p1.Cor = corAtual;
                p1.X = e.X;
                p1.Y = e.Y;
                esperaInicioReta = false;
                esperaFimReta = true;
                stMensagem.Items[1].Text = "Clique o ponto final da reta.";
            }
            else
            if (esperaFimReta)
            {
                esperaInicioReta = true;  // volta a ser true para que o usuario possa fazer varias retas seguidas sem a necessidade de clicar novamente no btnReta
                esperaFimReta = false;
                Reta novaLinha = new Reta(p1.X, p1.Y, e.X, e.Y, corAtual);
                figuras.InserirAposFim(new NoLista<Ponto>(novaLinha, null));
                novaLinha.desenhar(novaLinha.Cor, pbAreaDesenho.CreateGraphics());
                stMensagem.Items[1].Text = "Reta feito com sucesso! Clique em outro ponto para fazer outra reta.";

            }
            else
            if (esperaInicioRetangulo)
            {
                p1.Cor = corAtual;
                p1.X = e.X;
                p1.Y = e.Y;
                esperaInicioRetangulo = false;
                esperaFinalRetangulo = true;
                stMensagem.Items[1].Text = "Clique no ponto da extremidade inferior direita.";
            }
            else
            if (esperaFinalRetangulo)  
            {
                int x2 = e.X;
                int y2 = e.Y;
                int alturaRetangulo;
                int larguraRetangulo;

                // certifica-se que o retangulo será desenhado conforme o desejado pelo usuario, com os vertices no lugar certo
                if (e.Y < p1.Y)
                {
                    int aux = y2;
                    y2 = p1.Y;
                    p1.Y = aux;
                }
                alturaRetangulo = y2 - p1.Y;
                if (e.X < p1.X)
                {
                    int aux = x2;
                    x2 = p1.X;
                    p1.X = aux;
                }
                larguraRetangulo = x2 - p1.X;

                esperaFinalRetangulo = false;
                esperaInicioRetangulo = true;  // volta a ser true para que o usuario possa fazer varios retangulos seguidos sem a necessidade de clicar novamente no btnRetangulo
                Retangulo novoRetangulo = new Retangulo(p1.X, p1.Y, larguraRetangulo, alturaRetangulo, corAtual);
                figuras.InserirAposFim(new NoLista<Ponto>(novoRetangulo, null));
                novoRetangulo.desenhar(novoRetangulo.Cor, pbAreaDesenho.CreateGraphics());
                stMensagem.Items[1].Text = "Retângulo feito com sucesso! Clique para desenhar um novo retângulo.";
            }
            else
            if (esperaInicioPolilinha)
            {
                corPolilinha = corAtual;  // cor da polilinha sempre será cor do primeiro ponto que desenhou da polilinha, para que toda a figura seja feita com a mesma cor
                btnCor.Enabled = false; // botao de cor será desabilitado, sendo impossivel a polilinha ser feita com mais de uma cor 
                
                novaPolilinha = new Polilinha(e.X, e.Y, corPolilinha);  // cria uma polilinha, passando como parametro o primeiro ponto desenhado pelo usuario

                esperaInicioPolilinha = false;
                esperaFimPolilinha = true;
                stMensagem.Items[1].Text = "Clique em outros pontos para fazer a polilinha.";

            }
            else
            if (esperaFimPolilinha)
            {
                Ponto novoPonto = new Ponto(e.X, e.Y, corPolilinha); // cria-se um novo ponto e o insere na lista de pontos (na classe polilinha)
                novaPolilinha.AdicionarPonto(novoPonto);
                novaPolilinha.desenhar(corPolilinha, pbAreaDesenho.CreateGraphics());
                p1.X = e.X;
                p1.Y = e.Y;
                stMensagem.Items[1].Text = "Dê dois cliques para finalizar a polilinha.";

                if (finalizarPolilinha)  // quando o usuario der dois cliques com o mouse, finalizará a polilinha e a adicionará na lista ligada "figuras"
                {
                    stMensagem.Items[1].Text = "Polilinha feita com sucesso! Clique para desenhar uma nova polilinha.";
                    figuras.InserirAposFim(new NoLista<Ponto>(novaPolilinha, null));
                    LimparEsperas();
                    esperaInicioPolilinha = true;  // volta a ser true para que o usuario possa fazer varias polilinha seguidas sem a necessidade de clicar novamente no btnPolilinha
                }
            }
            else
            if (esperaCentroCirculo)
            {
                p1.X = e.X;
                p1.Y = e.Y;
                p1.Cor = corAtual;
                stMensagem.Items[1].Text = "Defina qual será o raio do circulo clicando em um ponto.";
                esperaRaioCirculo = true;
                esperaCentroCirculo = false;
            }
            else
            if (esperaRaioCirculo)
            {
                esperaRaioCirculo = false;
                esperaCentroCirculo = true; // volta a ser true para que o usuario possa fazer varios circulos seguidas sem a necessidade de clicar novamente no btnCirculo

                // calculos necessario para definir o raio do circulo de acordo com o ponto clicado pelo usuario
                int deltaX = Math.Abs(p1.X - e.X);
                int deltaY = Math.Abs(p1.Y - e.Y);
                double raio = Math.Sqrt((int)Math.Pow(deltaX, 2) + (int)Math.Pow(deltaY, 2));

                Circulo circulo = new Circulo(p1.X, p1.Y, (int)raio, corAtual);
                figuras.InserirAposFim(new NoLista<Ponto>(circulo, null));
                circulo.desenhar(circulo.Cor, pbAreaDesenho.CreateGraphics());
                stMensagem.Items[1].Text = "Circulo cirado com sucesso! Clique para desenhar um novo circulo.";
            }
            else
            if (esperaPrimeiroPontoElipse)
            {
                p1.X = e.X;
                p1.Y = e.Y;
                p1.Cor = corAtual;
                stMensagem.Items[1].Text = "Defina qual será o segundo ponto da elispse.";
                esperaPrimeiroPontoElipse = false;
                esperaSegundoPontoElipse = true;
            }
            else
            if (esperaSegundoPontoElipse) 
            {
                esperaSegundoPontoElipse = false;
                esperaPrimeiroPontoElipse = true;  // volta a ser true para que o usuario possa fazer varias elipses seguidas sem a necessidade de clicar novamente no btnElipse

                // calculos necessarios para definir o tamanho dos raios da elipse conforme o desejado pelo usuario
                int diametroX = Math.Abs(p1.X - e.X);
                int diametroY = Math.Abs(p1.Y - e.Y);
                int raioX = diametroX / 2;
                int raioY = diametroY / 2;
                int centroX = (p1.X + e.X) / 2;
                int centroY = (p1.Y + e.Y) / 2;

                Elipse elipse = new Elipse(centroX, centroY, raioX, raioY, corAtual);
                figuras.InserirAposFim(new NoLista<Ponto>(elipse, null));
                elipse.desenhar(elipse.Cor, pbAreaDesenho.CreateGraphics());
                stMensagem.Items[1].Text = "Elipse criada com sucesso! Clique para desenhar uma nova elipse.";
            }
        }


        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (dlgAbrir.ShowDialog() == DialogResult.OK)
                try
                {
                    figuras.LimparLista(); // limpa a lista para que os desenhos que já estavam no pbAreaDesenho não se misturem com os novos que virão do arquivo
                    StreamReader arqFiguras = new StreamReader(dlgAbrir.FileName);
                    String linha;


                    while ((linha = arqFiguras.ReadLine()) != null)
                    {
                        // divide as informações contidas na linha lida, adicionando-as em variáveis que serão usadas para armazenar as figuras na lista
                        String tipo = linha.Substring(0, 5).Trim();
                        
                        Color cor = new Color();
                        if (tipo.Substring(0, 2) != "pl") // verifica se é polilinha, pois o modo de leitura do arquivo é diferente dos demais
                        {
                            xBase = Convert.ToInt32(linha.Substring(5, 5).Trim());
                            yBase = Convert.ToInt32(linha.Substring(10, 5).Trim());
                            corR = Convert.ToInt32(linha.Substring(15, 5).Trim());
                            corG = Convert.ToInt32(linha.Substring(20, 5).Trim());
                            corB = Convert.ToInt32(linha.Substring(25, 5).Trim());
                            cor = Color.FromArgb(255, corR, corG, corB);
                        }

                        switch (tipo.Substring(0, 2))  // verifica o tipo de objeto gráfico que a linha lida desenhará
                        {
                            // dependo de qual tipo for, mais informações serão lidas; a figura e suas informações são adicionadas na lista ligada de figuras

                            case "pt": // figura é um ponto
                                figuras.InserirAposFim(
                                new NoLista<Ponto>(new Ponto(xBase, yBase, cor), null));
                                break;
                            case "ln": // figura é uma reta
                                int xFinal = Convert.ToInt32(linha.Substring(30, 5).Trim());
                                int yFinal = Convert.ToInt32(linha.Substring(35, 5).Trim());
                                figuras.InserirAposFim(new NoLista<Ponto>(
                                new Reta(xBase, yBase, xFinal, yFinal, cor), null));
                                break;
                            case "cr": // figura é um círculo
                                int raio = Convert.ToInt32(linha.Substring(30, 5).Trim());
                                figuras.InserirAposFim(new NoLista<Ponto>(
                                new Circulo(xBase, yBase, raio, cor), null));
                                break;
                            case "ep": // figura é uma elipse
                                int raioX = Convert.ToInt32(linha.Substring(30, 5).Trim());
                                int raioY = Convert.ToInt32(linha.Substring(35, 5).Trim());
                                figuras.InserirAposFim(new NoLista<Ponto>(
                                    new Elipse(xBase, yBase, raioX, raioY, cor)));
                                break;
                            case "rt": // figura é um retangulo
                                int largura = Convert.ToInt32(linha.Substring(30, 5).Trim());
                                int altura = Convert.ToInt32(linha.Substring(35, 5).Trim());
                                figuras.InserirAposFim(new NoLista<Ponto>(
                                    new Retangulo(xBase, yBase, largura, altura, cor)));
                                break;
                            case "pl": //figura é uma polilinha
                                int quantosNos = Convert.ToInt32(linha.Substring(5, 5).Trim());
                                for (int i = 0; i < quantosNos; i++)
                                {
                                    // a posicao que será lida da linha varia de acordo com qual o ponto estamos pegando as informaçoes
                                    xBase = Convert.ToInt32(linha.Substring(10 + 25 * i, 5).Trim()); 
                                    yBase = Convert.ToInt32(linha.Substring(15 + 25 * i, 5).Trim());
                                    corR = Convert.ToInt32(linha.Substring(20 + 25 * i, 5).Trim());
                                    corG = Convert.ToInt32(linha.Substring(25 + 25 * i, 5).Trim());
                                    corB = Convert.ToInt32(linha.Substring(30 + 25 * i, 5).Trim());
                                    cor = Color.FromArgb(255, corR, corG, corB);

                                    if (i == 0)  // quando estiver lendo o primeiro ponto, cria-se uma polilinha; os demais são apenas adicionados na polilinha criada
                                        novaPolilinha = new Polilinha(xBase, yBase, cor);
                                    else 
                                        novaPolilinha.AdicionarPonto(new Ponto(xBase, yBase, cor));

                                }
                                figuras.InserirAposFim(novaPolilinha); 
                                break;
                        }
                    }
                    // após a leitura completa do arquivo, ele será fechado, uma mensagem será
                    // mostrada ao usuário e chamará o método reponsável por realizar os desenhos
                    arqFiguras.Close();
                    this.Text = dlgAbrir.FileName;
                    stMensagem.Items[1].Text = "Arquivo aberto com sucesso!";
                    pbAreaDesenho.Invalidate();
                }
                catch (IOException)
                {
                    Console.Write("Erro de leitura no arquivo");
                }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            GravarArquivo();  // chama um método que salvará os desenhos feito pelo usuário em um arquivo texto
        }


        // evento clique dos botoes usados para desenhar figuras no pbAreaDesenho
        // ficará true a variável referente ao objeto gráfico que o usuário deseja fazer, para que ele seja desenhado na tela
        private void btnPonto_Click(object sender, EventArgs e)
        {
            stMensagem.Items[1].Text = "Clique no local do ponto desejado";
            LimparEsperas();
            esperaPonto = true;
        }

        private void btnReta_Click(object sender, EventArgs e)
        {
            stMensagem.Items[1].Text = "Clique no local do ponto para iniciar a reta: ";
            LimparEsperas();
            esperaInicioReta = true;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            stMensagem.Items[1].Text = "Clique onde será o primeiro ponto da elipse";
            LimparEsperas();
            esperaPrimeiroPontoElipse = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja mesmo limpar a tela?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                figuras.LimparLista();
                pbAreaDesenho.Invalidate();
                stMensagem.Items[1].Text = "Tela limpa com sucesso!";
                LimparEsperas();
            }
        }

        private void pbAreaDesenho_DoubleClick_1(object sender, EventArgs e)   // quando o usuário der dois cliques com o mouse, finaliza-se a polilinha
        {
            finalizarPolilinha = true;
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            stMensagem.Items[1].Text = "Clique onde será o centro do circulo";
            LimparEsperas();
            esperaCentroCirculo = true;
        }

        private void btnRetangulo_Click(object sender, EventArgs e)
        {
            stMensagem.Items[1].Text = "Clique no local da extremidade superior esquerda do retângulo: ";
            LimparEsperas();
            esperaInicioRetangulo = true;
        }

        private void btnPolilinha_Click(object sender, EventArgs e)
        {
            stMensagem.Items[1].Text = "Clique para começar a polilinha";
            LimparEsperas();
            esperaInicioPolilinha = true;
        }

        // evento clique do botao usado para o usuário definir a cor da caneta
        private void btnCor_Click(object sender, EventArgs e)
        {
            corEscolhida.ShowDialog();
            corAtual = corEscolhida.Color;
        }

        private void btnSair_Click(object sender, EventArgs e) 
        {
            // antes de fechar o programa, pergunta se o usuário deseja salvar o arquivo do desenho que ele acabou de fazer
            if (!figuras.EstaVazia)
            {
                DialogResult result = MessageBox.Show("Deseja salvar antes de sair do programa?", "Confirmação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    GravarArquivo();
                    Application.Exit();
                }
                else if (result == DialogResult.Cancel)  // caso o usuário desista de salvar o arquivo, o messageBox fechará e ele poderá continuar desenhando na tela
                    return;
                else  // caso o usuário não queira salvar as informações do desenho, o programa é finalizado
                    Application.Exit();
            }
            else  // se a lista de figuras estiver vazia, significa que nao há desenhos na tela. Portanto, nao pergunta ao usuário se ele quer salvar (caso ele salve, será um arquivo vazio, entao nao ha necessidade de gravá-lo)
                Application.Exit();
        } 

        private void GravarArquivo()
        {
            // será mostrado um SaveFileDialog, que salvará o desenho como um arquivo texto, 
            // contendo as informações (tipo de elemento, cor, posicao na tela) de cada elemento desenhado no pbAreaDesenho pelo usuário 
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            saveFileDialog.FileName = "Sem título";
            saveFileDialog.Title = "Salvar arquivo como um txt";
            saveFileDialog.ShowDialog();
            figuras.GravarArquivo(saveFileDialog.FileName);  // chama um método que percorre a lista ligada e vai adicionando as informações no txt 
        }
    }
}