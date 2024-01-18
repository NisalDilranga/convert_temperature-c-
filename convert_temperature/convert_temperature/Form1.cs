using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convert_temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Con_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(txt_Temp.Text);

            double reslt;

            if (rbtn_Fe.Checked)
            {
                reslt = (temp * 9 / 5)+ 32;
                txt_Eq.Text = reslt.ToString();

            }
            else if (rbtn_Celsius.Checked)
            {
                reslt = (temp - 32) * 5 / 9;
                txt_Eq.Text = reslt.ToString();

            }
            else
            {
                MessageBox.Show("Invalid input ");

            }


        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            rbtn_Celsius.Checked = false;
            rbtn_Fe.Checked = false;
            txt_Eq.Text = "";
            txt_Temp.Text = "";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            this.Close();
        }
    }
}
