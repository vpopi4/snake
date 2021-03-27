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
    public partial class Snake
    {
     
       public Snake()
        { 
            this.body = new List<PictureBox> { };
            this.queue = new List<Point> { };
            this.header = new PictureBox();
            this.addBody(new Point(-30, 10));
            this.addBody(new Point(-20, 10));
            this.addBody(new Point(-10, 10));
            this.addBody(new Point(0, 10));
            this.addBody(new Point(10, 10));
            initElement(ref this.header, new Point(20, 10));
            newQueue();
        }

        void initElement(ref PictureBox element, Point locaton)
        {
            element.Location = locaton;
            element.Size = new Size(10, 10);
            element.BackColor = Color.Coral;
        }

        void addBody(Point locaton)
        {
            PictureBox element = new PictureBox();
            initElement(ref element, locaton);
            this.body.Add(element);            
        }

        void newQueue()
        {
            queue.Clear();
            queue.Add(header.Location);
            foreach (PictureBox element in body)
            {
                queue.Add(element.Location);
            }
        }

        public void move(string direction)
        {
            switch (direction)
            {
                case "up":
                    {
                        Point newPoint = new Point(header.Location.X, header.Location.Y - 10);
                        header.Location = newPoint;
                        int i = 0;
                        foreach (PictureBox element in body)
                        {
                            element.Location = queue[i];
                            i++;
                        }
                        newQueue();
                        break;
                    }
                case "down":
                    {
                        Point newPoint = new Point(header.Location.X, header.Location.Y + 10);
                        header.Location = newPoint;
                        int i = 0;
                        foreach (PictureBox element in body)
                        {
                            element.Location = queue[i];
                            i++;
                        }
                        newQueue();
                        break;
                    }
                case "right":
                    {
                        Point newPoint = new Point(header.Location.X + 10, header.Location.Y);
                        header.Location = newPoint;
                        int i = 0;
                        foreach (PictureBox element in body)
                        {
                            element.Location = queue[i];
                            i++;
                        }
                        newQueue();
                        break;
                    }
                case "left":
                    {
                        Point newPoint = new Point(header.Location.X - 10, header.Location.Y);
                        header.Location = newPoint;
                        int i = 0;
                        foreach (PictureBox element in body)
                        {
                            element.Location = queue[i];
                            i++;
                        }
                        newQueue();
                        break;
                    }
            }

        }

        public PictureBox header;
        public List<PictureBox> body;
        List<Point> queue;

    }
}

