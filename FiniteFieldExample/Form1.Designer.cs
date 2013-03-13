namespace FiniteFieldExample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrmElt = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnConjugates = new System.Windows.Forms.Button();
            this.btnTrace = new System.Windows.Forms.Button();
            this.btnNorm = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubs = new System.Windows.Forms.Button();
            this.btnMultip = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnGenBasis = new System.Windows.Forms.Button();
            this.btnBasisDisc = new System.Windows.Forms.Button();
            this.btnFindDual = new System.Windows.Forms.Button();
            this.lblClear = new System.Windows.Forms.Label();
            this.btnExtPolyAdd = new System.Windows.Forms.Button();
            this.btnExtPolyMult = new System.Windows.Forms.Button();
            this.btnLFSR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrmElt
            // 
            this.btnPrmElt.Location = new System.Drawing.Point(13, 190);
            this.btnPrmElt.Name = "btnPrmElt";
            this.btnPrmElt.Size = new System.Drawing.Size(156, 23);
            this.btnPrmElt.TabIndex = 8;
            this.btnPrmElt.Text = "Random Primitive Element";
            this.btnPrmElt.UseVisualStyleBackColor = true;
            this.btnPrmElt.Click += new System.EventHandler(this.btnPrmElt_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInfo.Location = new System.Drawing.Point(335, 38);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(407, 378);
            this.txtInfo.TabIndex = 1;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(13, 219);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(156, 23);
            this.btnOrder.TabIndex = 9;
            this.btnOrder.Text = "Order of element";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnConjugates
            // 
            this.btnConjugates.Location = new System.Drawing.Point(13, 248);
            this.btnConjugates.Name = "btnConjugates";
            this.btnConjugates.Size = new System.Drawing.Size(156, 23);
            this.btnConjugates.TabIndex = 10;
            this.btnConjugates.Text = "Conjugates of element";
            this.btnConjugates.UseVisualStyleBackColor = true;
            this.btnConjugates.Click += new System.EventHandler(this.btnConjugates_Click);
            // 
            // btnTrace
            // 
            this.btnTrace.Location = new System.Drawing.Point(13, 277);
            this.btnTrace.Name = "btnTrace";
            this.btnTrace.Size = new System.Drawing.Size(155, 23);
            this.btnTrace.TabIndex = 11;
            this.btnTrace.Text = "Trace of element";
            this.btnTrace.UseVisualStyleBackColor = true;
            this.btnTrace.Click += new System.EventHandler(this.btnTrace_Click);
            // 
            // btnNorm
            // 
            this.btnNorm.Location = new System.Drawing.Point(13, 306);
            this.btnNorm.Name = "btnNorm";
            this.btnNorm.Size = new System.Drawing.Size(155, 23);
            this.btnNorm.TabIndex = 12;
            this.btnNorm.Text = "Norm of element";
            this.btnNorm.UseVisualStyleBackColor = true;
            this.btnNorm.Click += new System.EventHandler(this.btnNorm_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 73);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Addition";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubs
            // 
            this.btnSubs.Location = new System.Drawing.Point(13, 102);
            this.btnSubs.Name = "btnSubs";
            this.btnSubs.Size = new System.Drawing.Size(155, 23);
            this.btnSubs.TabIndex = 5;
            this.btnSubs.Text = "Substraction";
            this.btnSubs.UseVisualStyleBackColor = true;
            this.btnSubs.Click += new System.EventHandler(this.btnSubs_Click);
            // 
            // btnMultip
            // 
            this.btnMultip.Location = new System.Drawing.Point(13, 132);
            this.btnMultip.Name = "btnMultip";
            this.btnMultip.Size = new System.Drawing.Size(155, 23);
            this.btnMultip.TabIndex = 6;
            this.btnMultip.Text = "Multiplication";
            this.btnMultip.UseVisualStyleBackColor = true;
            this.btnMultip.Click += new System.EventHandler(this.btnMultip_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(13, 161);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(155, 23);
            this.btnDivision.TabIndex = 7;
            this.btnDivision.Text = "Division";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo.Location = new System.Drawing.Point(9, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(36, 20);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "test";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(13, 41);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(155, 23);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Current Field Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnGenBasis
            // 
            this.btnGenBasis.Enabled = false;
            this.btnGenBasis.Location = new System.Drawing.Point(12, 335);
            this.btnGenBasis.Name = "btnGenBasis";
            this.btnGenBasis.Size = new System.Drawing.Size(156, 23);
            this.btnGenBasis.TabIndex = 13;
            this.btnGenBasis.Text = "Generate Basis";
            this.btnGenBasis.UseVisualStyleBackColor = true;
            this.btnGenBasis.Click += new System.EventHandler(this.btnGenBasis_Click);
            // 
            // btnBasisDisc
            // 
            this.btnBasisDisc.Enabled = false;
            this.btnBasisDisc.Location = new System.Drawing.Point(13, 364);
            this.btnBasisDisc.Name = "btnBasisDisc";
            this.btnBasisDisc.Size = new System.Drawing.Size(155, 23);
            this.btnBasisDisc.TabIndex = 14;
            this.btnBasisDisc.Text = "Discriminant of Basis";
            this.btnBasisDisc.UseVisualStyleBackColor = true;
            this.btnBasisDisc.Click += new System.EventHandler(this.btnBasisDisc_Click);
            // 
            // btnFindDual
            // 
            this.btnFindDual.Enabled = false;
            this.btnFindDual.Location = new System.Drawing.Point(13, 393);
            this.btnFindDual.Name = "btnFindDual";
            this.btnFindDual.Size = new System.Drawing.Size(155, 23);
            this.btnFindDual.TabIndex = 15;
            this.btnFindDual.Text = "Find Dual Basis";
            this.btnFindDual.UseVisualStyleBackColor = true;
            this.btnFindDual.Click += new System.EventHandler(this.btnFindDual_Click);
            // 
            // lblClear
            // 
            this.lblClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClear.AutoSize = true;
            this.lblClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClear.Location = new System.Drawing.Point(670, 420);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(72, 13);
            this.lblClear.TabIndex = 0;
            this.lblClear.Text = "Clear Textbox";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            this.lblClear.MouseEnter += new System.EventHandler(this.lblClear_MouseEnter);
            this.lblClear.MouseLeave += new System.EventHandler(this.lblClear_MouseLeave);
            // 
            // btnExtPolyAdd
            // 
            this.btnExtPolyAdd.Location = new System.Drawing.Point(174, 41);
            this.btnExtPolyAdd.Name = "btnExtPolyAdd";
            this.btnExtPolyAdd.Size = new System.Drawing.Size(155, 23);
            this.btnExtPolyAdd.TabIndex = 16;
            this.btnExtPolyAdd.Text = "Ext. Poly. Addition";
            this.btnExtPolyAdd.UseVisualStyleBackColor = true;
            this.btnExtPolyAdd.Click += new System.EventHandler(this.btnExtPolyAdd_Click);
            // 
            // btnExtPolyMult
            // 
            this.btnExtPolyMult.Location = new System.Drawing.Point(174, 73);
            this.btnExtPolyMult.Name = "btnExtPolyMult";
            this.btnExtPolyMult.Size = new System.Drawing.Size(155, 23);
            this.btnExtPolyMult.TabIndex = 17;
            this.btnExtPolyMult.Text = "Ext. Poly. Multiplication";
            this.btnExtPolyMult.UseVisualStyleBackColor = true;
            this.btnExtPolyMult.Click += new System.EventHandler(this.btnExtPolyMult_Click);
            // 
            // btnLFSR
            // 
            this.btnLFSR.Location = new System.Drawing.Point(174, 102);
            this.btnLFSR.Name = "btnLFSR";
            this.btnLFSR.Size = new System.Drawing.Size(155, 23);
            this.btnLFSR.TabIndex = 18;
            this.btnLFSR.Text = "Generate LFSR";
            this.btnLFSR.UseVisualStyleBackColor = true;
            this.btnLFSR.Click += new System.EventHandler(this.btnLFSR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 438);
            this.Controls.Add(this.btnLFSR);
            this.Controls.Add(this.btnExtPolyMult);
            this.Controls.Add(this.btnExtPolyAdd);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.btnFindDual);
            this.Controls.Add(this.btnBasisDisc);
            this.Controls.Add(this.btnGenBasis);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultip);
            this.Controls.Add(this.btnSubs);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNorm);
            this.Controls.Add(this.btnTrace);
            this.Controls.Add(this.btnConjugates);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnPrmElt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Halil Kemal TAŞKIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrmElt;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnConjugates;
        private System.Windows.Forms.Button btnTrace;
        private System.Windows.Forms.Button btnNorm;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubs;
        private System.Windows.Forms.Button btnMultip;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnGenBasis;
        private System.Windows.Forms.Button btnBasisDisc;
        private System.Windows.Forms.Button btnFindDual;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.Button btnExtPolyAdd;
        private System.Windows.Forms.Button btnExtPolyMult;
        private System.Windows.Forms.Button btnLFSR;
    }
}

