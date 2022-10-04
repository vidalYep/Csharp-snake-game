using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake_game_2
{
    public partial class Form1 : Form
    {
        Game Game;
        public Form1()
        {
            InitializeComponent();
            Game = new Game(ref Frame, ref lbl_pontos, ref pn_tela);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void inicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           
        }

        private void Clicado(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                Game.Seta = e.KeyCode;
            }
        }

        private void começarOJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sairDoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_pontos_Click(object sender, EventArgs e)
        {

        }

        private void menuzinhoBalaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void começarOJogoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Game.comecarJogo();
        }

        private void sairDoJogoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frame_Tick(object sender, EventArgs e)
        {
            Game.Tick();
        }
    }
}
