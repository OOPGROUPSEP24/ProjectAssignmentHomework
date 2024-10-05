using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssignmentHomework
{
    internal class GameMode
    {
        public string ModeName { get;  set; }
        public int Difficulty { get;  set; }

        public GameMode(string modeName, int difficulty)
        {
            ModeName = modeName;
            Difficulty = difficulty;
        }

        public void ApplyMode()
        {
            Console.WriteLine($"Mode: {ModeName}, Difficulty: {Difficulty}");
        }
    }
}
