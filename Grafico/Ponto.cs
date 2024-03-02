// Beatriz Juliato Coutinho    - RA: 22121
// Benneth urich Ramos Damasio - RA: 22122

using System;
using System.Drawing;

namespace Grafico
{
    class Ponto : IComparable<Ponto>, IRegistro
    {
        private int x, y;
        private Color cor;
       
        public Ponto(int cX, int cY, Color qualCor)
        {
            x = cX;
            y = cY;
            cor = qualCor;
        }

        public int X
        {
            get { return x; }
            set{ x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public Color Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public virtual void desenhar(Color cor, Graphics g) 
        {
            Pen pen = new Pen(cor);  
            // é feito um quadrado de 1px de lado, pois o ponto era MUITO pequeno, sendo impossível vê-lo na tela
            g.DrawRectangle(pen, x, y, 1, 1);  
        }

        public int CompareTo(Ponto other) 
        {
            int diferencaX = X - other.X;
            if(diferencaX == 0 )
                return Y - other.Y;
            return diferencaX;
        }

        public String transformaString(int valor, int quantasPosicoes)
        {
            String cadeia = valor + "";
            while (cadeia.Length < quantasPosicoes)
                cadeia = "0" + cadeia;
            return cadeia.Substring(0, quantasPosicoes);
        }

        public String transformaString(String valor, int quantasPosicoes)
        {
            String cadeia = valor + "";
            while (cadeia.Length < quantasPosicoes)
                cadeia = cadeia + " ";
            return cadeia.Substring(0, quantasPosicoes);
        }

        public override string ToString()
        {
            return transformaString("pt", 5) +
                   transformaString(X, 5) +
                   transformaString(Y, 5) +
                   transformaString(Cor.R, 5) +
                   transformaString(Cor.G, 5) +
                   transformaString(Cor.B, 5);
        }

        public string FormatoDeRegistro()
        {
            return ToString();
        }
    }
}
