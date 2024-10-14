using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.game
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(string name) : base(name)
        {
        }

        public override int TakePins(Board board)
        {
            int remainingSticks = board.GetSticks();

            if (remainingSticks % 3 == 0)
            {
                Console.WriteLine($"{Name} tog 2 stickor.");
                return 2;
            }
            else
            {
                Console.WriteLine($"{Name} tog 1 sticka.");
                return 1;
            }
        }
    }
}