using System;

namespace BattleShipGame
{
    public class Ship
    {
        private bool _verticalShip;
        public readonly string[] ShipPositions = new string[5];
        public readonly char[] PossibleYCoordinates = new char[10] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j'};
        public readonly char[] PossibleXCoordinates = new char[10] {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
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