using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

//Ctrl 按住 滑鼠左鍵  可以跳至定義的類別或函式內
namespace Graduation_Prog
{
    public partial class Form1 : Form
    {

        jFile jf = new jFile();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jf.filePara(); //開啟FORM時的動作 STEP 1.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("[Rang]");
            foreach (var item in jf.lst_XYRange)
            {
                jXYRange rag =  (jXYRange)item; 
                Console.WriteLine("(x1,y1) -> ({0},{1}) ~ (x2,y2) -> ({2},{3})" ,rag.PointF.X, rag.PointF.Y,rag.PointS.X,rag.PointS.Y);
            }
            Console.WriteLine();
            Console.WriteLine("[Obstacle]");
            foreach (var item in jf.lst_XYObstacle)
            {
                jXYObstacle rag = (jXYObstacle)item;
                Console.WriteLine("(x1,y1) -> ({0},{1}) ~ (x2,y2) -> ({2},{3})", rag.PointF.X, rag.PointF.Y, rag.PointS.X, rag.PointS.Y);
            }
            Console.WriteLine();
            Console.WriteLine("[Point]");
            foreach (var item in jf.lst_XYPoint)
            {
                jXYPoint rag = (jXYPoint)item;
                Console.WriteLine("(x1,y1) -> ({0},{1})", rag.PointO.X, rag.PointO.Y);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //這邊算是 STEP 2.
            Console.WriteLine("[Rang]");
            foreach (var item in jf.lst_XYRange)
            {
                jXYRange rag = (jXYRange)item;
                Console.WriteLine("(x1,y1) -> ({0},{1}) ~ (x2,y2) -> ({2},{3})", rag.PointF.X, rag.PointF.Y, rag.PointS.X, rag.PointS.Y);
                Pen p1;
                p1 = new Pen(Color.Red, 2);
                e.Graphics.DrawRectangle(p1, rag.PointF.X, rag.PointF.Y, rag.PointS.X, rag.PointS.Y);
            }
            Console.WriteLine();
            Console.WriteLine("[Obstacle]");
            foreach (var item in jf.lst_XYObstacle)
            {
                jXYObstacle rag = (jXYObstacle)item;
                Console.WriteLine("(x1,y1) -> ({0},{1}) ~ (x2,y2) -> ({2},{3})", rag.PointF.X, rag.PointF.Y, rag.PointS.X, rag.PointS.Y);
                Pen p1;
                p1 = new Pen(Color.Blue, 2);
                e.Graphics.DrawRectangle(p1, rag.PointF.X, rag.PointF.Y, rag.PointS.X, rag.PointS.Y);
            }
        }
    }
}
