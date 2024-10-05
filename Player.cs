using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssignmentHomework
{
    internal class Player
    {
        public string PlayerName { get; set; }
        public int Score { get; set; }
        public string DartType { get; set; }

        // Constructor
        public Player(string playerName)
        {
            PlayerName = playerName;
            Score = 0; // Initial score is 0
        }

        // Method for the balloon being shot
        public void Shoot(Balloon balloon, ComboSystem comboSystem)
        {
            balloon.Burst();
            int points = CalculateScore(balloon);
            Score += points;
            comboSystem.CalculateCombo(points);
        }

        // Method for calculating the score
        private int CalculateScore(Balloon balloon)
        {
            int baseScore = (int)(balloon.Radius * 10);
            if (balloon.Color == Color.Red)  // Assuming Color.Red if using System.Drawing.Color
                baseScore += 50;

            return baseScore;
        }

        // Method for customizing dart
        public void Customize(string dartType)
        {
            DartType = dartType;
            Console.WriteLine($"Player {PlayerName} customized dart to {DartType}");
        }
    }


}


      
        


    

