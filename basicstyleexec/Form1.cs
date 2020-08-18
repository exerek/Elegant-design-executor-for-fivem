using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicstyleexec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            home1.BringToFront();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            SidePanel2.Height = button26.Height;
            SidePanel2.Top = button26.Top;
            home1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel2.Height = button4.Height;
            SidePanel2.Top = button4.Top;
            menus1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel2.Height = button2.Height;
            SidePanel2.Top = button2.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel2.Height = button3.Height;
            SidePanel2.Top = button3.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel2.Height = button1.Height;
            SidePanel2.Top = button1.Top;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel2.Height = button5.Height;
            SidePanel2.Top = button5.Top;
        }
    }
}
