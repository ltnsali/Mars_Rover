using System;
using System.Drawing;
using Mars_Rover_Part1_HB.Enums;
using Mars_Rover_Part1_HB.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mars_Rover_Unit_Test.Models
{
    [TestClass]
    public class TestPosition
    {
        [TestMethod]
        public void TurnTest()
        {
            var position = new Position(new Point(1,1), Routes.N, new Point(3,3));

            position.Turn(Move.M);
            Assert.AreEqual(new Point(1,2), position.coordinates);
            position.Turn(Move.L);
            Assert.AreEqual(Routes.W, position.route);
            position.Turn(Move.M);
            Assert.AreEqual(new Point(0, 2), position.coordinates);
            position.Turn(Move.M); //Plateu Test
            Assert.AreEqual(new Point(0, 2), position.coordinates);
            position.Turn(Move.L);
            Assert.AreEqual(Routes.S, position.route);
            position.Turn(Move.M);
            Assert.AreEqual(new Point(0, 1), position.coordinates);
            position.Turn(Move.L);
            Assert.AreEqual(Routes.E, position.route);
            position.Turn(Move.M);
            Assert.AreEqual(new Point(1, 1), position.coordinates);
            position.Turn(Move.L);
            Assert.AreEqual(Routes.N, position.route);


            position.Turn(Move.R);
            Assert.AreEqual(Routes.E, position.route);
            position.Turn(Move.R);
            Assert.AreEqual(Routes.S, position.route);
            position.Turn(Move.R);
            Assert.AreEqual(Routes.W, position.route);
            position.Turn(Move.R);
            Assert.AreEqual(Routes.N, position.route);
        }
    }
}
