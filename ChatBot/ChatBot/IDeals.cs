using System;

namespace ChatBot
{
    class IDeals : ICommand
    {
        public void execute(Bot bot)
        {
            Console.WriteLine("В целом, неплохо. Ценю Ваше любопытство.");
            bot.push_back_msg(new Bot.Message("В целом, неплохо. Ценю Ваше любопытство."));
        }
    }
}
