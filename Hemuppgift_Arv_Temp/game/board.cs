using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.game
{
    public class Board
    {
        private int sticks;
        public Board(int initalSticks)
        {
            sticks = initalSticks;
        }
        public int GetSticks()
        {
            return sticks;
        }
        public void RemoveSticks(int num)
        {
            if (num > 0 && num <= sticks)
            {
                sticks -= num;
            }
            else
            {
                throw new ArgumentException("Ogiltigt antal stickor");
            }

        }
    }
}

