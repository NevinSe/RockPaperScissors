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
        public string numberPlayers;

        public void MainGame()
        {
            Console.WriteLine("Enter how many players: \r\n (Enter 1 for one player, enter 2 for two players, or enter 3 to run a bot game)");
            numberPlayers = Console.ReadLine().Trim();

            switch (numberPlayers)
            {
                case "1":
                    playerOne = new Human();
                    playerTwo = new Computer();
                    Console.WriteLine("Please Enter Your name: ");
                    playerOne.name = Console.ReadLine();
                    Console.WriteLine("Your opponite will be: " + playerTwo.name);
                    playerOne.twoPlayerGame = false;
                    RunGame();
                    break;
                case "2":
                    playerOne = new Human();
                    playerTwo = new Human();
                    Console.WriteLine("Player One, please enter your name: ");
                    playerOne.name = Console.ReadLine();
                    Console.WriteLine("Player Two, please enter your name: ");
                    playerTwo.name = Console.ReadLine();
                    playerOne.twoPlayerGame = true;
                    playerTwo.twoPlayerGame = true;
                    RunGame();
                    break;
                case "3":
                    playerOne = new Computer();
                    Console.WriteLine(playerOne.name + ", will be the first bot. (press enter to continue)");
                    Console.ReadLine();
                    playerTwo = new Computer();
                    Console.WriteLine(playerTwo.name + ", will be the second bot. (press enter to continue)");
                    Console.ReadLine();
                    playerOne.twoPlayerGame = false;
                    playerTwo.twoPlayerGame = false;
                    RunGame();
                    break;
                default:
                    Console.WriteLine("------Enter a valid Choice you cow-handed ninnymuggins------\r\n");
                    MainGame();
                    break;


            }

        }
        public void RunGame()
        {
            do
            {
                Console.WriteLine("\r\n" + playerOne.name + " score is: " + playerOne.score + " and " + playerTwo.name + " score is: " + playerTwo.score);
                if (numberPlayers != "3")
                {
                    Scoreing(GameLogic(playerOne.GestureCheck(), playerTwo.GestureCheck()));
                }
                else
                {
                    string playerOneGesture = playerOne.GestureCheck();
                    Console.WriteLine("\r\n----Press enter to pit computers against each other----");
                    Console.ReadLine();
                    string playerTwoGesture = playerTwo.GestureCheck();
                    Scoreing(GameLogic(playerOneGesture, playerTwoGesture));
                }
            }
            while (playerOne.score < 2 && playerTwo.score < 2);
            DisplayWinner();
            PlayAgain();
            
        }

        public void DisplayWinner()
        {
            if (playerOne.score == 2)
            {
                Console.WriteLine("\r\n" + playerOne.name + " is the winner!\r\n" + "Scores: \r\n" + playerOne.name + ": " + playerOne.score + "\r\n" + playerTwo.name + ": " + playerTwo.score);
            }
            else
            {
                Console.WriteLine("\r\n" + playerTwo.name + " is the winner!\r\n" + "Scores: \r\n" + playerOne.name + ": " + playerOne.score + "\r\n" + playerTwo.name + ": " + playerTwo.score);
            }
        }
         public void PlayAgain()
        {
            string playAgain = PlayAgainCheck();
            if (playAgain == "yes")
            {
                playerTwo.score = 0;
                playerOne.score = 0;
                RunGame();

            }
            else if (playAgain == "no")
            {
                playerTwo.score = 0;
                playerOne.score = 0;
                MainGame();
            }
            else if (playAgain == "quit")
            {
                Environment.Exit(0);
            }
            else
                PlayAgainCheck();


        }

        public string PlayAgainCheck()
        {
            Console.WriteLine("\r\nPlay Again?" + "\r\n" + "Enter: Yes, No, or quit");
            string playAgain = Console.ReadLine().ToLower().Trim();
            switch (playAgain)
            {
                case "yes":
                    return "yes";
                case "no":
                    return "no";
                case "quit":
                    return "quit";
                default:
                    Console.WriteLine("\r\n----Why must you be diffcult?----\r\n");
                    return "null";
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
                    Console.WriteLine("\r\n" + "What is the matter with you? Pick a valid choice. \r\n");
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

