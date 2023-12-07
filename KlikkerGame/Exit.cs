using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerGame
{
    internal class Exit : ICommand
    {
        public char Character { get; } = 'x';
        public void Run()
        {
            Environment.Exit(0);
        }
    }
}
