using System;

namespace Bot_prjct
{
    class Main_
    {
        static void Main(string[] args)
        {
            Bot Yuri = new Bot("Yuri");
            while (true)
            {
                string comm = Console.ReadLine();
                if (comm == "Стоп")
                {
                    break;
                }
                Yuri.some_command(comm);
            }
        }
    }
}
