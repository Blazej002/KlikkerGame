using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerGame
{
    internal class SuperUppgrade:ICommand
    {
        private Game _game;
        public char Character { get; } = 's';

        public SuperUppgrade(Game game)
        {
            _game = game;
        }
        public void Run()
        {
            _game.SuperUppg();
        }
    }
}
