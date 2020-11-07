using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Всем Привет!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Приветствие!";
            label1.Text = "Microsoft VS C#19";
            button1.Text = " Click on ME";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Событие Hoover!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
