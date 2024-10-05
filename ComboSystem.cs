using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssignmentHomework
{
    internal class ComboSystem
    {
        
        
            private int comboCount;
            private int lastPoints;

            public ComboSystem()
            {
                comboCount = 0;
                lastPoints = 0;
            }

            public void CalculateCombo(int currentPoints)
            {
                if (currentPoints == lastPoints)  // Simple combo logic
                {
                    comboCount++;
                }
                else
                {
                    comboCount = 0;  // Reset combo if points don't match
                }
                lastPoints = currentPoints;

                Console.WriteLine($"Combo Count: {comboCount}");
            }

            public void DisplayComboStats()
            {
                Console.WriteLine($"Final combo count: {comboCount}");
            }
        
    }
}
