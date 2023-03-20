using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miniräknare
{
    public partial class Miniräknare : Form
    {
        public Miniräknare()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string calculation = textBox1.Text;
                DataTable dt = new DataTable();
                double result = Convert.ToDouble(dt.Compute(calculation, ""));
                textBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fel: " + ex.Message);
            }
        }

        private void C_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }
    }
}
