using System;

namespace Bot_prjct
{
    public class Message
    {
        private string space;
        private string time;
        public Message(string space_)
        {
            space = space_;
            time = DateTime.Now.ToString("HH:mm");
        }
        public string get_time()
        {
            return time;
        }
        public string get_msg()
        {
            return space;
        }
    }
}
