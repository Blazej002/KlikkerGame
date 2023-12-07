using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerGame;

internal class Click : ICommand
{
    private Game _game;
    public char Character { get; } = ' ';

    public Click(Game game)
    {
        _game = game;
    }

    public void Run()
    {
        _game.Click();
    }
}