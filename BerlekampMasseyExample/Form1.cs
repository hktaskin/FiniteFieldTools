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

namespace BerlekampMasseyExample
{
    public partial class Form1 : Form
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Fields

        int p, eskip;

        FiniteField F;

        #endregion

        #region Form Events

        private void Form1_Load(object sender, EventArgs e)
        {
            // initiate the new field GF(2)
            p = 2;
            txtSize.Text = p.ToString();
            txtSize_Leave(null, null);
        }

        private void txtSize_Leave(object sender, EventArgs e)
        {
            int t = 0;
            bool dene = int.TryParse(txtSize.Text.Trim(), out t);
            if (dene)
            {
                if (MathTools.IsPrime(t))
                {
                    eskip = p;
                    p = t;
                    F = new FiniteField(p);
                    lblInfo.Text = "Current Field: " + F.ToString();
                    if (eskip > p)
                    {
                        txtSeq.Clear();
                        txtResult.Clear();
                    }
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
        }

        private void txtSeq_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(((int)e.KeyChar).ToString());
            int t = 0;
            bool dene = int.TryParse(e.KeyChar.ToString(), out t);
            if (dene)
            {
                if (t > F.Characteristic - 1)
                    e.Handled = true;
            }
            else
            {
                if (e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        private void btnRunBM_Click(object sender, EventArgs e)
        {
            CleanTheMess();

            if (txtSeq.Text.Length == 0)
            {
                MessageBox.Show("Please enter the sequence.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSeq.Focus();
                return;
            }

            Polynomial p = Polynomial.Parse(F, txtSeq.Text, false);
            Polynomial c;
            int LC = LFSRTools.BerlekampMassey(p, out c);
            txtResult.Text = "Sequence Length = " + txtSeq.Text.Length + "\r\n" +
                             "Linear Complexity = " + LC + "\r\n" +
                             "Connection Polynomial = " + c.ToString();

        }

        private void btnCleanSeq_Click(object sender, EventArgs e)
        {
            CleanTheMess();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (txtSeq.Text.Length > 0)
            {
                Clipboard.SetText(String.Join(",", txtSeq.Text.ToArray()));
                MessageBox.Show("Sequence has been copied to the clipboard.",this.Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        #endregion

        #region Methods

        private void CleanTheMess()
        {
            string seq = txtSeq.Text, newseq = "";

            for (int i = 0; i < seq.Length; i++)
            {
                int t = 0;
                bool dene = int.TryParse(seq[i].ToString(), out t);
                if (dene)
                {
                    if (t < F.Characteristic)
                        newseq += seq[i];
                }
            }

            txtSeq.Text = newseq;
        }

        #endregion
    }
}
