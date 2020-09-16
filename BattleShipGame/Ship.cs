using System;
using System.ComponentModel.DataAnnotations;

namespace BattleShipGame
{
    public class Ship
    {
        public bool VerticalShip;
        public string[] ShipPositions = new string[5];

        public void CreateShip()
        {
            var random = new Random();
            
            var randomBoolNumber = random.Next(0, 2);
            VerticalShip = randomBoolNumber != 0;
            
            var shipHeadPositionX = random.Next(0, 6);
            var shipHeadPositionYInt = random.Next(0, 6);
            var shipHeadPositionY = (char) ('a' + shipHeadPositionYInt);
            
            ShipPositions[0] = $"{shipHeadPositionY}{shipHeadPositionX}";
            
            if (VerticalShip)
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
    }
}