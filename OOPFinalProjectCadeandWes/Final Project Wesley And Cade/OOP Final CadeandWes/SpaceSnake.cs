using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_Pong
{
    public partial class SpaceSnake : Form
    {
        // Creating an array for the snake.

        private List<SnakeCircle> Snake = new List<SnakeCircle>();

        // Creating a class for the food.

        private SnakeCircle food = new SnakeCircle();

        public SpaceSnake()
        {
            InitializeComponent();

            // Linking the SnakeSettings class to this form

            new SnakeSettings();

            // Setting up the timer for the game.

            snakeTimer.Interval = 1000 / SnakeSettings.Speed;
            snakeTimer.Tick += updateScreen;
            snakeTimer.Start();

            startGame();
        }

        private void updateScreen(object sender, EventArgs e)
        {
            // This function is used to update the screen when the timer ticks.

            if(SnakeSettings.GameOver == true)
            {
                if (SnakeInput.KeyPress(Keys.Enter))
                {
                    // If the game is over the user can press enter to play again.

                    startGame();
                }
            }
            else
            {
                // IF the game is not over the following commands are run to move the user.

                if (SnakeInput.KeyPress(Keys.Right) && SnakeSettings.direction != Directions.Left)
                {
                    SnakeSettings.direction = Directions.Right;
                }
                else if (SnakeInput.KeyPress(Keys.Left) && SnakeSettings.direction != Directions.Right)
                {
                    SnakeSettings.direction = Directions.Left;
                }
                else if (SnakeInput.KeyPress(Keys.Up) && SnakeSettings.direction != Directions.Down)
                {
                    SnakeSettings.direction = Directions.Up;
                }
                else if (SnakeInput.KeyPress(Keys.Down) && SnakeSettings.direction != Directions.Up)
                {
                    SnakeSettings.direction = Directions.Down;
                }

                movePlayer();
            }

            // Refreshing the picturebox and updating the graphics on it.

            pbPlaySpace.Invalidate();
        }

        private void SpaceSnake_KeyDown(object sender, KeyEventArgs e)
        {
            // This event will trigger the change state from the SnakeInput class.

            SnakeInput.changeState(e.KeyCode, true);
        }

        private void SpaceSnake_KeyUp(object sender, KeyEventArgs e)
        {
            // This event will trigger the change state from the SnakeInput class.

            SnakeInput.changeState(e.KeyCode, false);
        }

        private void pbPlaySpace_Paint(object sender, PaintEventArgs e)
        {
            // This is where the snake will be seen moving.

            Graphics canvas = e.Graphics;

            // Running a loop to check the snake.

            if (SnakeSettings.GameOver == false)
            {
                Brush snakeColor;

                for (int i = 0; i < Snake.Count; i++)
                {
                    if (i == 0)
                    {
                        snakeColor = Brushes.Black;
                    }
                    else
                    {
                        snakeColor = Brushes.DarkGray;
                    }

                    // Drawing the snake and food.

                    canvas.FillEllipse(snakeColor, new Rectangle(Snake[i].X * SnakeSettings.Width, Snake[i].Y * SnakeSettings.Height, SnakeSettings.Width, SnakeSettings.Height));

                    canvas.FillEllipse(Brushes.Yellow, new Rectangle(food.X * SnakeSettings.Width, food.Y * SnakeSettings.Height, SnakeSettings.Width, SnakeSettings.Height));
                }
            }
            else
            {
                // Showing the game over message when the game is over.

                string gameOver = "Game Over \n" + "Final Score is " + SnakeSettings.Score + "\n Press enter to Restart \n";
                label3.Text = gameOver;
                label3.Visible = true;
            }
        }

        private void startGame()
        {
            // This is the function for starting the game.

            // Setting the default value for the game.

            label3.Visible = false;
            new SnakeSettings();
            Snake.Clear();
            SnakeCircle head = new SnakeCircle { X = 10, Y = 5 };
            Snake.Add(head);

            label2.Text = SnakeSettings.Score.ToString();

            generateFood();
        }

        private void movePlayer()
        {
            // Main loop for the snake head and body.

            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (SnakeSettings.direction)
                    {
                        case Directions.Right:
                            Snake[i].X++;
                            break;
                        case Directions.Left:
                            Snake[i].X--;
                            break;
                        case Directions.Up:
                            Snake[i].Y--;
                            break;
                        case Directions.Down:
                            Snake[i].Y++;
                            break;
                    }

                    // Keeping the snake inbounds.

                    int maxXpos = pbPlaySpace.Size.Width / SnakeSettings.Width;
                    int maxYpos = pbPlaySpace.Size.Height / SnakeSettings.Height;

                    // If snake goes out of bounds then end the game.

                    if (Snake[i].X < 0 || Snake[i].Y < 0 || Snake[i].X > maxXpos || Snake[i].Y > maxYpos)
                    {
                        die();
                    }

                    // Detecting collision with the snake body.

                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            die();
                        }
                    }

                    // Detecting collision with food.

                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        eat();
                    }
                }
                else
                {
                    // If no collisions snake continues moving.

                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void generateFood()
        {
            // Creating the food in random locations for the game.

            int maxXpos = pbPlaySpace.Size.Width / SnakeSettings.Width;
            int maxYpos = pbPlaySpace.Size.Height / SnakeSettings.Height;
            Random rnd = new Random();
            food = new SnakeCircle { X = rnd.Next(0, maxXpos), Y = rnd.Next(0, maxYpos) };
        }

        private void eat()
        {
            // Adding a part to the snake body when food is picked up.

            SnakeCircle body = new SnakeCircle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);
            SnakeSettings.Score += SnakeSettings.Points;
            label2.Text = SnakeSettings.Score.ToString();
            generateFood();
        }

        private void die()
        {
            // Stopping the game when the snake dies.

            SnakeSettings.GameOver = true;
        }
    }
}
