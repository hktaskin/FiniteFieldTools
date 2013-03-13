using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FiniteFieldArithmetics;
using System.Diagnostics;
using System.Threading;

/*
Author: Halil Kemal TAŞKIN
Web: http://hkt.me
*/

namespace FiniteFieldExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
           // this.Height = 470;
           // this.Width = 1000;
        }

        FiniteField GF5;
        Polynomial GF56Primitive;
        ExtensionField ExtF;

        private void Form1_Load(object sender, EventArgs e)
        {
            GF5 = new FiniteField(5);
            GF56Primitive = new Polynomial(GF5, 2, 0, 1, 4, 1, 0, 1);
            ExtF = new ExtensionField(GF56Primitive);
            lblInfo.Text = "Current Field Info: " + ExtF.ToString();
        }

        private void lblClear_MouseEnter(object sender, EventArgs e)
        {
            lblClear.Font = new Font(lblClear.Font, FontStyle.Underline);
        }

        private void lblClear_MouseLeave(object sender, EventArgs e)
        {
            lblClear.Font = new Font(lblClear.Font, FontStyle.Regular);
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();
            txtInfo.AppendText("Extension Field = " + ExtF.ToString() + "\r\n");
            txtInfo.AppendText("Base Field = " + ExtF.DefiningPolynomial.Field.ToString() + "\r\n");
            txtInfo.AppendText("Defining Polynomial = " + ExtF.DefiningPolynomial.ToString() + "\r\n");
            txtInfo.AppendText("[Extension Field : Base Field] = " + ExtF.DefiningPolynomial.Degree.ToString() + "\r\n");
            txtInfo.AppendText("Order = " + ExtF.Order.ToString() + "\r\n\r\n");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ExtensionFieldElement e1 = ExtF.RandomElement;
            ExtensionFieldElement e2 = ExtF.RandomElement;
            ExtensionFieldElement toplam = e1 + e2;
            txtInfo.Clear();
            txtInfo.AppendText("Random Element 1 = " + e1.ToString() + "\r\n");
            txtInfo.AppendText("Random Element 2 = " + e2.ToString() + "\r\n");
            txtInfo.AppendText("Addition = " + toplam.ToString() + "\r\n");
            txtInfo.AppendText("\r\n");
        }

        private void btnSubs_Click(object sender, EventArgs e)
        {
            ExtensionFieldElement e1 = ExtF.RandomElement;
            ExtensionFieldElement e2 = ExtF.RandomElement;
            ExtensionFieldElement toplam = e1 - e2;
            txtInfo.Clear();
            txtInfo.AppendText("Random Element 1 = " + e1.ToString() + "\r\n");
            txtInfo.AppendText("Random Element 2 = " + e2.ToString() + "\r\n");
            txtInfo.AppendText("Substraction = " + toplam.ToString() + "\r\n");
            txtInfo.AppendText("\r\n");
        }

        private void btnMultip_Click(object sender, EventArgs e)
        {
            ExtensionFieldElement e1 = ExtF.RandomElement;
            ExtensionFieldElement e2 = ExtF.RandomElement;
            ExtensionFieldElement toplam = e1 * e2;
            txtInfo.Clear();
            txtInfo.AppendText("Random Element 1 = " + e1.ToString() + "\r\n");
            txtInfo.AppendText("Random Element 2 = " + e2.ToString() + "\r\n");
            txtInfo.AppendText("Multiplication = " + toplam.ToString() + "\r\n");
            txtInfo.AppendText("\r\n");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            ExtensionFieldElement e1 = ExtF.RandomElement;
            while (e1.Value.IsZero)
                e1 = ExtF.RandomElement;

            ExtensionFieldElement e2 = ExtF.RandomElement;
            while (e2.Value.IsZero)
                e2 = ExtF.RandomElement;

            ExtensionFieldElement q = e1 / e2;

            txtInfo.Clear();
            txtInfo.AppendText("Random Element 1 = " + e1.ToString() + "\r\n");
            txtInfo.AppendText("Random Element 2 = " + e2.ToString() + "\r\n");
            txtInfo.AppendText("Division = " + q.ToString() + "\r\n");
            txtInfo.AppendText("Test E1 = " + ((e2 * q) + (e1 % e2)).ToString() + "\r\n");
            txtInfo.AppendText("\r\n");

        }

        private void btnPrmElt_Click(object sender, EventArgs e)
        {
            ExtensionFieldElement prm = ExtF.RandomPrimitiveElement((new Random()).Next(1, GF56Primitive.Degree));
            txtInfo.Clear();
            txtInfo.AppendText("Random Primitive Element = " + prm.ToString() + "\r\n\r\n");
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ExtensionFieldElement elt = ExtF.RandomElement;
            txtInfo.Clear();
            txtInfo.AppendText("Random Element = " + elt.ToString() + "\r\n");
            txtInfo.AppendText("Order = " + elt.Order + "\r\n");
            txtInfo.AppendText("\r\n");
        }

        private void btnConjugates_Click(object sender, EventArgs e)
        {
            ExtensionFieldElement elt = ExtF.RandomElement;
            txtInfo.Clear();
            txtInfo.AppendText("Random Element = " + elt.ToString() + "\r\n");
            ExtensionFieldElement[] eltConjs = elt.Conjugates;
            txtInfo.AppendText("Conjugates:" + "\r\n");
            for (int i = 0; i < eltConjs.Length; i++)
                txtInfo.AppendText("C(" + (i + 1) + ") = " + eltConjs[i] + "\r\n");
            txtInfo.AppendText("\r\n");

        }

        private void btnTrace_Click(object sender, EventArgs e)
        {
            ExtensionFieldElement elt = ExtF.RandomElement;
            txtInfo.Clear();
            txtInfo.AppendText("Random Element = " + elt.ToString() + "\r\n");
            txtInfo.AppendText("Trace: " + elt.Trace.ToString() + "\r\n");
            txtInfo.AppendText("\r\n");
        }

        private void btnNorm_Click(object sender, EventArgs e)
        {
            ExtensionFieldElement elt = ExtF.RandomElement;
            txtInfo.Clear();
            txtInfo.AppendText("Random Element = " + elt.ToString() + "\r\n");
            txtInfo.AppendText("Norm: " + elt.Norm.ToString() + "\r\n");
            txtInfo.AppendText("\r\n");

        }

        private void btnGenBasis_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnBasisDisc_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnFindDual_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnExtPolyAdd_Click(object sender, EventArgs e)
        {
            ExtensionFieldElement[] eltlist1 = new ExtensionFieldElement[7];

            for (int i = 0; i < 7; i++)
                eltlist1[i] = ExtF.RandomElement;

            ExtensionPolynomial extp1 = new ExtensionPolynomial(eltlist1);

            ExtensionFieldElement[] eltlist2 = new ExtensionFieldElement[4];

            for (int i = 0; i < 4; i++)
                eltlist2[i] = ExtF.RandomElement;

            ExtensionPolynomial extp2 = new ExtensionPolynomial(eltlist2);

            ExtensionPolynomial result = extp1 + extp2;

            txtInfo.Clear();
            txtInfo.AppendText("Random Extension Polynomial 1\r\n" + extp1.ToString() + "\r\n");
            txtInfo.AppendText("\r\nRandom Extension Polynomial 2\r\n" + extp2.ToString() + "\r\n");
            txtInfo.AppendText("\r\nPolynomial 1 + Polynomial 2\r\n" + result.ToString() + "\r\n");

        }

        private void btnExtPolyMult_Click(object sender, EventArgs e)
        {
            ExtensionFieldElement[] eltlist1 = new ExtensionFieldElement[7];

            for (int i = 0; i < 7; i++)
                eltlist1[i] = ExtF.RandomElement;

            ExtensionPolynomial extp1 = new ExtensionPolynomial(eltlist1);

            ExtensionFieldElement[] eltlist2 = new ExtensionFieldElement[4];

            for (int i = 0; i < 4; i++)
                eltlist2[i] = ExtF.RandomElement;

            ExtensionPolynomial extp2 = new ExtensionPolynomial(eltlist2);

            ExtensionPolynomial result = extp1 * extp2;

            txtInfo.Clear();
            txtInfo.AppendText("Random Extension Polynomial 1\r\n" + extp1.ToString() + "\r\n");
            txtInfo.AppendText("\r\nRandom Extension Polynomial 2\r\n" + extp2.ToString() + "\r\n");
            txtInfo.AppendText("\r\nPolynomial 1 * Polynomial 2\r\n" + result.ToString() + "\r\n");
        }

        ExtensionLFSR lfsr = null;
        int s = 0;
        private void btnLFSR_Click(object sender, EventArgs e)
        {
            if (lfsr == null)
            {
                ExtensionFieldElement[] eltlist1 = new ExtensionFieldElement[4];

                for (int i = 0; i < 4; i++)
                    eltlist1[i] = ExtF.RandomElement;

                ExtensionPolynomial extp1 = new ExtensionPolynomial(eltlist1);

                ExtensionFieldElement[] eltlist2 = new ExtensionFieldElement[4];

                for (int i = 0; i < 4; i++)
                    eltlist2[i] = ExtF.RandomElement;

                lfsr = new ExtensionLFSR(extp1, eltlist2);

                txtInfo.Clear();
                txtInfo.AppendText("LFSR has been created.\r\n");
                txtInfo.AppendText("Feedback Polynomial:\r\n" + lfsr.FeedbackPolynomial.ToString() + "\r\n");
                txtInfo.AppendText("Initial State:\r\n");
                for (int i = 0; i < lfsr.currentState.Length; i++)
                    txtInfo.AppendText("c_" + i + " = " + lfsr.currentState[i].ToString() + "\r\n");
                
                btnLFSR.Text = "Clock the LFSR";

                return;
            }

            // clock time

            lfsr.Clock();
            txtInfo.AppendText("\r\nOutput " + s++ + " : " + lfsr.StreamOutput + "\r\n");
            txtInfo.AppendText("Current State:\r\n");
            for (int i = 0; i < lfsr.currentState.Length; i++)
                txtInfo.AppendText("c_" + i + " = " + lfsr.currentState[i].ToString() + "\r\n");

        }

    }
}
