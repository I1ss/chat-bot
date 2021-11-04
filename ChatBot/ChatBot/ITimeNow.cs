using System;

namespace ChatBot
{
    class ITimeNow : ICommand
    {
        public void execute(Bot bot)
        {
            Console.WriteLine(DateTime.Now);
            bot.push_back_msg(new Bot.Message(DateTime.Now.ToString()));
        }
    }
}
