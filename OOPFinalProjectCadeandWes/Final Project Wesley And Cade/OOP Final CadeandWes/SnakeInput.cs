using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Final_Project_Pong
{
    class SnakeInput
    {
        // This class is used to control the controls of the snake.

        // Creating a hashtable class to optimize keys.

        private static Hashtable keyTable = new Hashtable();

        // Function used to return a key to the class.

        public static bool KeyPress(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }

            return (bool)keyTable[key];
        }

        // Function used to change the state of the keys.

        public static void changeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
