using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp61
{
    public partial class Form1 : Form
    {
        Boolean Рисовать_ли;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Рисую мышью в форме";
            button1.Text = "Стереть";
            Рисовать_ли = false;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Рисовать_ли = false;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Рисовать_ли = true;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Рисовать_ли == true)
            {
                var Графика = CreateGraphics();
                Графика.FillRectangle(new SolidBrush(Color.Red), e.X, e.Y, 10, 10);
                Графика.Dispose();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var Графика = CreateGraphics();
            Графика.Clear(this.BackColor);
        }
    }
}

