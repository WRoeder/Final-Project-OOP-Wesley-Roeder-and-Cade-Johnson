using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Pong
{
    // Creating and enum for the directions of the game.

    public enum Directions
    {
        Left,
        Right,
        Up,
        Down
    };

    class SnakeSettings
    {
        // This class is used for all the settings of the SpaceSnake game.

        // Declaring all needed variables for the game.

        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static bool GameOver { get; set; }
        public static Directions direction { get; set; }

        public SnakeSettings()
        {
            // Function for setting the default settings for the game.

            Width = 16;
            Height = 16;
            Speed = 20;
            Score = 0;
            Points = 100;
            GameOver = false;
            direction = Directions.Down;
        }
    }
}
