using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerGame
{
    internal class Game
    {
        public int Points { get; private set; } = 0;
        private int _pointsPerClick = 1;
        private int _increment = 1;

        public void Click()
        {
            Points += _pointsPerClick;
        }

        public void Uppgrade()
        {
            if(Points <10) return;
            Points -= 10;
            _pointsPerClick += _increment;
        }

        public void SuperUppg()
        {
            if (Points < 100) return;
            Points -= 100;
            _increment++;
        }
    }
}
