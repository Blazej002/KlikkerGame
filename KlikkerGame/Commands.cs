namespace KlikkerGame
{
     class Commands
    {
        private ICommand[] _commands;

        public Commands(Game clickerGame)
        {
            _commands = new ICommand[]
            {
                new Exit(),
                new Click(clickerGame),
                new Uppgrade(clickerGame),
                new SuperUppgrade(clickerGame)
            };
        }

        public void Run(char commandChar)
        {
            var command = findCommand(commandChar);
            command.Run();
        }

        private ICommand findCommand(char commandChar)
        {
            foreach (var command in _commands)
            {
                if (command.Character == commandChar)
                {
                    return command;
                }
            }

            return null;
        }
    }
}
