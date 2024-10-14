using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.game
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {

        }
        public override int TakePins(Board board)
        {
            int pins;
            do
            {
                Console.WriteLine($"{Name}, hur många stickor vill du ta? (1 eller 2)");
                if (int.TryParse(Console.ReadLine(), out pins) && (pins == 1 || pins == 2))
                {
                    break;
                }
                Console.WriteLine("Ogiltigt val, välj igen");
            }
            while (true);
            return pins;
        }
    }

}
