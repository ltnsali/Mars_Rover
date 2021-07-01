using Mars_Rover_Part1_HB.Enums;
using System;
using System.Drawing;

namespace Mars_Rover_Part1_HB.Models
{
    public class Position
    {
        public Routes route;
        public Point coordinates;
        public Point plateu;

        public Position(Point coor, Routes pos, Point plateu)
        {
            coordinates = coor;
            route = pos;
            this.plateu = plateu;
        }

        internal void Turn(Move move)
        {
            if (Move.M == move)
            {
                if (route == Routes.N)
                {
                    if (InPlateu(coordinates.Y + 1, "Y"))
                        coordinates.Y++;
                }
                else if (route == Routes.S)
                {
                    if (InPlateu(coordinates.Y - 1, "Y"))
                        coordinates.Y--;
                }
                else if (route == Routes.W)
                {
                    if (InPlateu(coordinates.X - 1, "X"))
                        coordinates.X--;
                }
                else if (route == Routes.E)
                {
                    if (InPlateu(coordinates.X + 1, "X"))
                        coordinates.X++;
                }
            }
            else
            {
                int newInt = (int)route + (int)move;
                if (newInt < 0)
                    newInt = 3;
                else if (newInt > 3)
                    newInt = 0;
                route = (Routes)newInt;
            }
        }

        private bool InPlateu(int point, string coordinate)
        {
            switch (coordinate)
            {
                case "Y":
                    if (plateu.Y < point || 0 > point)
                        return false;
                    break;
                default:
                    if (plateu.X < point || 0 > point)
                        return false;
                    break;
            }
            return true;
        }
    }
}
