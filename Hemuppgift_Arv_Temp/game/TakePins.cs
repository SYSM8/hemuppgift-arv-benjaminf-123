using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.game
{
    public class TakePinsGame
    {
        
        static void Main(string[] args)
        {
            
            StartGame();
        }

        
        public static void StartGame()
        {
            Board board = new Board(10); 

            
            Player player1 = new HumanPlayer("Spelare 1");
            Player player2 = new ComputerPlayer("Datorn");

            Player currentPlayer = player1; 
            while (board.GetSticks() > 0)
            {
                Console.WriteLine($"Det finns {board.GetSticks()} stickor kvar. Den som drar sista stickan vinner");

                
                int takenPins = currentPlayer.TakePins(board);

                
                board.RemoveSticks(takenPins);

                
                if (board.GetSticks() == 0)
                {
                    Console.WriteLine($"{currentPlayer.Name} vinner!");
                    break;
                }

                
                currentPlayer = (currentPlayer == player1) ? player2 : player1;
            }
        }
    }
}
