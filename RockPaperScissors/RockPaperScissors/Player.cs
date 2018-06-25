using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public abstract class Player
    {
        public string name;
        public int score;
        public string gesture;
        public bool twoPlayerGame;
        public List<string> gestures = new List<string>
        {
            "rock",
            "paper",
            "scissors",
            "lizard",
            "spock"
        };
        public void IncreaseScore()
        {
            score += 1;
        }
        public virtual string GestureCheck()
        {
            Console.WriteLine(this.name + ", please enter your move: \r\n (Rock, Paper, Scissors, Lizard, Spock)");
            string userInput = Console.ReadLine();
            if(twoPlayerGame == true)
            {
                Console.Clear();
            }
            switch (userInput.ToLower().Trim())
            {
                case "rock":
                    gesture = gestures[0];
                    return gestures[0];
                case "paper":
                    gesture = gestures[1];
                    return gestures[1];
                case "scissors":
                    gesture = gestures[2];
                    return gestures[2];
                case "lizard":
                    gesture = gestures[3];
                    return gestures[3];
                case "spock":
                    gesture = gestures[4];
                    return gestures[4];
                default:
                    return "Enter a valid choice, numbskull";

            }
        }
    }
}
