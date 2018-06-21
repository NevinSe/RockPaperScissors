using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class HumanPlayer : Player
    {


        public HumanPlayer()
        {
            this.name = "TBD";
            this.score = 0;
        }

        public void IncreaseScore()
        {
            score += 1;
        }

        public override string GestureCheck(string userInput)
        {
            switch (userInput.ToLower().Trim())
            {
                case "rock":
                    return gestures[0];
                case "paper":
                    return gestures[1];
                case "scissors":
                    return gestures[2];
                case "lizard":
                    return gestures[3];
                case "spock":
                    return gestures[4];
                default:
                    return "Enter a valid choice, numbskull";

            }
        }

    }
}
