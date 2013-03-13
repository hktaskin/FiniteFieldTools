using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FiniteFieldArithmetics;

/*
Author: Halil Kemal TAŞKIN
Web: http://hkt.me
*/

namespace LFSRSequenceGeneratorExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Fields

        int p;

        FiniteField F = null;

        LFSR lfsr = null;

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            // initiate the new field GF(2)
            p = 2;
            txtSize.Text = p.ToString();
            txtFeedback.Text = "10111000";
            txtInitial.Text = "11111111";

        }

        private void btnGenSeq_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nupCount.Value; i++)
                ProperClock();
        }

        void ProperClock()
        {
            lfsr.Clock();
            txtOutput.Text += lfsr.StreamOutput.Value.ToString();
            lblSeqSize.Text = txtOutput.Text.Length.ToString();
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            btnGenSeq.Enabled = false;
            btnFindPeriod.Enabled = false;
            btnFixValues.Enabled = true;
            btnFixField.Enabled = true;
            lblInfo.Text = "Please enter field size";
        }

        private void btnFixValues_Click(object sender, EventArgs e)
        {
            if (btnFixField.Enabled)
            {
                 MessageBox.Show("First fix the field!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 return;
            }

            string poly = "1" + string.Join("", txtFeedback.Text.Reverse());
            Polynomial feedback = Polynomial.Parse(F, txtFeedback.Text,false);
            lblFeedback.Text = "Feedback Polynomial: " + Polynomial.Parse(F, poly,false).ToString();

            Polynomial initial = Polynomial.Parse(F, txtInitial.Text.Trim(),false);
            lblInitial.Text = "Initial State: " + initial.ToString();

            lfsr = new LFSR(feedback, initial.Coefficients);
            txtOutput.Text = ""; // txtInitial.Text.Trim();
            lblSeqSize.Text = "Ready";

            btnGenSeq.Enabled = true;
            btnFindPeriod.Enabled = true;
            btnFixValues.Enabled = false;

        }

        private void txtFeedback_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (btnFixField.Enabled)
            {
                e.Handled = true;
                MessageBox.Show("First fix the field!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnFixField_Click(object sender, EventArgs e)
        {
            int t = 0;
            bool dene = int.TryParse(txtSize.Text.Trim(), out t);
            if (dene)
            {
                if (MathTools.IsPrime(t))
                {
                    p = t;
                    F = new FiniteField(p);
                    lblInfo.Text = "Current Field: " + F.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a prime number!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtSize.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please check the value you have written!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSize.Focus();
            }

            btnFixField.Enabled = false;
            btnFixValues.Enabled = true;
            //lblInfo.Text = "Please enter the parameters";
        }

        private void txtFeedback_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtFeedback_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox b = sender as TextBox;

            try
            {
                if (b.Name.Contains("Feedback"))
                {
                    string poly = "1" + string.Join("", b.Text.Reverse());
                    Polynomial feedback = Polynomial.Parse(F, b.Text,false);
                    lblFeedback.Text = "Feedback Polynomial: " + Polynomial.Parse(F, poly, false).ToString();

                }
                else
                {
                    Polynomial initial = Polynomial.Parse(F, b.Text.Trim(), false);
                    lblInitial.Text = "Initial State: " + initial.ToString();
                }

            }
            catch { }
        }

        private void txtInitial_TextChanged(object sender, EventArgs e)
        {
            btnGenSeq.Enabled = false;
            btnFindPeriod.Enabled = false;
            btnFixValues.Enabled = true;
            //btnFixField.Enabled = true;
            lblInfo.Text = "Please enter the parameters";
        }

        private void btnFindPeriod_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("This will try to compute/find period of the current LFSR.\r\nIt may take some time. Do you want to continue?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                return;

            MessageBox.Show("The period of the LFSR is " + lfsr.Period.ToString());
        }
    }
}
