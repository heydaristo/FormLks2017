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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            this.Hide();
            form9.ShowDialog();
            this.Close();
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            this.Hide();
            form10.ShowDialog();
            this.Close();
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            this.Hide();
            form11.ShowDialog();
            this.Close();
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            this.Hide();
            form12.ShowDialog();
            this.Close();
            Form8 form8 = new Form8();
            form8.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["Form1"];
            this.Close();
            frm.Show();
        }
    }
}
