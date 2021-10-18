using System.Diagnostics;
namespace Bot_prjct
{
    public class Bot
    {
        private Chat talking;
        private string name;
        private Stopwatch time = new Stopwatch();
        public Bot(string name_)
        {
            name = name_;
            talking = new Chat();
            time.Start();
        }
        public void some_command(string comm)
        {
            talking.add_msg("Вы: " + comm);
            Manager work = new Manager(comm, this, talking);
        }
        public string get_name()
        {
            return name;
        }
        public string get_time()
        {
            return time.Elapsed.ToString();
        }
    }
}
