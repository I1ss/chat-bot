using System;

namespace Bot_prjct
{
    public class Manager
    {
        public Manager(string comm, Bot bot, Chat talking)
        {
            execute(comm, bot, talking);
        }
        private void execute(string comm, Bot bot, Chat chat)
        {
            if (comm == "Сколько сейчас времени?")
            {
                string temp = new Command().info_time();
                Console.WriteLine(temp);
                chat.add_msg(bot.get_name() + ": " + temp);
            }
            else if (comm == "Как тебя зовут?")
            {
                string temp = new Command().info_name(bot.get_name());
                Console.WriteLine(temp);
                chat.add_msg(bot.get_name() + ": " + temp);
            }
            else if (comm == "Как дела?")
            {
                string temp = new Command().info_feels();
                Console.WriteLine(temp);
                chat.add_msg(bot.get_name() + ": " + temp);
            }
            else if (comm == "Сколько времени ты работаешь?")
            {
                string temp = new Command().info_work(bot);
                Console.WriteLine(temp);
                chat.add_msg(bot.get_name() + ": " + temp);
            }
            else if (comm == "Покажи нашу переписку")
            {
                new Command().info_talking(chat);
            }
            else if (comm == "Очисти экран")
            {
                new Command().clear();
            }
            else if (comm == "Помощь")
            {
                string temp = new Command().info_help();
                Console.WriteLine(temp);
                chat.add_msg(bot.get_name() + ": " + temp);
            }
            else
            {
                Console.WriteLine("Боюсь, я не понимаю Вас. Используйте только задокументированные команды (введите 'Помощь', если забыли их).");
                chat.add_msg(bot.get_name() + ": " + "Боюсь, я не понимаю Вас. Используйте только задокументированные команды (введите 'Помощь', если забыли их).");
            }
        }
    }
}
