using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake_game_2
{
    class Game
    {
        public Keys Direcao { get; set; }
        public Keys Seta { get; set; }

        private Timer Frame { get; set; }

        private Label lbl_pontos { get; set; }

        private Panel pn_tela { get; set; }

        private int pontos = 0;

        private Food Food;

        private Snake Snake;

        private Bitmap offscremBitmap;

        private Graphics bitmapGraph;

        private Graphics screenGraph;

        public Game(ref Timer timer, ref Label label, ref Panel panel)
        {
            pn_tela = panel;
            Frame = timer;
            lbl_pontos = label;
            offscremBitmap = new Bitmap(428, 428);
            Snake = new Snake();
            Food = new Food();
            Direcao = Keys.Left;
            Seta = Direcao;

        }

        public void comecarJogo()
        {
            Snake.Reset();
            Food.CreateFood();
            Direcao = Keys.Left;
            bitmapGraph = Graphics.FromImage(offscremBitmap);
            screenGraph = pn_tela.CreateGraphics();
            Frame.Enabled = true;
        }

        public void Tick()
        {
            if (((Seta == Keys.Left) && (Direcao != Keys.Right)) ||
                ((Seta == Keys.Right) && (Direcao != Keys.Left)) ||
                ((Seta == Keys.Up) && (Direcao != Keys.Down)) ||
                ((Seta == Keys.Down) && (Direcao != Keys.Up)))
            {
                Direcao = Seta;
            }

            switch (Direcao)
            {
                case Keys.Left:
                    Snake.Esquerda();
                    break;

                case Keys.Right:
                    Snake.Direita();
                    break;

                case Keys.Up:
                    Snake.Cima();
                    break;

                case Keys.Down:
                    Snake.Baixo();
                    break;
            }

            bitmapGraph.Clear(Color.White);

            bitmapGraph.DrawImage(Properties.Resources.bolinho, (Food.Posicao.X * 15), (Food.Posicao.Y * 15), 15, 15);
            bool gameOver = false;

            for (int i = 0; i < Snake.Tamanho; i++)
            {
                if (i == 0)
                {
                    bitmapGraph.FillEllipse(new SolidBrush(ColorTranslator.FromHtml("#228B22")), (Snake.Posicao[i].X * 15), (Snake.Posicao[i].Y * 15), 15, 15);
                }
                else
                {
                    bitmapGraph.FillEllipse(new SolidBrush(ColorTranslator.FromHtml("#32CD32")), (Snake.Posicao[i].X * 15), (Snake.Posicao[i].Y * 15), 15, 15);
                }

                if ((Snake.Posicao[i] == Snake.Posicao[0]) && (i > 0))
                {
                    gameOver = true;
                }
            }

            screenGraph.DrawImage(offscremBitmap, 0, 0);
            ChecarColisao();
            if (gameOver)
            {
                GameOver();
            }
        }

        public void ChecarColisao()
        {
            if (Snake.Posicao[0] == Food.Posicao)
            {
                Snake.Comer();
                Food.CreateFood();
                pontos += 1;
                lbl_pontos.Text = "pontinhos: " + pontos;
            }
        }

        public void GameOver()
        {
            Frame.Enabled = false;
            bitmapGraph.Dispose();
            screenGraph.Dispose();
            lbl_pontos.Text = "pontos: 0";
            MessageBox.Show("perdeu ruim | total de pontos = " + pontos);
            pontos = 0;
        }
    }
}
