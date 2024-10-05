using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssignmentHomework
{
    internal class Dart
    {
        public string Type { get; set; }
        public int Speed { get; set; }

        public Dart(string type, int speed)
        {
            this.Type = type;
            this.Speed = speed;
        }

        public void Launch()
        {
            Console.WriteLine($"Launching a {Type} dart at {Speed} speed!");
        }
    }
}
