using System;

namespace Bot_prjct
{
    public class Command
    {
        public string info_time()
        {
            string answer = DateTime.Now.ToString();
            return "Текущее время: " + answer;
        }
        public string info_name(string name)
        {
            return "Моё имя: " + name;
        }
        public string info_feels()
        {
            int rand = new Random().Next(1, 4);
            if (rand == 1)
            {
                return "Всё хорошо, спасибо.";
            }
            else if (rand == 2)
            {
                return "В целом, неплохо. Ценю Ваше любопытство.";
            }
            else if (rand == 3)
            {
                return "Боюсь, я лишь программа и ответить честно не смогу.";
            }
            return null;
        }
        public string info_work(Bot bot)
        {
            return bot.get_time();
        }
        public void clear()
        {
            Console.Clear();
        }
        public void info_talking(Chat chat)
        {
            chat.illustrate_chat();
        }
        public string info_help()
        {
            string ans = "Допустимые команды:\n1. Сколько сейчас времени?\n2. Как тебя зовут?\n3. Как дела?\n4. Сколько ты работаешь?\n5. Покажи нашу переписку\n6. Очисти экран\n7. Стоп";
            return ans;
        }
    }
}
