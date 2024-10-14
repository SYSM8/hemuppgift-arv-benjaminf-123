using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.game
{
    public class ComputerPlayer : Player
    {
        private Random random;

        public ComputerPlayer(string name) : base(name)
        {
            random = new Random();
        }
        public override int TakePins(Board board)
        {
            int pins = random.Next(1, 3);
            Console.WriteLine($"{Name} tog {pins} stickor.");
            return pins;

        }
    }
}
