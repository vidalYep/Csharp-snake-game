
namespace snake_game_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_pontos = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menuzinhoBalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.começarOJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairDoJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Frame = new System.Windows.Forms.Timer(this.components);
            this.pn_tela = new System.Windows.Forms.Panel();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_pontos
            // 
            this.lbl_pontos.Location = new System.Drawing.Point(1, 47);
            this.lbl_pontos.Name = "lbl_pontos";
            this.lbl_pontos.Size = new System.Drawing.Size(428, 21);
            this.lbl_pontos.TabIndex = 0;
            this.lbl_pontos.Text = "Pontinhos: 0";
            this.lbl_pontos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Menu
            // 
            this.Menu.Font = new System.Drawing.Font("Futura-Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuzinhoBalaToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(429, 29);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "menuStrip1";
            // 
            // menuzinhoBalaToolStripMenuItem
            // 
            this.menuzinhoBalaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.começarOJogoToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairDoJogoToolStripMenuItem});
            this.menuzinhoBalaToolStripMenuItem.Name = "menuzinhoBalaToolStripMenuItem";
            this.menuzinhoBalaToolStripMenuItem.Size = new System.Drawing.Size(176, 25);
            this.menuzinhoBalaToolStripMenuItem.Text = "Menuzinho bala";
            this.menuzinhoBalaToolStripMenuItem.Click += new System.EventHandler(this.menuzinhoBalaToolStripMenuItem_Click);
            // 
            // começarOJogoToolStripMenuItem
            // 
            this.começarOJogoToolStripMenuItem.Name = "começarOJogoToolStripMenuItem";
            this.começarOJogoToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.começarOJogoToolStripMenuItem.Text = "Comecar o jogo ";
            this.começarOJogoToolStripMenuItem.Click += new System.EventHandler(this.começarOJogoToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(238, 6);
            // 
            // sairDoJogoToolStripMenuItem
            // 
            this.sairDoJogoToolStripMenuItem.Name = "sairDoJogoToolStripMenuItem";
            this.sairDoJogoToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.sairDoJogoToolStripMenuItem.Text = "Sair do jogo";
            this.sairDoJogoToolStripMenuItem.Click += new System.EventHandler(this.sairDoJogoToolStripMenuItem_Click_1);
            // 
            // Frame
            // 
            this.Frame.Tick += new System.EventHandler(this.Frame_Tick);
            // 
            // pn_tela
            // 
            this.pn_tela.BackgroundImage = global::snake_game_2.Properties.Resources.ah__2_;
            this.pn_tela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pn_tela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_tela.Location = new System.Drawing.Point(1, 71);
            this.pn_tela.Name = "pn_tela";
            this.pn_tela.Size = new System.Drawing.Size(428, 428);
            this.pn_tela.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 498);
            this.Controls.Add(this.pn_tela);
            this.Controls.Add(this.lbl_pontos);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Futura-Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da cobrinha :)";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Clicado);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pontos;
        private System.Windows.Forms.Panel pn_tela;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem menuzinhoBalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem começarOJogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairDoJogoToolStripMenuItem;
        private System.Windows.Forms.Timer Frame;
    }
}

