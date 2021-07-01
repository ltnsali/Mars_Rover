using Mars_Rover_Part1_HB.Enums;
using System;

namespace Mars_Rover_Part1_HB.Models
{
    public class Rover
    {
        public Position current_position;
        private readonly string commands;
        public Rover(Position pos, string mov)
        {
            current_position = pos;
            commands = mov;
        }

        internal void Go()
        {
            foreach (char c in commands)
            {
                Enum.TryParse(c.ToString(), out Move myMove);
                current_position.Turn(myMove);
            }
        }

        public void WriteLocationToConsole()
        {
            Console.WriteLine(current_position.coordinates.X + " "
                              + current_position.coordinates.Y + " "
                              + current_position.route);
        }
    }
}
