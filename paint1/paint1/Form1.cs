using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace paint1
{
    public partial class Form1 : Form
    {
        bool rys = false;
        Graphics g;
        Pen p = new Pen(Color.Blue, 2);
        SolidBrush b = new SolidBrush(Color.Green);
        int x0, y0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            rys = true;
            x0 = e.X;
            y0 = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (rys)
            {
                int x = e.X; int y = e.Y;       // odczytaj położenie myszy
                g.DrawLine(p, x0, y0, x, y);    // narysuj odcinek
                x0 = x; y0 = y;                 // zapamiętaj współrzędne końca odcinka jako początek dla następnego odcinka
            } 
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            rys = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.Color = button1.BackColor;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            p.Color = button6.BackColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            p.Color = button5.BackColor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            p.Color = button4.BackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p.Color = button3.BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.Color = button2.BackColor;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                g.Clear(Color.White);
            }


        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Patryk Łąpieś");
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program służący do rysowania. Prawy Przycisk myszy służy do wyczyszczenia");
        }

      
        

    }
}
