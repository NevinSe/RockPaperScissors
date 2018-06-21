using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        Player playerOne;
        Player playerTwo;

        public string computerGesture;
        public string playerMove;
        public string validGesture;
        public string playerOutcome;


        public void StartOnePlayerGame()
        {
            playerOne = new HumanPlayer();
            playerTwo = new ComputerPlayer();
            Console.WriteLine("Please Enter Your name: ");
            playerOne.name = Console.ReadLine();
            Console.WriteLine("Your opponite will be: " + playerTwo.name);
            RunOnePlayerGame();
            bool playAgain = PlayAgain();
            if (playAgain)
            {
                playerTwo.score = 0;
                playerOne.score = 0;
                RunOnePlayerGame();

            }
            else
            {
                playerTwo.score = 0;
                playerOne.score = 0;
                StartOnePlayerGame();
            }
            Console.ReadLine();

        }
        public void RunOnePlayerGame()
        {
            do
            {
                Console.WriteLine("\r\n" + playerOne.name + " score is: " + playerOne.score + " and " + computerPlayer.name + " score is: " + computerPlayer.score);
                Console.WriteLine("Please enter your move: \r\n (Rock, Paper, Scissors, Lizard, Spock)");
                playerMove = Console.ReadLine();
                validGesture = playerOne.GestureCheck(playerMove);
                computerGesture = playerTwo.ComputerGesture();
                playerOutcome = GameLogic(validGesture, computerGesture);
                Scoreing(playerOutcome);
            }
            while (playerOne.score < 2 && playerTwo.score < 2);
            if (playerOne.score == 2)
            {
                Console.WriteLine("\r\n" + playerOne.name + " is the winner!\r\n" + "Scores: \r\n" + playerOne.name + ": " + playerOne.score + "\r\n" + computerPlayer.name + ": " + computerPlayer.score);
            }
            else
            {
                Console.WriteLine("\r\n" + computerPlayer.name + " is the winner!\r\n" + "Scores: \r\n" + playerOne.name + ": " + playerOne.score + "\r\n" + computerPlayer.name + ": " + computerPlayer.score);
            }
        }

        public bool PlayAgain()
        {
            Console.WriteLine("\r\nPlay Again?" + "\r\n" + "Enter: Yes, No");
            string playAgain = Console.ReadLine().ToLower().Trim();
            switch (playAgain)
            {
                case "yes":
                    return true;
                case "no":
                    return false;
                default:
                    return false;
            }

        }

        public void Scoreing(string outcome)
        {
            switch (outcome)
            {
                case "tie":
                    Console.WriteLine("\r\n" + "This resulted in a tie, computer chose: " + computerGesture);
                    break;
                case "win":
                    Console.WriteLine("\r\n" + "This round resulted in " + playerOne.name + " Winning. Computer chose: " + computerGesture);
                    playerOne.IncreaseScore();
                    break;
                case "lose":
                    Console.WriteLine("\r\n" + "This round resulted in " + computerPlayer.name + " Winning. Computer chose: " + computerGesture);
                    computerPlayer.IncreaseScore();
                    break;
                default:
                    Console.WriteLine("\r\n" + "What is the matter with you? Pick a valid choice \r\n");
                    break;
            }
        }

        public string GameLogic(string playerOneMove, string computerMove)
        {
            switch (playerOneMove)
            {
                case "rock":
                    if (computerMove == computerPlayer.gestures[0])
                    {
                        return "tie";
                    }
                    else if (computerMove == computerPlayer.gestures[1] || computerMove == computerPlayer.gestures[4])
                    {
                        return "lose";
                    }
                    else
                    {
                        return "win";
                    }
                case "paper":
                    if (computerMove == computerPlayer.gestures[1])
                    {
                        return "tie";
                    }
                    else if (computerMove == computerPlayer.gestures[2] || computerMove == computerPlayer.gestures[3])
                    {
                        return "lose";
                    }
                    else
                    {
                        return "win";
                    }
                case "scissors":
                    if (computerMove == computerPlayer.gestures[2])
                    {
                        return "tie";
                    }
                    else if (computerMove == computerPlayer.gestures[0] || computerMove == computerPlayer.gestures[4])
                    {
                        return "lose";
                    }
                    else
                    {
                        return "win";
                    }
                case "lizard":
                    if (computerMove == computerPlayer.gestures[3])
                    {
                        return "tie";
                    }
                    else if (computerMove == computerPlayer.gestures[2] || computerMove == computerPlayer.gestures[1])
                    {
                        return "lose";
                    }
                    else
                    {
                        return "win";
                    }
                case "spock":
                    if (computerMove == computerPlayer.gestures[4])
                    {
                        return "tie";
                    }
                    else if (computerMove == computerPlayer.gestures[1] || computerMove == computerPlayer.gestures[3])
                    {
                        return "lose";
                    }
                    else
                    {
                        return "win";
                    }
                default:
                    return "null";
            }
        }

    }

}
}
