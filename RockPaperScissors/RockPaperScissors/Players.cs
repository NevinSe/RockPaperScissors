using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Players
    {
        public class HumanPlayer : Players
        {
            public string playerName;
            public int playerScore;

            public HumanPlayer()
            {
                this.playerName = "TBD";
                this.playerScore = 0;
            }

            public void IncreaseScore()
            {
                playerScore += 1;
            }

        }
        public class ComputerPlayer : Players
        {
            public string computerName;
            public int computerScore = 0;
            public ComputerPlayer()
            {
                this.computerName = RandomComputerName();

            }

            public void IncreaseScore()
            {
                computerScore += 1;
            }

            public int ComputerGesturePicker()
            {
                Random rng = new Random();
                int gestureChoice  = rng.Next(0, 4);
                return gestureChoice;
            }

            public string ComputerGesture()
            {
                switch(ComputerGesturePicker())
                {
                    case 0:
                        return "rock";
                    case 1:
                        return "paper";
                    case 2:
                        return "scissors";
                    case 3:
                        return "lizard";
                    case 4:
                        return "spock";
                    default:
                        return "Invalid Gesture";
                }
            }

            public string RandomComputerName()
            {
                string switchCaseName;
                Random rng = new Random();
                int nameCase = rng.Next(1, 10);

                switch (nameCase)
                {
                    case 1:
                        switchCaseName = "Henry";
                        return switchCaseName;
                    case 2:
                        switchCaseName = "Dylan";
                        return switchCaseName;
                    case 3:
                        switchCaseName = "Ryan";
                        return switchCaseName;
                    case 4:
                        switchCaseName = "Matt";
                        return switchCaseName;
                    case 5:
                        switchCaseName = "Logan";
                        return switchCaseName;
                    case 6:
                        switchCaseName = "Addison";
                        return switchCaseName;
                    case 7:
                        switchCaseName = "Kellie";
                        return switchCaseName;
                    case 8:
                        switchCaseName = "Nate";
                        return switchCaseName;
                    case 9:
                        switchCaseName = "Dan";
                        return switchCaseName;
                    case 10:
                        switchCaseName = "Paxton";
                        return switchCaseName;
                    default:
                        return "default";
                }
                
            }

        }
    }
}
