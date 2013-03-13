namespace BerlekampMasseyExample
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
            this.lblSizeName = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtSeq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRunBM = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnCleanSeq = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSizeName
            // 
            this.lblSizeName.AutoSize = true;
            this.lblSizeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSizeName.Location = new System.Drawing.Point(12, 9);
            this.lblSizeName.Name = "lblSizeName";
            this.lblSizeName.Size = new System.Drawing.Size(200, 25);
            this.lblSizeName.TabIndex = 0;
            this.lblSizeName.Text = "Finite field of size";
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.SystemColors.Control;
            this.txtSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSize.Location = new System.Drawing.Point(218, 7);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(96, 31);
            this.txtSize.TabIndex = 1;
            this.txtSize.Text = "2";
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSize.Leave += new System.EventHandler(this.txtSize_Leave);
            // 
            // txtSeq
            // 
            this.txtSeq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeq.Location = new System.Drawing.Point(12, 76);
            this.txtSeq.Multiline = true;
            this.txtSeq.Name = "txtSeq";
            this.txtSeq.Size = new System.Drawing.Size(605, 288);
            this.txtSeq.TabIndex = 6;
            this.txtSeq.Text = resources.GetString("txtSeq.Text");
            this.txtSeq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeq_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sequence";
            // 
            // btnRunBM
            // 
            this.btnRunBM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunBM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRunBM.Location = new System.Drawing.Point(317, 370);
            this.btnRunBM.Name = "btnRunBM";
            this.btnRunBM.Size = new System.Drawing.Size(309, 30);
            this.btnRunBM.TabIndex = 8;
            this.btnRunBM.Text = "Run the Berlekamp-Massey Algorithm";
            this.btnRunBM.UseVisualStyleBackColor = true;
            this.btnRunBM.Click += new System.EventHandler(this.btnRunBM_Click);
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtResult.Location = new System.Drawing.Point(0, 0);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(629, 73);
            this.txtResult.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(320, 18);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(27, 13);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Halil";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCleanSeq
            // 
            this.btnCleanSeq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCleanSeq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanSeq.Location = new System.Drawing.Point(517, 50);
            this.btnCleanSeq.Name = "btnCleanSeq";
            this.btnCleanSeq.Size = new System.Drawing.Size(100, 23);
            this.btnCleanSeq.TabIndex = 5;
            this.btnCleanSeq.Text = "Clean the mess";
            this.btnCleanSeq.UseVisualStyleBackColor = true;
            this.btnCleanSeq.Click += new System.EventHandler(this.btnCleanSeq_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Location = new System.Drawing.Point(411, 50);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(100, 23);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "To Clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lblInfo);
            this.splitContainer1.Panel1.Controls.Add(this.btnRunBM);
            this.splitContainer1.Panel1.Controls.Add(this.btnCopy);
            this.splitContainer1.Panel1.Controls.Add(this.btnCleanSeq);
            this.splitContainer1.Panel1.Controls.Add(this.txtSeq);
            this.splitContainer1.Panel1.Controls.Add(this.lblSizeName);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtSize);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtResult);
            this.splitContainer1.Size = new System.Drawing.Size(629, 480);
            this.splitContainer1.SplitterDistance = 403;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Results";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnRunBM;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 480);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Berlekamp-Massey Algorithm - Halil Kemal TAŞKIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSizeName;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtSeq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRunBM;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnCleanSeq;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
    }
}

