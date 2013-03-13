using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FiniteFieldArithmetics;

/*
Author: Halil Kemal TAŞKIN
Web: http://hkt.me
*/

namespace BerlekampMasseyWeb
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRunBM_Click(object sender, EventArgs e)
        {
            FiniteField F = null;
            int p = int.Parse(txtSize.Text.Trim());
            if (MathTools.IsPrime(p))
            {
                F = new FiniteField(p);
            }
            else
            {
                Response.Clear();
                Response.Write("Please write a prime number!");
                Response.End();
            }

            // Clean The Mess
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

            if (newseq.Length == 0)
            {
                Response.Clear();
                Response.Write("Please enter the sequence.");
                Response.End();
            }

            txtSeq.Text = newseq;
            Polynomial poly = Polynomial.Parse(F, newseq, false);
            Polynomial c;
            int LC = LFSRTools.BerlekampMassey(poly, out c);
            lblResult.Text = "Sequence Length = " + newseq.Length + "<br/>" +
                             "Linear Complexity = " + LC + "<br/>" +
                             "Connection Polynomial = " + c.ToString();
        }
    }
}
