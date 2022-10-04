using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game_2
{
    class Food
    {
        public Point Posicao { get; private set; }

        public void CreateFood()
        {
            Random aleatorio = new Random();          

            Posicao = new Point(aleatorio.Next(0, 27), aleatorio.Next(0, 27));
            
        }


    }
}
