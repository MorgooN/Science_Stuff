using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp62
{
    public partial class Form1 : Form
    {
        Graphics Графика; Single Угол;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Смена изображения";
            button1.Text = "Развернуть";
            Угол = 0.0F;
            panel1.Location = new Point(12, 12);
            panel1.Size = new System.Drawing.Size(240, 200);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.AliceBlue;
            panel1.Cursor = Cursors.Cross;
            Графика = e.Graphics;
            Графика.TranslateTransform(120.0F, 100.0F);
            Графика.RotateTransform(Угол);
            Графика.DrawString("PRIMO VICTORIA!", new Font("Comic Sans MS", 12, FontStyle.Bold ^ FontStyle.Italic),
            Brushes.Red, -70, -15);
            Графика.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Угол = Угол + 30.0F;
            panel1.Invalidate();
        }
    }
}
