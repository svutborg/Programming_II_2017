using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSource
{
    public partial class Form1 : Form
    {
        Line lastLine;
        Graphics g;
        BindingList<Line> lines;
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            lines = new BindingList<Line>();
            dataGridView1.DataSource = lines;
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastLine = new Line(e.Location);
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            lastLine.EndPoint = e.Location;
            lines.Add(lastLine);
            g.DrawLine(Pens.Black, lastLine.StartPoint, lastLine.EndPoint);
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            g.Clear(Color.HotPink);
            foreach(Line l in lines)
            {
                g.DrawLine(Pens.Black, l.StartPoint, l.EndPoint);
            }
        }
    }

    public class Line
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        public Line(Point startPoint)
        {
            StartPoint = startPoint;
        }

        public Line(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }
    }
}
