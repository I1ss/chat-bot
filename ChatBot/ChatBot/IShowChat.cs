using System;

namespace ChatBot
{
    class IShowChat : ICommand
    {
        public void execute(Bot bot) {
            for (int i = 0; i < bot.chat.Count; i++)
            {
                Console.WriteLine(bot.chat[i].time);
                Console.WriteLine(bot.chat[i].info);
            }
        }
    }
}
