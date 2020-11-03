using System;
using System.ComponentModel.DataAnnotations;

namespace OOPExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            GetRoomDimensions();
        }

        public class RoomCalculator
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

        static void GetRoomDimensions()
        {
            var theRoom = new RoomCalculator();

            do
            {
                Console.WriteLine("enter a length");

                string userLength = Console.ReadLine();
                double.TryParse(userLength, out double length);
                theRoom.length = length;

                Console.WriteLine("enter a width");
                string userWidth = Console.ReadLine();
                double.TryParse(userWidth, out double width);
                theRoom.width = width;

                Console.WriteLine("enter a height");
                string userHeight = Console.ReadLine();
                double.TryParse(userHeight, out double height);
                theRoom.height = height;

                Console.WriteLine(theRoom.GetArea());
                Console.WriteLine(theRoom.GetPerimeter());
                Console.WriteLine(theRoom.GetVolume());

            } while (GoAgain());

        }

        static bool GoAgain()
        {
            Console.WriteLine("would you like to measure another room? (y/n)");

            do
            {
                string userChoice = Console.ReadLine();

                if (userChoice.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
                else if (userChoice.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("that's not a valid input. please enter y or n");
                }

            } while (true);

        }
    }
}
