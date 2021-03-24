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
            this.Controls.Add(this.snake.header);
            timer1.Start();
        }

        public void addBody(PictureBox element)
        {
            this.Controls.Add(element);
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
            snake.header.BringToFront();
        }

    }

    public class Snake
    {
        public Snake()
        {
            
            this.header = new PictureBox();
            //this.body.Add(new PictureBox());
            initElemm(this.header, new Point(0, 0));
            
        }

        void initElemm(PictureBox element, Point locaton)
        {
            Program.form.addBody(element);
            element.Location = locaton;
            element.Size = new Size(20, 20);
            element.BackColor = Color.Coral;
        }

        void addBody()
        {
            PictureBox element = new PictureBox();
            this.body.Add(element);
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

        public PictureBox header;
        List<System.Windows.Forms.PictureBox> body;
        Queue<Point> moveArr;

    }

}
