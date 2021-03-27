using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    delegate void AddBody(PictureBox element);
    public partial class Form1 : Form
    {
        Snake thisSnake;
        String direction = "";

        public Form1(Snake snake)
        {
            InitializeComponent();
            this.thisSnake = snake;
            this.Controls.Add(this.thisSnake.header);
            foreach (PictureBox element in thisSnake.body)
            {
                this.Controls.Add(element);
            }
            timer1.Start();
        }

        public void addBody(PictureBox element)
        {
            this.Controls.Add(element);
        }

        private void right_Click(object sender, EventArgs e)
        {
            direction = "right";
        }

        private void down_Click(object sender, EventArgs e)
        {
            direction = "down";
        }

        private void left_Click(object sender, EventArgs e)
        {
            direction = "left";
        }

        private void up_Click(object sender, EventArgs e)
        {
            direction = "up";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox element in thisSnake.body)
            {
                element.BringToFront();
            }
            thisSnake.header.BringToFront();
            thisSnake.move(direction);
        }

    }
}
