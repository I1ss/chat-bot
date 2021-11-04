
namespace ChatBot
{
    class ITimeInWork : ICommand
    {
        public void execute(Bot bot)
        {
            bot.push_back_msg(new Bot.Message(bot.show_time()));
        }
    }
}
