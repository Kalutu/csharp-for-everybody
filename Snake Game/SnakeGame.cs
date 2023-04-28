using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        private List<Point> snake = new List<Point>();
        private Point food = new Point();
        private Point direction = new Point(1, 0); // start moving right
        private bool gameOver = false;
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // create the initial snake body
            snake.Add(new Point(5, 5));
            snake.Add(new Point(4, 5));
            snake.Add(new Point(3, 5));

            // place the food randomly
            PlaceFood();

            // start the game loop
            timer1.Start();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // draw the snake
            foreach (Point point in snake)
            {
                e.Graphics.FillRectangle(Brushes.Green, point.X * 10, point.Y * 10, 10, 10);
            }

            // draw the food
            e.Graphics.FillRectangle(Brushes.Red, food.X * 10, food.Y * 10, 10, 10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // move the snake
            Point head = snake[0];
            Point newHead = new Point(head.X + direction.X, head.Y + direction.Y);
            snake.Insert(0, newHead);
            snake.RemoveAt(snake.Count - 1);

            // check for collision with food
            if (newHead == food)
            {
                snake.Add(snake[snake.Count - 1]); // grow the snake
                PlaceFood(); // place a new food
            }

            // check for collision with walls or snake body
            if (newHead.X < 0 || newHead.X >= pictureBox1.Width / 10 ||
                newHead.Y < 0 || newHead.Y >= pictureBox1.Height / 10 ||
                snake.Contains(newHead))
            {
                gameOver = true;
                timer1.Stop();
                MessageBox.Show("Game over!");
            }

            pictureBox1.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // change the direction of the snake based on the key pressed
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (direction.X != 1) direction = new Point(-1, 0);
                    break;
                case Keys.Right:
                    if (direction.X != -1) direction = new Point(1, 0);
                    break;
                case Keys.Up:
                    if (direction.Y != 1) direction = new Point(0, -1);
                    break;
                case Keys.Down:
                    if (direction.Y != -1) direction = new Point(0, 1);
                    break;
            }
        }

        private void PlaceFood()
        {
            food.X = rand.Next(pictureBox1.Width / 10) * 10;
            food.Y = rand.Next(pictureBox1.Height / 10) * 10;
            while (snake.Contains(food))
            {
                food.X = rand.Next(pictureBox1.Width / 10) * 10;
                food.Y = rand.Next(pictureBox1.Height / 10) * 10;
            }
        }
    }
}

