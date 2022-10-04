using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game_2
{
    class Snake
    {
        public int Tamanho { get; private set; }

        public Point[] Posicao { get; private set; }


        public Snake()
        {
            Posicao = new Point[28 * 28];
            Reset();
        }

        public void Reset()
        {
            Tamanho = 5;
            for (int i = 0; i < Tamanho; i++)
            {
                Posicao[i].X = 12;
                Posicao[i].Y = 12;
            }
        }

        public void Seguir()
        {
            for (int i = Tamanho - 1; i > 0; i--)
            {
                Posicao[i] = Posicao[i - 1];
            }
        }

        public void Cima()
        {
            Seguir();
            Posicao[0].Y--;
            if (Posicao[0].Y < 0)
            {
                Posicao[0].Y += 28;
            }
        }

        public void Baixo()
        {
            Seguir();
            Posicao[0].Y++;
            if (Posicao[0].Y > 27)
            {
                Posicao[0].Y -= 28;
            }
        }

        public void Esquerda()
        {
            Seguir();
            Posicao[0].X--;
            if (Posicao[0].X < 0)
            {
                Posicao[0].X += 28;
            }
        }

        public void Direita()
        {
            Seguir();
            Posicao[0].X++;
            if (Posicao[0].X > 27)
            {
                Posicao[0].X -= 28;
            }
        }


        public void Comer()
        {
            Tamanho++;
        }
    }
}
