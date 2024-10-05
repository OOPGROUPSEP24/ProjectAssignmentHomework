using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssignmentHomework
{
    internal class Swarm
    {
        public Vector2 Position { get; set; }
        public Vector2 Velocity { get; set; }
        public int Radius { get; set; }
        public Color Color { get; set; }
        public int Points { get; set; }

        public Swarm(Vector2 position, Vector2 velocity, int radius, Color color, int points)
        {
            Position = position;
            Velocity = velocity;
            Radius = radius;
            Color = color;
            Points = points;
        }

        public void Update(float deltaTime)
        {
            Position += Velocity * deltaTime;
        }
    }
}
