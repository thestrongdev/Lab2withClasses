using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExercises
{
    class RoomCalculator
    {
        public double length { get; set; }
        public double width { get; set; }
        public double height { get; set; }

        public double GetArea()
        {
            return length * width;
        }

        public double GetPerimeter()
        {
            return 2 * length + 2 * width;
        }

        public double GetVolume()
        {
            return length * width * height;
        }
    }
}
