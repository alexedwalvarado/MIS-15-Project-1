using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int numberOfImpacts= 0;
        decimal totalofImpacts = 0m;
        decimal average = 0m;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Convert.ToDecimal(txtAmountMeasured.Text);
            decimal adjustedPercent = 0m;

            if (subtotal > 1000)
            {
                adjustedPercent = .25m;
            }

            else if (subtotal >= 500 && subtotal < 1000) //both statements are true
            {
                adjustedPercent = .20m;
            }

            else if (subtotal >= 250 && subtotal < 500)
            {
                adjustedPercent = 0.15m;
            }

            else if (subtotal >= 50 && subtotal < 250)
            {
                adjustedPercent = 0.10m;
            }

            else if (subtotal >= 0 && subtotal < 50)
            {
                adjustedPercent = 0.05m;
            }

            decimal reductionAmount = Math.Round(subtotal * adjustedPercent, 2);
            decimal adjustedForcing = subtotal - reductionAmount;

            txtAdjustedForce.Text = adjustedForcing.ToString("c");

            numberOfImpacts++;
            totalofImpacts += adjustedForcing;
            txtImpactsNumber.Text = numberOfImpacts.ToString();


            average = totalofImpacts / numberOfImpacts;
            txtForceAverage.Text = average.ToString("c");


            txtAmountMeasured.Text = "";
            txtAmountMeasured.Focus();
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            numberOfImpacts = 0;
            totalofImpacts = 0m;
            average = 0m;

            txtImpactsNumber.Text = "";
            txtForceAverage.Text = "";
            txtAdjustedForce.Text = "";
            txtAmountMeasured.Focus();

        }
        
    }
}
