namespace Homework4Example
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOrderPoly = new System.Windows.Forms.TabPage();
            this.Tab1nupFieldSize = new System.Windows.Forms.NumericUpDown();
            this.Tab1label3 = new System.Windows.Forms.Label();
            this.Tab1lblResult = new System.Windows.Forms.Label();
            this.Tab1txtPolyCoefs = new System.Windows.Forms.TextBox();
            this.Tab1btnFindOrder = new System.Windows.Forms.Button();
            this.Tab1label1 = new System.Windows.Forms.Label();
            this.tabNonlinComb = new System.Windows.Forms.TabPage();
            this.Tab2txtResult = new System.Windows.Forms.TextBox();
            this.Tab2btnFindPeriodLC = new System.Windows.Forms.Button();
            this.Tab2lblNonLinComb = new System.Windows.Forms.Label();
            this.Tab2lblLFSR4 = new System.Windows.Forms.Label();
            this.Tab2lblLFSR3 = new System.Windows.Forms.Label();
            this.Tab2lblLFSR2 = new System.Windows.Forms.Label();
            this.Tab2lblLFSR1 = new System.Windows.Forms.Label();
            this.tabNumRuns = new System.Windows.Forms.TabPage();
            this.Tab3splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Tab3btnAutoCorr = new System.Windows.Forms.Button();
            this.Tab3btnFindRuns = new System.Windows.Forms.Button();
            this.Tab3txtBinSeq = new System.Windows.Forms.TextBox();
            this.Tab3lblBinSeq = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Tab3lblTotalRun = new System.Windows.Forms.ToolStripStatusLabel();
            this.Tab3dtGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabOrderPoly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab1nupFieldSize)).BeginInit();
            this.tabNonlinComb.SuspendLayout();
            this.tabNumRuns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab3splitContainer1)).BeginInit();
            this.Tab3splitContainer1.Panel1.SuspendLayout();
            this.Tab3splitContainer1.Panel2.SuspendLayout();
            this.Tab3splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab3dtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOrderPoly);
            this.tabControl1.Controls.Add(this.tabNonlinComb);
            this.tabControl1.Controls.Add(this.tabNumRuns);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(836, 391);
            this.tabControl1.TabIndex = 0;
            // 
            // tabOrderPoly
            // 
            this.tabOrderPoly.Controls.Add(this.Tab1nupFieldSize);
            this.tabOrderPoly.Controls.Add(this.Tab1label3);
            this.tabOrderPoly.Controls.Add(this.Tab1lblResult);
            this.tabOrderPoly.Controls.Add(this.Tab1txtPolyCoefs);
            this.tabOrderPoly.Controls.Add(this.Tab1btnFindOrder);
            this.tabOrderPoly.Controls.Add(this.Tab1label1);
            this.tabOrderPoly.Location = new System.Drawing.Point(4, 22);
            this.tabOrderPoly.Name = "tabOrderPoly";
            this.tabOrderPoly.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrderPoly.Size = new System.Drawing.Size(828, 365);
            this.tabOrderPoly.TabIndex = 1;
            this.tabOrderPoly.Text = "Order of a Polynomial";
            this.tabOrderPoly.UseVisualStyleBackColor = true;
            // 
            // Tab1nupFieldSize
            // 
            this.Tab1nupFieldSize.Location = new System.Drawing.Point(99, 10);
            this.Tab1nupFieldSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Tab1nupFieldSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Tab1nupFieldSize.Name = "Tab1nupFieldSize";
            this.Tab1nupFieldSize.Size = new System.Drawing.Size(46, 20);
            this.Tab1nupFieldSize.TabIndex = 1;
            this.Tab1nupFieldSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Tab1label3
            // 
            this.Tab1label3.AutoSize = true;
            this.Tab1label3.Location = new System.Drawing.Point(8, 12);
            this.Tab1label3.Name = "Tab1label3";
            this.Tab1label3.Size = new System.Drawing.Size(90, 13);
            this.Tab1label3.TabIndex = 0;
            this.Tab1label3.Text = "Finite Field of size";
            // 
            // Tab1lblResult
            // 
            this.Tab1lblResult.AutoSize = true;
            this.Tab1lblResult.Location = new System.Drawing.Point(8, 88);
            this.Tab1lblResult.Name = "Tab1lblResult";
            this.Tab1lblResult.Size = new System.Drawing.Size(254, 26);
            this.Tab1lblResult.TabIndex = 5;
            this.Tab1lblResult.Text = "Please enter a polynomial.\r\nExample: 4*x^3 + x^2 + 3 should be written as 3014 ";
            // 
            // Tab1txtPolyCoefs
            // 
            this.Tab1txtPolyCoefs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab1txtPolyCoefs.Location = new System.Drawing.Point(99, 36);
            this.Tab1txtPolyCoefs.Name = "Tab1txtPolyCoefs";
            this.Tab1txtPolyCoefs.Size = new System.Drawing.Size(721, 20);
            this.Tab1txtPolyCoefs.TabIndex = 3;
            this.Tab1txtPolyCoefs.Text = "3014";
            // 
            // Tab1btnFindOrder
            // 
            this.Tab1btnFindOrder.Location = new System.Drawing.Point(99, 62);
            this.Tab1btnFindOrder.Name = "Tab1btnFindOrder";
            this.Tab1btnFindOrder.Size = new System.Drawing.Size(192, 23);
            this.Tab1btnFindOrder.TabIndex = 4;
            this.Tab1btnFindOrder.Text = "Find Order";
            this.Tab1btnFindOrder.UseVisualStyleBackColor = true;
            this.Tab1btnFindOrder.Click += new System.EventHandler(this.Tab1btnFindOrder_Click);
            // 
            // Tab1label1
            // 
            this.Tab1label1.AutoSize = true;
            this.Tab1label1.Location = new System.Drawing.Point(8, 39);
            this.Tab1label1.Name = "Tab1label1";
            this.Tab1label1.Size = new System.Drawing.Size(57, 13);
            this.Tab1label1.TabIndex = 2;
            this.Tab1label1.Text = "Polynomial";
            // 
            // tabNonlinComb
            // 
            this.tabNonlinComb.Controls.Add(this.Tab2txtResult);
            this.tabNonlinComb.Controls.Add(this.Tab2btnFindPeriodLC);
            this.tabNonlinComb.Controls.Add(this.Tab2lblNonLinComb);
            this.tabNonlinComb.Controls.Add(this.Tab2lblLFSR4);
            this.tabNonlinComb.Controls.Add(this.Tab2lblLFSR3);
            this.tabNonlinComb.Controls.Add(this.Tab2lblLFSR2);
            this.tabNonlinComb.Controls.Add(this.Tab2lblLFSR1);
            this.tabNonlinComb.Location = new System.Drawing.Point(4, 22);
            this.tabNonlinComb.Name = "tabNonlinComb";
            this.tabNonlinComb.Padding = new System.Windows.Forms.Padding(3);
            this.tabNonlinComb.Size = new System.Drawing.Size(828, 365);
            this.tabNonlinComb.TabIndex = 4;
            this.tabNonlinComb.Text = "4 LFSRs & Non-linear Combiner";
            this.tabNonlinComb.UseVisualStyleBackColor = true;
            // 
            // Tab2txtResult
            // 
            this.Tab2txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab2txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Tab2txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tab2txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tab2txtResult.Location = new System.Drawing.Point(461, 6);
            this.Tab2txtResult.Multiline = true;
            this.Tab2txtResult.Name = "Tab2txtResult";
            this.Tab2txtResult.ReadOnly = true;
            this.Tab2txtResult.Size = new System.Drawing.Size(359, 353);
            this.Tab2txtResult.TabIndex = 6;
            // 
            // Tab2btnFindPeriodLC
            // 
            this.Tab2btnFindPeriodLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tab2btnFindPeriodLC.Location = new System.Drawing.Point(388, 119);
            this.Tab2btnFindPeriodLC.Name = "Tab2btnFindPeriodLC";
            this.Tab2btnFindPeriodLC.Size = new System.Drawing.Size(67, 124);
            this.Tab2btnFindPeriodLC.TabIndex = 5;
            this.Tab2btnFindPeriodLC.Text = "Find Period && LC";
            this.Tab2btnFindPeriodLC.UseVisualStyleBackColor = true;
            this.Tab2btnFindPeriodLC.Click += new System.EventHandler(this.Tab2btnFindPeriodLC_Click);
            // 
            // Tab2lblNonLinComb
            // 
            this.Tab2lblNonLinComb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Tab2lblNonLinComb.Location = new System.Drawing.Point(282, 3);
            this.Tab2lblNonLinComb.Name = "Tab2lblNonLinComb";
            this.Tab2lblNonLinComb.Size = new System.Drawing.Size(100, 357);
            this.Tab2lblNonLinComb.TabIndex = 4;
            this.Tab2lblNonLinComb.Text = "Non-linear Combiner";
            this.Tab2lblNonLinComb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tab2lblLFSR4
            // 
            this.Tab2lblLFSR4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Tab2lblLFSR4.Location = new System.Drawing.Point(8, 275);
            this.Tab2lblLFSR4.Name = "Tab2lblLFSR4";
            this.Tab2lblLFSR4.Size = new System.Drawing.Size(268, 85);
            this.Tab2lblLFSR4.TabIndex = 3;
            this.Tab2lblLFSR4.Text = "LFSR4";
            this.Tab2lblLFSR4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tab2lblLFSR3
            // 
            this.Tab2lblLFSR3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Tab2lblLFSR3.Location = new System.Drawing.Point(8, 185);
            this.Tab2lblLFSR3.Name = "Tab2lblLFSR3";
            this.Tab2lblLFSR3.Size = new System.Drawing.Size(268, 85);
            this.Tab2lblLFSR3.TabIndex = 2;
            this.Tab2lblLFSR3.Text = "LFSR3";
            this.Tab2lblLFSR3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tab2lblLFSR2
            // 
            this.Tab2lblLFSR2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Tab2lblLFSR2.Location = new System.Drawing.Point(8, 94);
            this.Tab2lblLFSR2.Name = "Tab2lblLFSR2";
            this.Tab2lblLFSR2.Size = new System.Drawing.Size(268, 85);
            this.Tab2lblLFSR2.TabIndex = 1;
            this.Tab2lblLFSR2.Text = "LFSR2";
            this.Tab2lblLFSR2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tab2lblLFSR1
            // 
            this.Tab2lblLFSR1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Tab2lblLFSR1.Location = new System.Drawing.Point(8, 3);
            this.Tab2lblLFSR1.Name = "Tab2lblLFSR1";
            this.Tab2lblLFSR1.Size = new System.Drawing.Size(268, 85);
            this.Tab2lblLFSR1.TabIndex = 0;
            this.Tab2lblLFSR1.Text = "LFSR1";
            this.Tab2lblLFSR1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabNumRuns
            // 
            this.tabNumRuns.Controls.Add(this.Tab3splitContainer1);
            this.tabNumRuns.Location = new System.Drawing.Point(4, 22);
            this.tabNumRuns.Name = "tabNumRuns";
            this.tabNumRuns.Padding = new System.Windows.Forms.Padding(3);
            this.tabNumRuns.Size = new System.Drawing.Size(828, 365);
            this.tabNumRuns.TabIndex = 3;
            this.tabNumRuns.Text = "Number of the runs & Binary Auto Correlation Values";
            this.tabNumRuns.UseVisualStyleBackColor = true;
            // 
            // Tab3splitContainer1
            // 
            this.Tab3splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab3splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.Tab3splitContainer1.Name = "Tab3splitContainer1";
            // 
            // Tab3splitContainer1.Panel1
            // 
            this.Tab3splitContainer1.Panel1.Controls.Add(this.Tab3btnAutoCorr);
            this.Tab3splitContainer1.Panel1.Controls.Add(this.Tab3btnFindRuns);
            this.Tab3splitContainer1.Panel1.Controls.Add(this.Tab3txtBinSeq);
            this.Tab3splitContainer1.Panel1.Controls.Add(this.Tab3lblBinSeq);
            // 
            // Tab3splitContainer1.Panel2
            // 
            this.Tab3splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.Tab3splitContainer1.Panel2.Controls.Add(this.Tab3dtGrid);
            this.Tab3splitContainer1.Size = new System.Drawing.Size(822, 359);
            this.Tab3splitContainer1.SplitterDistance = 527;
            this.Tab3splitContainer1.TabIndex = 0;
            // 
            // Tab3btnAutoCorr
            // 
            this.Tab3btnAutoCorr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab3btnAutoCorr.Location = new System.Drawing.Point(204, 3);
            this.Tab3btnAutoCorr.Name = "Tab3btnAutoCorr";
            this.Tab3btnAutoCorr.Size = new System.Drawing.Size(157, 23);
            this.Tab3btnAutoCorr.TabIndex = 2;
            this.Tab3btnAutoCorr.Text = "Find Auto Correlation Values";
            this.Tab3btnAutoCorr.UseVisualStyleBackColor = true;
            this.Tab3btnAutoCorr.Click += new System.EventHandler(this.Tab3btnAutoCorr_Click);
            // 
            // Tab3btnFindRuns
            // 
            this.Tab3btnFindRuns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab3btnFindRuns.Location = new System.Drawing.Point(367, 3);
            this.Tab3btnFindRuns.Name = "Tab3btnFindRuns";
            this.Tab3btnFindRuns.Size = new System.Drawing.Size(158, 23);
            this.Tab3btnFindRuns.TabIndex = 3;
            this.Tab3btnFindRuns.Text = "Find Number of the Runs";
            this.Tab3btnFindRuns.UseVisualStyleBackColor = true;
            this.Tab3btnFindRuns.Click += new System.EventHandler(this.Tab3btnFindRuns_Click);
            // 
            // Tab3txtBinSeq
            // 
            this.Tab3txtBinSeq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab3txtBinSeq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tab3txtBinSeq.Location = new System.Drawing.Point(3, 32);
            this.Tab3txtBinSeq.Multiline = true;
            this.Tab3txtBinSeq.Name = "Tab3txtBinSeq";
            this.Tab3txtBinSeq.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Tab3txtBinSeq.Size = new System.Drawing.Size(522, 322);
            this.Tab3txtBinSeq.TabIndex = 1;
            this.Tab3txtBinSeq.Text = resources.GetString("Tab3txtBinSeq.Text");
            this.Tab3txtBinSeq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tab3txtBinSeq_KeyPress);
            this.Tab3txtBinSeq.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tab3txtBinSeq_KeyUp);
            // 
            // Tab3lblBinSeq
            // 
            this.Tab3lblBinSeq.AutoSize = true;
            this.Tab3lblBinSeq.Location = new System.Drawing.Point(5, 8);
            this.Tab3lblBinSeq.Name = "Tab3lblBinSeq";
            this.Tab3lblBinSeq.Size = new System.Drawing.Size(88, 13);
            this.Tab3lblBinSeq.TabIndex = 0;
            this.Tab3lblBinSeq.Text = "Binary Sequence";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tab3lblTotalRun});
            this.statusStrip1.Location = new System.Drawing.Point(0, 337);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(291, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Tab3lblTotalRun
            // 
            this.Tab3lblTotalRun.Name = "Tab3lblTotalRun";
            this.Tab3lblTotalRun.Size = new System.Drawing.Size(48, 17);
            this.Tab3lblTotalRun.Text = "Ready...";
            // 
            // Tab3dtGrid
            // 
            this.Tab3dtGrid.AllowUserToAddRows = false;
            this.Tab3dtGrid.AllowUserToResizeRows = false;
            this.Tab3dtGrid.BackgroundColor = System.Drawing.Color.White;
            this.Tab3dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tab3dtGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab3dtGrid.Location = new System.Drawing.Point(0, 0);
            this.Tab3dtGrid.MultiSelect = false;
            this.Tab3dtGrid.Name = "Tab3dtGrid";
            this.Tab3dtGrid.ReadOnly = true;
            this.Tab3dtGrid.RowHeadersVisible = false;
            this.Tab3dtGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Tab3dtGrid.ShowEditingIcon = false;
            this.Tab3dtGrid.Size = new System.Drawing.Size(291, 359);
            this.Tab3dtGrid.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 391);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "IAM 705 Homework #4 Example - Halil Kemal TAŞKIN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabOrderPoly.ResumeLayout(false);
            this.tabOrderPoly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab1nupFieldSize)).EndInit();
            this.tabNonlinComb.ResumeLayout(false);
            this.tabNonlinComb.PerformLayout();
            this.tabNumRuns.ResumeLayout(false);
            this.Tab3splitContainer1.Panel1.ResumeLayout(false);
            this.Tab3splitContainer1.Panel1.PerformLayout();
            this.Tab3splitContainer1.Panel2.ResumeLayout(false);
            this.Tab3splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab3splitContainer1)).EndInit();
            this.Tab3splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab3dtGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOrderPoly;
        private System.Windows.Forms.NumericUpDown Tab1nupFieldSize;
        private System.Windows.Forms.Label Tab1label3;
        private System.Windows.Forms.Label Tab1lblResult;
        private System.Windows.Forms.TextBox Tab1txtPolyCoefs;
        private System.Windows.Forms.Button Tab1btnFindOrder;
        private System.Windows.Forms.Label Tab1label1;
        private System.Windows.Forms.TabPage tabNumRuns;
        private System.Windows.Forms.SplitContainer Tab3splitContainer1;
        private System.Windows.Forms.Button Tab3btnFindRuns;
        private System.Windows.Forms.TextBox Tab3txtBinSeq;
        private System.Windows.Forms.Label Tab3lblBinSeq;
        private System.Windows.Forms.DataGridView Tab3dtGrid;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Tab3lblTotalRun;
        private System.Windows.Forms.Button Tab3btnAutoCorr;
        private System.Windows.Forms.TabPage tabNonlinComb;
        private System.Windows.Forms.TextBox Tab2txtResult;
        private System.Windows.Forms.Button Tab2btnFindPeriodLC;
        private System.Windows.Forms.Label Tab2lblNonLinComb;
        private System.Windows.Forms.Label Tab2lblLFSR4;
        private System.Windows.Forms.Label Tab2lblLFSR3;
        private System.Windows.Forms.Label Tab2lblLFSR2;
        private System.Windows.Forms.Label Tab2lblLFSR1;
    }
}

