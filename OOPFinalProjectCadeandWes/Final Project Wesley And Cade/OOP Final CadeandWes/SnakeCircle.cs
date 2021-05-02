using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Pong
{
    class SnakeCircle
    {
        // This class is used for the head and body of the snake.

        // Declaring the integers needed.

        public int X { get; set; }
        public int Y { get; set; }

        public SnakeCircle()
        {
            // Function used to reset these back to 0
            X = 0;
            Y = 0;
        }
    }
}
