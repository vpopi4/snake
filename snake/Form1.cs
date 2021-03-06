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
    
    public partial class Form1 : Form
    {
        Snake snake;

        public Form1()
        {
            InitializeComponent();
            this.snake = new Snake();
            timer1.Start();
        }

        private void right_Click(object sender, EventArgs e)
        {

        }

        private void down_Click(object sender, EventArgs e)
        {

        }

        private void left_Click(object sender, EventArgs e)
        {

        }

        private void up_Click(object sender, EventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

    }

    public class Snake
    {
        public Snake()
        {
            this.header = new System.Windows.Forms.PictureBox();
            this.body.Add(new System.Windows.Forms.PictureBox());
        }

        void addBody()
        {
            this.body.Add(new System.Windows.Forms.PictureBox());
        }

        void move(string direction)
        {
            switch (direction)
            {
                case "up":
                    Point newPoint = new Point(header.Location.X, header.Location.Y - 10);
                    header.Location = newPoint;

                    foreach (System.Windows.Forms.PictureBox i in body)
                    {
                        i.Location = moveArr.Peek();
                    }
                    break;
            }

        }

        System.Windows.Forms.PictureBox header;
        List<System.Windows.Forms.PictureBox> body;
        Queue<Point> moveArr;

    }

}
