using System;

namespace BattleShipGame
{
    public class Grid
    {
        public int GridWidth = 10;
        public int GridHeight = 10;


        public void LogGrid()
        {
            Console.WriteLine($"Grid you will play on is {GridWidth} X {GridHeight}\n");
        }


    }
}