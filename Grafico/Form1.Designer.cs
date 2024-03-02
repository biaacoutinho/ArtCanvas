namespace Grafico
{
    partial class frmGrafico
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrafico));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAbrir = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnLimpar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPonto = new System.Windows.Forms.ToolStripButton();
            this.btnReta = new System.Windows.Forms.ToolStripButton();
            this.btnCirculo = new System.Windows.Forms.ToolStripButton();
            this.btnEllipse = new System.Windows.Forms.ToolStripButton();
            this.btnRetangulo = new System.Windows.Forms.ToolStripButton();
            this.btnPolilinha = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.stMensagem = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.dlgSalvar = new System.Windows.Forms.SaveFileDialog();
            this.pbAreaDesenho = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.stMensagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAreaDesenho)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbrir,
            this.btnSalvar,
            this.btnLimpar,
            this.toolStripSeparator1,
            this.btnPonto,
            this.btnReta,
            this.btnCirculo,
            this.btnEllipse,
            this.btnRetangulo,
            this.btnPolilinha,
            this.toolStripSeparator2,
            this.btnCor,
            this.toolStripSeparator3,
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(803, 92);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.Color.Firebrick;
            this.btnAbrir.Image = global::Grafico.Properties.Resources.Abrir;
            this.btnAbrir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(64, 89);
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSalvar.Image = global::Grafico.Properties.Resources.Salvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(64, 89);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.ForeColor = System.Drawing.Color.Firebrick;
            this.btnLimpar.Image = global::Grafico.Properties.Resources.Limpar;
            this.btnLimpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(66, 89);
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 92);
            // 
            // btnPonto
            // 
            this.btnPonto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPonto.ForeColor = System.Drawing.Color.Firebrick;
            this.btnPonto.Image = global::Grafico.Properties.Resources.Ponto;
            this.btnPonto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(64, 89);
            this.btnPonto.Text = "Ponto";
            this.btnPonto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPonto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // btnReta
            // 
            this.btnReta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReta.ForeColor = System.Drawing.Color.Firebrick;
            this.btnReta.Image = global::Grafico.Properties.Resources.Linha;
            this.btnReta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReta.Name = "btnReta";
            this.btnReta.Size = new System.Drawing.Size(64, 89);
            this.btnReta.Text = "Reta";
            this.btnReta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReta.Click += new System.EventHandler(this.btnReta_Click);
            // 
            // btnCirculo
            // 
            this.btnCirculo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCirculo.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCirculo.Image = global::Grafico.Properties.Resources.circulo;
            this.btnCirculo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCirculo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(68, 89);
            this.btnCirculo.Text = "Circulo";
            this.btnCirculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEllipse.ForeColor = System.Drawing.Color.Firebrick;
            this.btnEllipse.Image = global::Grafico.Properties.Resources.Ellipse;
            this.btnEllipse.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(64, 89);
            this.btnEllipse.Text = "Elipse";
            this.btnEllipse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnRetangulo
            // 
            this.btnRetangulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetangulo.ForeColor = System.Drawing.Color.Firebrick;
            this.btnRetangulo.Image = global::Grafico.Properties.Resources.Retangulo;
            this.btnRetangulo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRetangulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRetangulo.Name = "btnRetangulo";
            this.btnRetangulo.Size = new System.Drawing.Size(92, 89);
            this.btnRetangulo.Text = "Retangulo";
            this.btnRetangulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRetangulo.Click += new System.EventHandler(this.btnRetangulo_Click);
            // 
            // btnPolilinha
            // 
            this.btnPolilinha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolilinha.ForeColor = System.Drawing.Color.Firebrick;
            this.btnPolilinha.Image = global::Grafico.Properties.Resources.polilinha;
            this.btnPolilinha.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPolilinha.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPolilinha.Name = "btnPolilinha";
            this.btnPolilinha.Size = new System.Drawing.Size(79, 89);
            this.btnPolilinha.Text = "Polilinha";
            this.btnPolilinha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPolilinha.Click += new System.EventHandler(this.btnPolilinha_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 92);
            // 
            // btnCor
            // 
            this.btnCor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCor.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCor.Image = global::Grafico.Properties.Resources.cor;
            this.btnCor.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCor.Name = "btnCor";
            this.btnCor.Size = new System.Drawing.Size(64, 89);
            this.btnCor.Text = "Cor";
            this.btnCor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCor.Click += new System.EventHandler(this.btnCor_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 92);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSair.Image = global::Grafico.Properties.Resources.sair;
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(64, 89);
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // stMensagem
            // 
            this.stMensagem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stMensagem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.stMensagem.Location = new System.Drawing.Point(0, 510);
            this.stMensagem.Name = "stMensagem";
            this.stMensagem.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.stMensagem.Size = new System.Drawing.Size(803, 22);
            this.stMensagem.TabIndex = 2;
            this.stMensagem.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Firebrick;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel1.Text = "Mensagem:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(89, 17);
            this.toolStripStatusLabel2.Text = "sem mensagem";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.Firebrick;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(89, 17);
            this.toolStripStatusLabel3.Text = "Coordenada:";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(21, 17);
            this.toolStripStatusLabel4.Text = "x,y";
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.FileName = "openFileDialog1";
            // 
            // pbAreaDesenho
            // 
            this.pbAreaDesenho.BackColor = System.Drawing.Color.White;
            this.pbAreaDesenho.Location = new System.Drawing.Point(13, 96);
            this.pbAreaDesenho.Margin = new System.Windows.Forms.Padding(4);
            this.pbAreaDesenho.Name = "pbAreaDesenho";
            this.pbAreaDesenho.Size = new System.Drawing.Size(777, 410);
            this.pbAreaDesenho.TabIndex = 1;
            this.pbAreaDesenho.TabStop = false;
            this.pbAreaDesenho.Paint += new System.Windows.Forms.PaintEventHandler(this.pbAreaDesenho_Paint);
            this.pbAreaDesenho.DoubleClick += new System.EventHandler(this.pbAreaDesenho_DoubleClick_1);
            this.pbAreaDesenho.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbAreaDesenho_MouseClick);
            this.pbAreaDesenho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbAreaDesenho_MouseMove);
            // 
            // frmGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(803, 532);
            this.ControlBox = false;
            this.Controls.Add(this.stMensagem);
            this.Controls.Add(this.pbAreaDesenho);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGrafico";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor Grafico";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.stMensagem.ResumeLayout(false);
            this.stMensagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAreaDesenho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox pbAreaDesenho;
        private System.Windows.Forms.StatusStrip stMensagem;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
        private System.Windows.Forms.SaveFileDialog dlgSalvar;
        private System.Windows.Forms.ToolStripButton btnAbrir;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnPonto;
        private System.Windows.Forms.ToolStripButton btnReta;
        private System.Windows.Forms.ToolStripButton btnCirculo;
        private System.Windows.Forms.ToolStripButton btnEllipse;
        private System.Windows.Forms.ToolStripButton btnRetangulo;
        private System.Windows.Forms.ToolStripButton btnPolilinha;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnCor;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripButton btnLimpar;
    }
}

