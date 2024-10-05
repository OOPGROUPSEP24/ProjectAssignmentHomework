using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssignmentHomework
{
    internal class Game
    {
       
        private List<Balloon> Balloons = new List<Balloon>();
        private Random random = new Random();
        private int BalloonsSpawned = 0;
        private float TimeElapsed = 0;

        // Method for spawning a balloon
        private void SpawnBalloon()
        {
            Vector2 position = new Vector2(random.Next(0, 800), -50); // Random starting position
            Vector2 velocity = new Vector2(random.Next(-100, 100) / 100f, 100 + 50); // Random velocity
            float radius = 20 + 10 * BalloonsSpawned; // Example radius calculation
            Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)); // Random color
            int points = 10 + 5 * BalloonsSpawned; // Points calculation

            // Create a new Balloon object with the specified parameters
            Balloons.Add(new Balloon(position, velocity, radius, color, points));
            BalloonsSpawned++;
        }

        // Method for updating balloons
        private void UpdateBalloons(float deltaTime)
        {
            foreach (Balloon balloon in Balloons)
            {
                balloon.Update(deltaTime);
                if (balloon.Position.Y > 800)
                {
                    Balloons.Remove(balloon);
                    break; // Prevents modifying the collection while iterating
                }
            }
        }

        // Method for spawning balloons if needed
        private void SpawnBalloonsIfNeeded()
        {
            // Adjust spawning rate based on mode and time elapsed
            if (Balloons.Count < 5 && TimeElapsed > 5)
            {
                SpawnBalloon();
            }
        }

        // Method for checking collisions
        private void CheckCollisions()
        {
            // Implement collision detection between balloons and player's projectiles
        }
    }
}
