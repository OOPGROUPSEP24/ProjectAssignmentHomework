using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAssignmentHomework
{
    internal class DartType
    {
        public string Color { get; set; }
        public double Length { get; set; }
        public string TipType { get; set; }

        public DartType(string color, double length, string tipType)
        {
            Color = color;
            Length = length;
            TipType = tipType;
        }

        public void DisplayDartInfo()
        {
            Console.WriteLine($"Dart Details: Color - {Color}, Length - {Length} cm, Tip Type - {TipType}");
        }
    }
}
