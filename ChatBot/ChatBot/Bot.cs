using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ChatBot
{
    class Bot
    {
        public List<Message> chat = new List<Message>();
        private Stopwatch time = new Stopwatch();
        public class Message
        {
            public String info;
            public DateTime time;
            public Message(String info_)
            {
                this.info = info_;
                this.time = DateTime.Now;
            }
        }
        public Bot()
        {
            time.Start();
        }
        public void push_back_msg(Message msg)
        {
            chat.Add(msg);
        }
        public void work(ICommand command)
        {
            command.execute(this);
        }
        public String show_time()
        {
            Console.WriteLine(time.Elapsed.ToString());
            return time.Elapsed.ToString();
        }
    }
}
