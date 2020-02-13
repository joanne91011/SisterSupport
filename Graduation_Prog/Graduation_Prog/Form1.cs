﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graduation_Prog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillRectangle(myBrush, new Rectangle(0, 0, 200, 300));
            myBrush.Dispose();
            formGraphics.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Graphics g = e.Graphics;
            //int x1 = pictureBox1.Location.X;
            //int x2 = pictureBox1.Location.X + pictureBox1.Size.Width / 2;
            //int x3 = pictureBox1.Location.X + pictureBox1.Size.Width;
            //int y1 = pictureBox1.Location.Y;
            //int y2 = pictureBox1.Location.Y + pictureBox1.Size.Height / 2;
            //int y3 = pictureBox1.Location.Y + pictureBox1.Size.Height;

            //Pen p = new Pen(Color.Red, 1);
            //g.DrawLine(p, new Point(x1, y1), new Point(x3, y1));
            //g.DrawLine(p, new Point(x1, y2), new Point(x3, y2));
            //g.DrawLine(p, new Point(x1, y3), new Point(x3, y3));
            //g.DrawLine(p, new Point(x1, y1), new Point(x1, y3));
            //g.DrawLine(p, new Point(x2, y1), new Point(x2, y3));
            //g.DrawLine(p, new Point(x3, y1), new Point(x3, y3));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;



            int x1 = pictureBox1.Location.X;
            int x2 = pictureBox1.Location.X + pictureBox1.Size.Width / 2;
            int x3 = pictureBox1.Location.X + pictureBox1.Size.Width;
            int y1 = pictureBox1.Location.Y;
            int y2 = pictureBox1.Location.Y + pictureBox1.Size.Height / 2;
            int y3 = pictureBox1.Location.Y + pictureBox1.Size.Height;

            Pen p = new Pen(Color.Red, 1);
            g.DrawLine(p, new Point(x1, y1), new Point(x3, y1));
            g.DrawLine(p, new Point(x1, y2), new Point(x3, y2));
            g.DrawLine(p, new Point(x1, y3), new Point(x3, y3));
            g.DrawLine(p, new Point(x1, y1), new Point(x1, y3));
            g.DrawLine(p, new Point(x2, y1), new Point(x2, y3));
            g.DrawLine(p, new Point(x3, y1), new Point(x3, y3));
        }
    }
}
