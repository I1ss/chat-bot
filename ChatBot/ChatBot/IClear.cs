using System;

namespace ChatBot
{
    class IClear : ICommand
    {
        public void execute(Bot bot)
        {
            Console.Clear();
        }
    }
}
