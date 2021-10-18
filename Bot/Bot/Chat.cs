using System;
using System.Collections.Generic;

namespace Bot_prjct
{
    public class Chat
    {
        private List<Message> arr;
        public Chat(){
            arr = new List<Message>();
        }
        public void add_msg(string msg)
        {
            Message temp = new Message(msg);
            arr.Add(temp);
        }
        public void illustrate_chat()
        {
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i].get_time());
                Console.WriteLine(arr[i].get_msg());
                Console.WriteLine(" ");
            }
        }
    }
}
