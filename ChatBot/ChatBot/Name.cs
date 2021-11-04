using System;

namespace ChatBot
{
    class Name : ICommand
    {
        public void execute(Bot bot)
        {
            Console.WriteLine("Арчи.");
            bot.push_back_msg(new Bot.Message("Арчи."));
        }
    }
}
