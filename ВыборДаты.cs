using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Focus();
            SendKeys.Send("{F4}");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = String.Format(
                "Выбранная дата: {0}", dateTimePicker1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Cредство выбора даты!";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " ddd, dd MMM, yyyy";
            button1.Text = "ВЫБРАТЬ дату";
            label1.Text = String.Format(
                "Сегодня: {0}", dateTimePicker1.Text);
            
        }

        private void dateTimePicker1_VisibleChanged(object sender, EventArgs e)
        {
            label1.Text = String.Format(
                "Выбранная дата: {0}", dateTimePicker1.Text);
        }
    }
}
