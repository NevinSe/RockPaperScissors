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

        public void MainGame()
        {
            Console.WriteLine("Enter how many players: \r\n (1 player, 2 players)");
            string numberPlayers = Console.ReadLine().Trim();

            switch (numberPlayers)
            {
                case "1":
                    playerOne = new HumanPlayer();
                    playerTwo = new ComputerPlayer();
                    Console.WriteLine("Please Enter Your name: ");
                    playerOne.name = Console.ReadLine();
                    Console.WriteLine("Your opponite will be: " + playerTwo.name);
                    playerOne.twoPlayerGame = false;
                    RunGame();
                    break;
                case "2":
                    playerOne = new HumanPlayer();
                    playerTwo = new HumanPlayer();
                    Console.WriteLine("Player One, please enter your name: ");
                    playerOne.name = Console.ReadLine();
                    Console.WriteLine("Player Two, please enter your name: ");
                    playerTwo.name = Console.ReadLine();
                    playerOne.twoPlayerGame = true;
                    playerTwo.twoPlayerGame = true;
                    RunGame();
                    break;
                default:
                    break;


            }

        }
        public void RunGame()
        {
            do
            {
                Console.WriteLine("\r\n" + playerOne.name + " score is: " + playerOne.score + " and " + playerTwo.name + " score is: " + playerTwo.score);
                Scoreing(GameLogic(playerOne.GestureCheck(), playerTwo.GestureCheck()));
            }
            while (playerOne.score < 2 && playerTwo.score < 2);
            if (playerOne.score == 2)
            {
                Console.WriteLine("\r\n" + playerOne.name + " is the winner!\r\n" + "Scores: \r\n" + playerOne.name + ": " + playerOne.score + "\r\n" + playerTwo.name + ": " + playerTwo.score);
            }
            else
            {
                Console.WriteLine("\r\n" + playerTwo.name + " is the winner!\r\n" + "Scores: \r\n" + playerOne.name + ": " + playerOne.score + "\r\n" + playerTwo.name + ": " + playerTwo.score);
            }
            bool playAgain = PlayAgain();
            if (playAgain)
            {
                playerTwo.score = 0;
                playerOne.score = 0;
                RunGame();

            }
            else
            {
                playerTwo.score = 0;
                playerOne.score = 0;
                MainGame();
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
                    Console.WriteLine("\r\n" + "This resulted in a tie.\r\n" + playerOne.name + " chose: " + playerOne.gesture + "\r\n" + playerTwo.name+ " chose: " + playerTwo.gesture);
                    break;
                case "win":
                    Console.WriteLine("\r\n" + "This round resulted in " + playerOne.name + " Winning.\r\n"+playerOne.name+" chose: " + playerOne.gesture + "\r\n" + playerTwo.name+ " chose: " + playerTwo.gesture);
                    playerOne.IncreaseScore();
                    break;
                case "lose":
                    Console.WriteLine("\r\n" + "This round resulted in " + playerTwo.name + " Winning.\r\n" + playerOne.name + " chose: " + playerOne.gesture + "\r\n" + playerTwo.name + " chose: " + playerTwo.gesture);
                    playerTwo.IncreaseScore();
                    break;
                default:
                    Console.WriteLine("\r\n" + "What is the matter with you? Pick a valid choice \r\n");
                    break;
            }
        }

        public string GameLogic(string playerOneMove, string playerTwoMove)
        {
            switch (playerOneMove)
            {
                case "rock":
                    if (playerTwoMove == playerTwo.gestures[0])
                    {
                        return "tie";
                    }
                    else if (playerTwoMove == playerTwo.gestures[1] || playerTwoMove == playerTwo.gestures[4])
                    {
                        return "lose";
                    }
                    else
                    {
                        return "win";
                    }
                case "paper":
                    if (playerTwoMove == playerTwo.gestures[1])
                    {
                        return "tie";
                    }
                    else if (playerTwoMove == playerTwo.gestures[2] || playerTwoMove == playerTwo.gestures[3])
                    {
                        return "lose";
                    }
                    else
                    {
                        return "win";
                    }
                case "scissors":
                    if (playerTwoMove == playerTwo.gestures[2])
                    {
                        return "tie";
                    }
                    else if (playerTwoMove == playerTwo.gestures[0] || playerTwoMove == playerTwo.gestures[4])
                    {
                        return "lose";
                    }
                    else
                    {
                        return "win";
                    }
                case "lizard":
                    if (playerTwoMove == playerTwo.gestures[3])
                    {
                        return "tie";
                    }
                    else if (playerTwoMove == playerTwo.gestures[2] || playerTwoMove == playerTwo.gestures[1])
                    {
                        return "lose";
                    }
                    else
                    {
                        return "win";
                    }
                case "spock":
                    if (playerTwoMove == playerTwo.gestures[4])
                    {
                        return "tie";
                    }
                    else if (playerTwoMove == playerTwo.gestures[1] || playerTwoMove == playerTwo.gestures[3])
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

