namespace KlikkerGame
{
    internal class Uppgrade: ICommand
    {
        private Game _game;

        public char Character { get; } = 'k';

        public Uppgrade(Game game)
        {
            _game = game;
        }
        public void Run()
        {
            _game.Uppgrade();
        }
    }
}
