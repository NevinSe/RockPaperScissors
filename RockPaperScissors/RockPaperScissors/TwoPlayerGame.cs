using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class TwoPlayerGame
    {
        Player playerOne = new HumanPlayer();
        HumanPlayer playerTwo = new HumanPlayer();

        public void StartGame()
        {
            Console.WriteLine("Player One, please enter your name: ");
            playerOne.name = Console.ReadLine();
            Console.WriteLine("Player Two, please enter your name: ");
            playerTwo.name = Console.ReadLine();

        }

        public void RunGame()
        {
            Console.WriteLine(playerOne.name + ", please enter your move.\r\n (Rock, Paper, Scissors, Lizard, Spock)");
            playerOne.gesture = Console.ReadLine();
            playerOne.GestureCheck(playerOne.gesture);
            Console.Clear();
            Console.WriteLine(playerTwo.name + ", please enter your move.\r\n (Rock, Paper, Scissors, Lizard, Spock)");
            playerTwo.gesture = Console.ReadLine();
        }
    }
}
