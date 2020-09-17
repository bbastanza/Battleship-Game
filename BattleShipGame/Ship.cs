using System;
using System.ComponentModel.DataAnnotations;

namespace BattleShipGame
{
    public class Ship
    {
        private bool _verticalShip;
        public readonly string[] ShipPositions = new string[5];
        public readonly string[] PossibleCoordinates = new string[100] 
            {"a1","a2","a3","a4","a5","a6","a7","a8","a9","a0",
            "b1","b2","b3","b4","b5","b6","b7","b8","b9","b0",
            "c1","c2","c3","c4","c5","c6","c7","c8","c9","c0",
            "d1","d2","d3","d4","d5","d6","d7","d8","d9","d0",
            "e1","e2","e3","e4","e5","e6","e7","e8","e9","e0",
            "f1","f2","f3","f4","f5","f6","f7","f8","f9","f0",
            "g1","g2","g3","g4","g5","g6","g7","g8","g9","g0",
            "h1","h2","h3","h4","h5","h6","h7","h8","h9","h0",
            "i1","i2","i3","i4","i5","i6","i7","i8","i9","i0",
            "j1","j2","j3","j4","j5","j6","j7","j8","j9","j0",};

    public void CreateShip()
        {
            var random = new Random();
            
            var randomBoolNumber = random.Next(0, 2);
            _verticalShip = randomBoolNumber != 0;
            
            var shipHeadPositionX = random.Next(0, 6);
            var shipHeadPositionYInt = random.Next(0, 6);
            var shipHeadPositionY = (char) ('a' + shipHeadPositionYInt);
            
            ShipPositions[0] = $"{shipHeadPositionY}{shipHeadPositionX}";
            
            if (_verticalShip)
            {
                ShipPositions[1] = $"{(char)('a' + shipHeadPositionYInt + 1)}{shipHeadPositionX}";
                ShipPositions[2] = $"{(char)('a' + shipHeadPositionYInt + 2)}{shipHeadPositionX}";
                ShipPositions[3] = $"{(char)('a' + shipHeadPositionYInt + 3)}{shipHeadPositionX}";
                ShipPositions[4] = $"{(char)('a' + shipHeadPositionYInt + 4)}{shipHeadPositionX}";
            }
            else
            {
                ShipPositions[1] = $"{shipHeadPositionY}{shipHeadPositionX + 1}";
                ShipPositions[2] = $"{shipHeadPositionY}{shipHeadPositionX + 2}";
                ShipPositions[3] = $"{shipHeadPositionY}{shipHeadPositionX + 3}";
                ShipPositions[4] = $"{shipHeadPositionY}{shipHeadPositionX + 4}";
            }
        }

        public void ShowShipCoordinates()
        {
            Console.WriteLine($"\nThe BattleShip was at: {ShipPositions[0]} {ShipPositions[1]} {ShipPositions[2]} {ShipPositions[3]} {ShipPositions[4]}\n");    
        }
    }
}