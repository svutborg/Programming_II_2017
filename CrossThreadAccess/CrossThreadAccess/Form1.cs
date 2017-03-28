using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CrossThreadAccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //ThreadMethod();
            Thread T = new Thread(delegate() { ThreadMethod(listBox1); });
            T.Start();
            T = new Thread(delegate () { ThreadMethod(listBox2); });
            T.Start();
        }

        private void ThreadMethod(ListBox l)
        {
            while (true)
            {
                this.Invoke((MethodInvoker)delegate () { l.Items.Add("Hi!"); });
                Thread.Sleep(1000);
            }
        }
    }
}
