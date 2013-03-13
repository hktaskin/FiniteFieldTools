using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FiniteFieldArithmetics;
using System.Threading;

/*
Author: Halil Kemal TAŞKIN
Web: http://hkt.me
*/

namespace Homework4Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tab3txtBinSeq_KeyUp(null, null);

            GetTab2Ready();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Stop all working threads.
            Environment.Exit(0);
        }

        #region Tab 1 "Order of a Polynomial"

        private void Tab1btnFindOrder_Click(object sender, EventArgs e)
        {
            Thread Th1 = new Thread(new ThreadStart(FindOrderThreaded));
            Th1.Start();
        }

        void FindOrderThreaded()
        {
            try
            {
                int p = (int)Tab1nupFieldSize.Value;

                if (!MathTools.IsPrime(p))
                {
                    MessageBox.Show("Finite Field size must be a prime number!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                FiniteField F = new FiniteField(p);

                Polynomial P = Polynomial.Parse(F, Tab1txtPolyCoefs.Text.Trim(), true);
                Tab1lblResult.Text = "";
                Tab1lblResult.Text += "Recognized polynomial: " + P.ToString() + "\r\n\r\nComputing the order...\r\n\r\n";
                Application.DoEvents();

                int order = P.Order;

                Tab1lblResult.Text += "Order of the polynomial is " + order.ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        #endregion

        #region Tab 2 "4 LFSRs & Non-linear Combiner"

        LFSR L1, L2, L3, L4;
        FiniteField F3;
        string NonlinCombOutput = "";

        private void Tab2btnFindPeriodLC_Click(object sender, EventArgs e)
        {
            Tab2txtResult.Clear();
            Application.DoEvents();
            Tab2txtResult.AppendText("Starting to compute first 50000 stream output.\r\n");

            for (int i = 0; i < 50000; i++)
            {
                L1.Clock();
                L2.Clock();
                L3.Clock();
                L4.Clock();
                NonlinCombOutput += NonLinearCombiner(L1.StreamOutput, L2.StreamOutput, L3.StreamOutput, L4.StreamOutput).Value.ToString();
            }

            Tab2txtResult.AppendText("Stream has been generated.\r\nStarting to compute period.\r\n");
            Application.DoEvents();

            int period = LFSRTools.FindStreamPeriodExtended(NonlinCombOutput,3+4+5+7);

            Tab2txtResult.AppendText("\r\nPeriod is " + period + ".\r\n");

            int LCbound = NonLinearCombinerStar(L1.FeedbackPolynomial.Degree, L2.FeedbackPolynomial.Degree, L3.FeedbackPolynomial.Degree, L4.FeedbackPolynomial.Degree);

            Tab2txtResult.AppendText("\r\nLC is bounded by " + LCbound + ".");           

        }

        void GetTab2Ready()
        {
            // Finite Field
            F3 = new FiniteField(3);

            // LFSR 1 - 3
            string strf1 = "201", stri1 = "001";
            Polynomial feedback1 = Polynomial.Parse(F3, strf1, false);
            Polynomial initial1 = Polynomial.Parse(F3, stri1, false);
            L1 = new LFSR(feedback1, initial1.Coefficients);
            Tab2lblLFSR1.Text += "\r\n" + "Feedback: " + Polynomial.Parse(F3, "1" + strf1, false).ToString() + "\r\nInitial: " + stri1 + "\r\nPeriod = " + L1.Period;

            // LFSR 2 - 4
            string strf2 = "2001", stri2 = "0001";
            Polynomial feedback2 = Polynomial.Parse(F3, strf2, false);
            Polynomial initial2 = Polynomial.Parse(F3, stri2, false);
            L2 = new LFSR(feedback2, initial2.Coefficients);
            Tab2lblLFSR2.Text += "\r\n" + "Feedback: " + Polynomial.Parse(F3, "2" + strf2, false).ToString() + "\r\nInitial: " + stri2 + "\r\nPeriod = " + L2.Period;

            // LFSR 3 - 5
            string strf3 = "20001", stri3 = "00001";
            Polynomial feedback3 = Polynomial.Parse(F3, strf3, false);
            Polynomial initial3 = Polynomial.Parse(F3, stri3, false);
            L3 = new LFSR(feedback3, initial3.Coefficients);
            Tab2lblLFSR3.Text += "\r\n" + "Feedback: " + Polynomial.Parse(F3, "1" + strf3, false).ToString() + "\r\nInitial: " + stri3 + "\r\nPeriod = " + L3.Period;

            // LFSR 4 - 7
            string strf4 = "0000201", stri4 = "1012220";
            Polynomial feedback4 = Polynomial.Parse(F3, strf4, false);
            Polynomial initial4 = Polynomial.Parse(F3, stri4, false);
            L4 = new LFSR(feedback4, initial4.Coefficients);
            Tab2lblLFSR4.Text += "\r\n" + "Feedback: " + Polynomial.Parse(F3, "1" + strf4, false).ToString() + "\r\nInitial: " + stri4 + "\r\nPeriod = 26 (precomputed)";// +L4.Period;

            // Nonlinear Combiner
            NonlinCombOutput = "";
            Tab2lblNonLinComb.Text += "\r\n(X1+X3) * (X2+X4)";
        }

        FiniteFieldElement NonLinearCombiner(FiniteFieldElement X1, FiniteFieldElement X2, FiniteFieldElement X3, FiniteFieldElement X4)
        {
            return (X1 * X3) + (X2 * X4);
        }

        int NonLinearCombinerStar(int X1, int X2, int X3, int X4)
        {
            return (X1 * X3) + (X2 * X4);
        }

        #endregion

        #region Tab 3 "Number of the runs & Binary Auto Correlation Values"

        private void Tab3btnFindRuns_Click(object sender, EventArgs e)
        {
            try
            {
                BindingList<Runs> list;
                int numOfRuns = LFSRTools.NumberOfRuns(Tab3txtBinSeq.Text, out list);
                Tab3dtGrid.Rows.Clear();
                Tab3dtGrid.Columns.Clear();
                Tab3dtGrid.DataSource = list;
                Tab3dtGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                Tab3lblTotalRun.Text = "Total Number of Runs = " + numOfRuns;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

            //MessageBox.Show(LFSRTools.NumberOfRuns(Tab3txtBinSeq.Text).ToString());
        }

        private void Tab3btnAutoCorr_Click(object sender, EventArgs e)
        {
            try
            {
                Tab3dtGrid.Rows.Clear();
                Tab3dtGrid.Columns.Clear();
                Tab3dtGrid.DataSource = null;
                Tab3dtGrid.Columns.Add("shift", "Shift Count (Tau)");
                Tab3dtGrid.Columns.Add("autocorr", "Autocorrelation Value C(Tau)");
                int distinctpoints;
                double[] autcor = LFSRTools.AllAutoCorrelationValues(Tab3txtBinSeq.Text, out distinctpoints);

                for (int i = 0; i < autcor.Length; i++)
                    Tab3dtGrid.Rows.Add(i, autcor[i]);

                Tab3dtGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                Tab3lblTotalRun.Text = "Number of Distinct Values = " + distinctpoints;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Tab3txtBinSeq_KeyUp(object sender, KeyEventArgs e)
        {
            Tab3lblBinSeq.Text = "Binary Sequence (Length = " + Tab3txtBinSeq.Text.Length + ")";
        }

        private void Tab3txtBinSeq_KeyPress(object sender, KeyPressEventArgs e)
        {
            string izinli = "01" + (char)8;
            if (izinli.IndexOf(e.KeyChar) < 0)
                e.Handled = true;

        }

        #endregion

    }
}
