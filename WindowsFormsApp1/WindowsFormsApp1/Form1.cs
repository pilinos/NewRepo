using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class počítadlo : Form
    {
        public počítadlo()
        {
            InitializeComponent();
        }

        private void secti_Click(object sender, EventArgs e)
        {
            vysledek.Text = (double.Parse(boxik1.Text) + double.Parse(boxik2.Text)).ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void počítadlo_Load(object sender, EventArgs e)
        {

        }

        private void odecti_Click(object sender, EventArgs e)
        {
            vysledek.Text = (double.Parse(boxik1.Text) - double.Parse(boxik2.Text)).ToString();
        }

        private void vynasob_Click(object sender, EventArgs e)
        {
            vysledek.Text = (double.Parse(boxik1.Text) * double.Parse(boxik2.Text)).ToString();
        }

        private void vydel_Click(object sender, EventArgs e)
        {
            vysledek.Text = (double.Parse(boxik1.Text) / double.Parse(boxik2.Text)).ToString();
        }

        private void vysledek_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxik1_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxik2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
