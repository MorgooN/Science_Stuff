using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            base.Text = "Извлечение корня";
            button1.Text = "Извлечь корень";
            textBox1.Clear();
            label1.Text = null;
            textBox1.Clear();
            textBox1.TabIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single x;

            bool Число_ли = Single.TryParse(
                textBox1.Text,
                System.Globalization.NumberStyles.Number,
                System.Globalization.NumberFormatInfo.CurrentInfo,
                out x);
            if (Число_ли = false)
            {
                label1.Text = "Cледует Вводить число";
                label1.ForeColor = Color.Red;
                return;
            }

            var y = (Single)Math.Sqrt(x);
            label1.ForeColor = Color.Black;
            label1.Text = String.Format("Корень из {0} равен  {1:F5}", x, y);

        }
    }
}
