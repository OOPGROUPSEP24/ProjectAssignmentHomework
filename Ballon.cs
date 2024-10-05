using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssignmentHomework
{
    internal class Balloon  
    {
        public Vector2 Position { get; set; }
        public Vector2 Velocity { get; set; }
        public float Radius { get; set; }
        public Color Color { get; set; }
        public int Points { get; set; }

        // Constructor to match parameters in Game.cs
        public Balloon(Vector2 position, Vector2 velocity, float radius, Color color, int points)
        {
            Position = position;
            Velocity = velocity;
            Radius = radius;
            Color = color;
            Points = points;
        }

        public void Update(float deltaTime)
        {
            // Update the balloon's position based on velocity and time elapsed
            Position += Velocity * deltaTime;
        }

        public void Burst()
        {
            Console.WriteLine($"Balloon {Color} (Radius {Radius}) bursts with special effect!");
        }
    }
}
