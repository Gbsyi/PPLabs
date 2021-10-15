using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pricl_lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_pow_Click(object sender, EventArgs e)
        {
            try
            {
                label_pow.Text = Math.Pow(Double.Parse(txt_pow.Text),3).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            try
            {
                label_sum.Text = "sum = " + (Double.Parse(txt_sum1.Text) + Double.Parse(txt_sum2.Text)).ToString() + " multiply = " +
                    (Double.Parse(txt_sum1.Text) * Double.Parse(txt_sum2.Text)).ToString()
                    + " divide = " + (Double.Parse(txt_sum1.Text) / Double.Parse(txt_sum2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
