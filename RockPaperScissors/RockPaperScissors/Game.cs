using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        public class OnePlayerGame
        {
            Players.ComputerPlayer computerPlayer = new Players.ComputerPlayer();
            Gestures gestures = new Gestures();
            Players.HumanPlayer playerOne = new Players.HumanPlayer();

            public string computerGesture;
            public string playerMove;
            public string validGesture;
            public string playerOutcome;

            public void StartGame()
            {
                Console.WriteLine("Please Enter Your name: ");
                playerOne.playerName = Console.ReadLine();
                Console.WriteLine("Your opponite will be: " + computerPlayer.computerName);
                RunGame();
                bool playAgain = PlayAgain();
                if(playAgain)
                {
                    computerPlayer.computerScore = 0;
                    playerOne.playerScore = 0;
                    RunGame();
                    
                }
                else
                {
                    computerPlayer.computerScore = 0;
                    playerOne.playerScore = 0;
                    StartGame();
                }
                Console.ReadLine();

            }

            public void RunGame()
            {
                do
                {
                    Console.WriteLine("\r\n" + playerOne.playerName + " score is: " + playerOne.playerScore + " and " + computerPlayer.computerName + " score is: " + computerPlayer.computerScore);
                    Console.WriteLine("Please enter your move: \r\n (Rock, Paper, Scissors, Lizard, Spock)");
                    playerMove = Console.ReadLine();
                    validGesture = gestures.GestureCheck(playerMove);
                    computerGesture = computerPlayer.ComputerGesture();
                    playerOutcome = GameLogic(validGesture, computerGesture);
                    Scoreing(playerOutcome);
                }
                while (playerOne.playerScore < 2 && computerPlayer.computerScore < 2);
                if (playerOne.playerScore == 2)
                {
                    Console.WriteLine("\r\n" + playerOne.playerName + " is the winner!\r\n" + "Scores: \r\n" + playerOne.playerName + ": " + playerOne.playerScore + "\r\n" + computerPlayer.computerName + ": " + computerPlayer.computerScore);
                }
                else
                {
                    Console.WriteLine("\r\n" + computerPlayer.computerName + " is the winner!\r\n" + "Scores: \r\n" + playerOne.playerName + ": " + playerOne.playerScore + "\r\n" + computerPlayer.computerName + ": " + computerPlayer.computerScore);
                }
            }

            public bool PlayAgain()
            {
                Console.WriteLine("\r\nPlay Again?"+"\r\n"+"Enter: Yes, No");
                string playAgain = Console.ReadLine().ToLower().Trim();
                switch(playAgain)
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
                        Console.WriteLine("\r\n" + "This round resulted in " + playerOne.playerName + " Winning. Computer chose: " + computerGesture);
                        playerOne.IncreaseScore();
                        break;
                    case "lose":
                        Console.WriteLine("\r\n" + "This round resulted in " + computerPlayer.computerName + " Winning. Computer chose: " + computerGesture);
                        computerPlayer.IncreaseScore();
                        break;
                    default:
                        Console.WriteLine("\r\n"+"What is the matter with you? Pick a valid choice \r\n");
                        break;
                }
            }

            public string GameLogic(string playerOneMove, string computerMove)
            {
                switch (playerOneMove)
                {
                    case "rock":
                        if(computerMove == gestures.gestures[0])
                        {
                            return "tie";
                        }
                        else if(computerMove == gestures.gestures[1] || computerMove == gestures.gestures[4])
                        {
                            return "lose";
                        }
                        else
                        {
                            return "win";
                        }
                    case "paper":
                        if (computerMove == gestures.gestures[1])
                        {
                            return "tie";
                        }
                        else if (computerMove == gestures.gestures[2] || computerMove == gestures.gestures[3])
                        {
                            return "lose";
                        }
                        else
                        {
                            return "win";
                        }
                    case "scissors":
                        if (computerMove == gestures.gestures[2])
                        {
                            return "tie";
                        }
                        else if (computerMove == gestures.gestures[0] || computerMove == gestures.gestures[4])
                        {
                            return "lose";
                        }
                        else
                        {
                            return "win";
                        }
                    case "lizard":
                        if (computerMove == gestures.gestures[3])
                        {
                            return "tie";
                        }
                        else if (computerMove == gestures.gestures[2] || computerMove == gestures.gestures[1])
                        {
                            return "lose";
                        }
                        else
                        {
                            return "win";
                        }
                    case "spock":
                        if (computerMove == gestures.gestures[4])
                        {
                            return "tie";
                        }
                        else if (computerMove == gestures.gestures[1] || computerMove == gestures.gestures[3])
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

        public class TwoPlayerGame
        {
            Gestures gestures = new Gestures();
            Players.HumanPlayer playerOne = new Players.HumanPlayer();
            Players.HumanPlayer playerTwo = new Players.HumanPlayer();
        }

    }
}
