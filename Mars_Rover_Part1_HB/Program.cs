using Mars_Rover_Part1_HB.Enums;
using Mars_Rover_Part1_HB.Helpers;
using Mars_Rover_Part1_HB.Models;
using System;
using System.Drawing;

namespace Mars_Rover_Part1_HB
{
    class Program
    {
        static readonly string INPUT_FILE = "input.txt";

        static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            var lines = IOHelper.readFile(INPUT_FILE);

            var plateu = GetPlateu(lines[0]);

            var firstRover = GetRoverFromInput(lines[1], lines[2], plateu);
            var secRover = GetRoverFromInput(lines[3], lines[4], plateu);

            firstRover.Go();
            secRover.Go();

            firstRover.WriteLocationToConsole();
            secRover.WriteLocationToConsole();

            Console.ReadLine();
        }

        private static Point GetPlateu(string plt)
        {
            var arr = plt.Split(' ');
            return new Point(Convert.ToInt32(arr[0]), Convert.ToInt32(arr[1]));
        }

        private static Rover GetRoverFromInput(string line1, string line2, Point plateu)
        {
            string[] coorFirst = line1.Split(' ');
            Enum.TryParse(coorFirst[2], out Routes myStatus);
            var pos = new Position(
                new Point(Convert.ToInt32(coorFirst[0]), Convert.ToInt32(coorFirst[1]))
                , myStatus
                , plateu);
            return new Rover(pos, line2);
        }
        
    }
}
