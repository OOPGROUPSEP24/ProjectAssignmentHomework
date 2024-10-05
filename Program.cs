using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssignmentHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a random instance for initializing balloons
            Random random = new Random();

            // Create balloon objects using the updated constructor
            Balloon balloon1 = new Balloon(new Vector2(100, 100), new Vector2(0, 100), 5.0f, Color.Red, 50);
            Balloon balloon2 = new Balloon(new Vector2(200, 100), new Vector2(0, 100), 3.0f, Color.Blue, 30);
            Balloon balloon3 = new Balloon(new Vector2(300, 100), new Vector2(0, 100), 5.0f, Color.Green, 50);

            // Create an instance of ComboSystem
            ComboSystem comboSystem = new ComboSystem();

            // Simulate bursting balloons and calculate combos
            Console.WriteLine("Bursting balloons and calculating combos:");

            // Balloon 1 burst
            balloon1.Burst();
            comboSystem.CalculateCombo(balloon1.Points);  // Passing Points instead of Size

            // Balloon 2 burst
            balloon2.Burst();
            comboSystem.CalculateCombo(balloon2.Points);  // Passing Points instead of Size

            // Balloon 3 burst (same points as balloon1, triggering combo)
            balloon3.Burst();
            comboSystem.CalculateCombo(balloon3.Points);  // Passing Points instead of Size

            // Display final combo stats
            comboSystem.DisplayComboStats();

            // Keep the console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}