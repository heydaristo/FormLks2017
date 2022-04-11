using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLKS2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "student" && textBox2.Text == "student")
            {
                Form6 form6 = new Form6();
                this.Hide();
                form6.ShowDialog();
            }
            if (textBox1.Text == "teacher" && textBox2.Text == "teacher")
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
            }
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Form8 form8 = new Form8();
                this.Hide();
                form8.ShowDialog();
            }
        }
    }
}
