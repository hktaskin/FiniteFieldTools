namespace LFSRSequenceGeneratorExample
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblSizeName = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.txtInitial = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenSeq = new System.Windows.Forms.Button();
            this.nupCount = new System.Windows.Forms.NumericUpDown();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblInitial = new System.Windows.Forms.Label();
            this.lblSeqSize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFixValues = new System.Windows.Forms.Button();
            this.btnFixField = new System.Windows.Forms.Button();
            this.btnFindPeriod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.White;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo.Location = new System.Drawing.Point(338, 12);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(174, 18);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Please enter field size";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSizeName
            // 
            this.lblSizeName.AutoSize = true;
            this.lblSizeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSizeName.Location = new System.Drawing.Point(12, 12);
            this.lblSizeName.Name = "lblSizeName";
            this.lblSizeName.Size = new System.Drawing.Size(141, 18);
            this.lblSizeName.TabIndex = 0;
            this.lblSizeName.Text = "Finite field of size";
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.SystemColors.Window;
            this.txtSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSize.Location = new System.Drawing.Point(187, 10);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(64, 24);
            this.txtSize.TabIndex = 1;
            this.txtSize.Text = "2";
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Initial State";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Feedback Polynomial";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFeedback.BackColor = System.Drawing.SystemColors.Window;
            this.txtFeedback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFeedback.Location = new System.Drawing.Point(187, 40);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(462, 24);
            this.txtFeedback.TabIndex = 5;
            this.txtFeedback.TextChanged += new System.EventHandler(this.txtInitial_TextChanged);
            this.txtFeedback.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFeedback_KeyDown);
            this.txtFeedback.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFeedback_KeyPress);
            this.txtFeedback.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFeedback_KeyUp);
            // 
            // txtInitial
            // 
            this.txtInitial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInitial.BackColor = System.Drawing.SystemColors.Window;
            this.txtInitial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInitial.Location = new System.Drawing.Point(187, 83);
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.Size = new System.Drawing.Size(462, 24);
            this.txtInitial.TabIndex = 9;
            this.txtInitial.TextChanged += new System.EventHandler(this.txtInitial_TextChanged);
            this.txtInitial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFeedback_KeyDown);
            this.txtInitial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFeedback_KeyPress);
            this.txtInitial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFeedback_KeyUp);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.BackColor = System.Drawing.SystemColors.Window;
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOutput.Location = new System.Drawing.Point(12, 151);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(637, 219);
            this.txtOutput.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Output Sequence";
            // 
            // btnGenSeq
            // 
            this.btnGenSeq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenSeq.Enabled = false;
            this.btnGenSeq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenSeq.Location = new System.Drawing.Point(532, 122);
            this.btnGenSeq.Name = "btnGenSeq";
            this.btnGenSeq.Size = new System.Drawing.Size(50, 23);
            this.btnGenSeq.TabIndex = 16;
            this.btnGenSeq.Text = "Clock";
            this.btnGenSeq.UseVisualStyleBackColor = true;
            this.btnGenSeq.Click += new System.EventHandler(this.btnGenSeq_Click);
            // 
            // nupCount
            // 
            this.nupCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nupCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nupCount.Location = new System.Drawing.Point(447, 123);
            this.nupCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupCount.Name = "nupCount";
            this.nupCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nupCount.Size = new System.Drawing.Size(79, 22);
            this.nupCount.TabIndex = 15;
            this.nupCount.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nupCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(184, 67);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(55, 13);
            this.lblFeedback.TabIndex = 7;
            this.lblFeedback.Text = "Feedback";
            // 
            // lblInitial
            // 
            this.lblInitial.AutoSize = true;
            this.lblInitial.Location = new System.Drawing.Point(184, 110);
            this.lblInitial.Name = "lblInitial";
            this.lblInitial.Size = new System.Drawing.Size(59, 13);
            this.lblInitial.TabIndex = 11;
            this.lblInitial.Text = "Initial State";
            // 
            // lblSeqSize
            // 
            this.lblSeqSize.AutoSize = true;
            this.lblSeqSize.Location = new System.Drawing.Point(184, 135);
            this.lblSeqSize.Name = "lblSeqSize";
            this.lblSeqSize.Size = new System.Drawing.Size(0, 13);
            this.lblSeqSize.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "MSB on Left";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "MSB on Left";
            // 
            // btnFixValues
            // 
            this.btnFixValues.Enabled = false;
            this.btnFixValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixValues.Location = new System.Drawing.Point(292, 125);
            this.btnFixValues.Name = "btnFixValues";
            this.btnFixValues.Size = new System.Drawing.Size(117, 23);
            this.btnFixValues.TabIndex = 14;
            this.btnFixValues.Text = "Fix the System";
            this.btnFixValues.UseVisualStyleBackColor = true;
            this.btnFixValues.Click += new System.EventHandler(this.btnFixValues_Click);
            // 
            // btnFixField
            // 
            this.btnFixField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixField.Location = new System.Drawing.Point(257, 11);
            this.btnFixField.Name = "btnFixField";
            this.btnFixField.Size = new System.Drawing.Size(75, 23);
            this.btnFixField.TabIndex = 2;
            this.btnFixField.Text = "Fix the Field";
            this.btnFixField.UseVisualStyleBackColor = true;
            this.btnFixField.Click += new System.EventHandler(this.btnFixField_Click);
            // 
            // btnFindPeriod
            // 
            this.btnFindPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindPeriod.Location = new System.Drawing.Point(588, 122);
            this.btnFindPeriod.Name = "btnFindPeriod";
            this.btnFindPeriod.Size = new System.Drawing.Size(61, 23);
            this.btnFindPeriod.TabIndex = 17;
            this.btnFindPeriod.Text = "Period";
            this.btnFindPeriod.UseVisualStyleBackColor = true;
            this.btnFindPeriod.Click += new System.EventHandler(this.btnFindPeriod_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGenSeq;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 382);
            this.Controls.Add(this.btnFindPeriod);
            this.Controls.Add(this.btnFixField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSeqSize);
            this.Controls.Add(this.lblInitial);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.nupCount);
            this.Controls.Add(this.btnFixValues);
            this.Controls.Add(this.btnGenSeq);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInitial);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblSizeName);
            this.Controls.Add(this.txtSize);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LFSR Sequence Generator over Finite Field - Halil Kemal TAŞKIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblSizeName;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.TextBox txtInitial;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenSeq;
        private System.Windows.Forms.NumericUpDown nupCount;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblInitial;
        private System.Windows.Forms.Label lblSeqSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFixValues;
        private System.Windows.Forms.Button btnFixField;
        private System.Windows.Forms.Button btnFindPeriod;
    }
}

