using System;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Bot temp = new Bot();
            while (true)
            {
                string comm = Console.ReadLine();
                if (comm == "стоп")
                {
                    break;
                }
                else if (comm == "сколько сейчас времени?")
                {
                    temp.work(new ITimeNow());
                }
                else if (comm == "как тебя зовут?")
                {
                    temp.work(new Name());
                }
                else if (comm == "как дела?")
                {
                    temp.work(new IDeals());
                }
                else if (comm == "сколько времени ты работаешь?")
                {
                    temp.work(new ITimeInWork());
                }
                else if (comm == "покажи нашу переписку?")
                {
                    temp.work(new IShowChat());
                }
                else if (comm == "очисти экран")
                {
                    temp.work(new IClear());
                }
                else if (comm == "помощь")
                {
                    Console.WriteLine("Команды:\n1) 'сколько сейчас времени?'\n2) 'как тебя зовут?'\n3) 'как дела?'\n4) 'сколько времени ты работаешь?'\n5) 'покажи нашу переписку?'\n6) 'очисти экран'\n7) 'стоп'");
                    temp.push_back_msg(new Bot.Message("Команды:\n1) 'сколько сейчас времени?'\n2) 'как тебя зовут?'\n3) 'как дела?'\n4) 'сколько времени ты работаешь?'\n5) 'покажи нашу переписку?'\n6) 'очисти экран'\n7) 'стоп'"));
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректную команду. Введите 'помощь', если забыли команды.");
                }
                temp.push_back_msg(new Bot.Message(comm));
            }
        }
    }
}
