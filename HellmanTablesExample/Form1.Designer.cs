namespace HellmanTablesExample
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
            this.components = new System.ComponentModel.Container();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnHash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbHash = new System.Windows.Forms.GroupBox();
            this.btnRndBytes = new System.Windows.Forms.Button();
            this.btnUP = new System.Windows.Forms.Button();
            this.btnStartPrecomputation = new System.Windows.Forms.Button();
            this.grbPrecompute = new System.Windows.Forms.GroupBox();
            this.txtT = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtNumberOfTables = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbNewTables = new System.Windows.Forms.RadioButton();
            this.rdbFromFile = new System.Windows.Forms.RadioButton();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbLog = new System.Windows.Forms.GroupBox();
            this.grbHashFind = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFalseAlarmProb = new System.Windows.Forms.Button();
            this.txtHashInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPreimageResult = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFindPreImage = new System.Windows.Forms.Button();
            this.grbHash.SuspendLayout();
            this.grbPrecompute.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.grbLog.SuspendLayout();
            this.grbHashFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInput.Location = new System.Drawing.Point(62, 17);
            this.txtInput.MaxLength = 11;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(116, 22);
            this.txtInput.TabIndex = 1;
            this.txtInput.Text = "00-00-00-00";
            // 
            // txtOutput
            // 
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOutput.Location = new System.Drawing.Point(62, 43);
            this.txtOutput.MaxLength = 11;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(160, 22);
            this.txtOutput.TabIndex = 5;
            // 
            // btnHash
            // 
            this.btnHash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHash.Location = new System.Drawing.Point(228, 17);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(48, 22);
            this.btnHash.TabIndex = 3;
            this.btnHash.Text = "Hash";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output";
            // 
            // grbHash
            // 
            this.grbHash.Controls.Add(this.btnRndBytes);
            this.grbHash.Controls.Add(this.txtInput);
            this.grbHash.Controls.Add(this.label2);
            this.grbHash.Controls.Add(this.txtOutput);
            this.grbHash.Controls.Add(this.label1);
            this.grbHash.Controls.Add(this.btnUP);
            this.grbHash.Controls.Add(this.btnHash);
            this.grbHash.Location = new System.Drawing.Point(12, 12);
            this.grbHash.Name = "grbHash";
            this.grbHash.Size = new System.Drawing.Size(282, 83);
            this.grbHash.TabIndex = 0;
            this.grbHash.TabStop = false;
            this.grbHash.Text = "Hash Calculation";
            // 
            // btnRndBytes
            // 
            this.btnRndBytes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRndBytes.Location = new System.Drawing.Point(184, 17);
            this.btnRndBytes.Name = "btnRndBytes";
            this.btnRndBytes.Size = new System.Drawing.Size(38, 22);
            this.btnRndBytes.TabIndex = 2;
            this.btnRndBytes.Text = "Rnd";
            this.btnRndBytes.UseVisualStyleBackColor = true;
            this.btnRndBytes.Click += new System.EventHandler(this.btnRndBytes_Click);
            // 
            // btnUP
            // 
            this.btnUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUP.Location = new System.Drawing.Point(228, 43);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(48, 22);
            this.btnUP.TabIndex = 6;
            this.btnUP.Text = "UP";
            this.btnUP.UseVisualStyleBackColor = true;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnStartPrecomputation
            // 
            this.btnStartPrecomputation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartPrecomputation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStartPrecomputation.Location = new System.Drawing.Point(6, 67);
            this.btnStartPrecomputation.Name = "btnStartPrecomputation";
            this.btnStartPrecomputation.Size = new System.Drawing.Size(270, 34);
            this.btnStartPrecomputation.TabIndex = 6;
            this.btnStartPrecomputation.Text = "Start Precomputation Part";
            this.btnStartPrecomputation.UseVisualStyleBackColor = true;
            this.btnStartPrecomputation.Click += new System.EventHandler(this.btnStartPrecomputation_Click);
            // 
            // grbPrecompute
            // 
            this.grbPrecompute.Controls.Add(this.txtT);
            this.grbPrecompute.Controls.Add(this.txtM);
            this.grbPrecompute.Controls.Add(this.txtNumberOfTables);
            this.grbPrecompute.Controls.Add(this.label5);
            this.grbPrecompute.Controls.Add(this.label4);
            this.grbPrecompute.Controls.Add(this.label3);
            this.grbPrecompute.Controls.Add(this.btnStartPrecomputation);
            this.grbPrecompute.Location = new System.Drawing.Point(12, 131);
            this.grbPrecompute.Name = "grbPrecompute";
            this.grbPrecompute.Size = new System.Drawing.Size(282, 117);
            this.grbPrecompute.TabIndex = 2;
            this.grbPrecompute.TabStop = false;
            this.grbPrecompute.Text = "Precomputation (Table Generation)";
            // 
            // txtT
            // 
            this.txtT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtT.Location = new System.Drawing.Point(176, 15);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(100, 22);
            this.txtT.TabIndex = 3;
            this.txtT.Text = "2048";
            // 
            // txtM
            // 
            this.txtM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtM.Location = new System.Drawing.Point(41, 15);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(100, 22);
            this.txtM.TabIndex = 1;
            this.txtM.Text = "1024";
            // 
            // txtNumberOfTables
            // 
            this.txtNumberOfTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNumberOfTables.Location = new System.Drawing.Point(138, 41);
            this.txtNumberOfTables.Name = "txtNumberOfTables";
            this.txtNumberOfTables.Size = new System.Drawing.Size(138, 22);
            this.txtNumberOfTables.TabIndex = 5;
            this.txtNumberOfTables.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of Tables =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(149, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "t =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "m =";
            // 
            // rdbNewTables
            // 
            this.rdbNewTables.AutoSize = true;
            this.rdbNewTables.Checked = true;
            this.rdbNewTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbNewTables.Location = new System.Drawing.Point(12, 101);
            this.rdbNewTables.Name = "rdbNewTables";
            this.rdbNewTables.Size = new System.Drawing.Size(198, 24);
            this.rdbNewTables.TabIndex = 1;
            this.rdbNewTables.TabStop = true;
            this.rdbNewTables.Text = "Generate new Tables";
            this.rdbNewTables.UseVisualStyleBackColor = true;
            this.rdbNewTables.CheckedChanged += new System.EventHandler(this.rdbNewTables_CheckedChanged);
            // 
            // rdbFromFile
            // 
            this.rdbFromFile.AutoSize = true;
            this.rdbFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbFromFile.Location = new System.Drawing.Point(12, 258);
            this.rdbFromFile.Name = "rdbFromFile";
            this.rdbFromFile.Size = new System.Drawing.Size(200, 24);
            this.rdbFromFile.TabIndex = 3;
            this.rdbFromFile.Text = "Load Tables from File";
            this.rdbFromFile.UseVisualStyleBackColor = true;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBrowseFile.Location = new System.Drawing.Point(213, 254);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(81, 34);
            this.btnBrowseFile.TabIndex = 4;
            this.btnBrowseFile.Text = "Browse";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // txtLog
            // 
            this.txtLog.ContextMenuStrip = this.contextMenuStrip1;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 16);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(513, 257);
            this.txtLog.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 26);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // grbLog
            // 
            this.grbLog.Controls.Add(this.txtLog);
            this.grbLog.Location = new System.Drawing.Point(300, 12);
            this.grbLog.Name = "grbLog";
            this.grbLog.Size = new System.Drawing.Size(519, 276);
            this.grbLog.TabIndex = 6;
            this.grbLog.TabStop = false;
            this.grbLog.Text = "Log";
            // 
            // grbHashFind
            // 
            this.grbHashFind.Controls.Add(this.label8);
            this.grbHashFind.Controls.Add(this.btnFalseAlarmProb);
            this.grbHashFind.Controls.Add(this.txtHashInput);
            this.grbHashFind.Controls.Add(this.label6);
            this.grbHashFind.Controls.Add(this.txtPreimageResult);
            this.grbHashFind.Controls.Add(this.label7);
            this.grbHashFind.Controls.Add(this.btnFindPreImage);
            this.grbHashFind.Location = new System.Drawing.Point(12, 294);
            this.grbHashFind.Name = "grbHashFind";
            this.grbHashFind.Size = new System.Drawing.Size(804, 126);
            this.grbHashFind.TabIndex = 5;
            this.grbHashFind.TabStop = false;
            this.grbHashFind.Text = "Hash Finder";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(495, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(303, 44);
            this.label8.TabIndex = 5;
            this.label8.Text = "Halil Kemal TAŞKIN\r\nIAM 705 HW #7";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFalseAlarmProb
            // 
            this.btnFalseAlarmProb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFalseAlarmProb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFalseAlarmProb.Location = new System.Drawing.Point(495, 58);
            this.btnFalseAlarmProb.Name = "btnFalseAlarmProb";
            this.btnFalseAlarmProb.Size = new System.Drawing.Size(303, 45);
            this.btnFalseAlarmProb.TabIndex = 6;
            this.btnFalseAlarmProb.Text = "False Alarm Probability";
            this.btnFalseAlarmProb.UseVisualStyleBackColor = true;
            this.btnFalseAlarmProb.Click += new System.EventHandler(this.btnFalseAlarmProb_Click);
            // 
            // txtHashInput
            // 
            this.txtHashInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHashInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHashInput.Location = new System.Drawing.Point(93, 24);
            this.txtHashInput.MaxLength = 11;
            this.txtHashInput.Name = "txtHashInput";
            this.txtHashInput.Size = new System.Drawing.Size(116, 22);
            this.txtHashInput.TabIndex = 1;
            this.txtHashInput.Text = "00-00-00-00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(233, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Output";
            // 
            // txtPreimageResult
            // 
            this.txtPreimageResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreimageResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPreimageResult.Location = new System.Drawing.Point(236, 43);
            this.txtPreimageResult.MaxLength = 11;
            this.txtPreimageResult.Multiline = true;
            this.txtPreimageResult.Name = "txtPreimageResult";
            this.txtPreimageResult.Size = new System.Drawing.Size(253, 60);
            this.txtPreimageResult.TabIndex = 4;
            this.txtPreimageResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(9, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hash Value";
            // 
            // btnFindPreImage
            // 
            this.btnFindPreImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindPreImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFindPreImage.Location = new System.Drawing.Point(12, 50);
            this.btnFindPreImage.Name = "btnFindPreImage";
            this.btnFindPreImage.Size = new System.Drawing.Size(197, 53);
            this.btnFindPreImage.TabIndex = 2;
            this.btnFindPreImage.Text = "Apply First Preimage Attack Using Hellman Tables";
            this.btnFindPreImage.UseVisualStyleBackColor = true;
            this.btnFindPreImage.Click += new System.EventHandler(this.btnFindPreImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 431);
            this.Controls.Add(this.grbHashFind);
            this.Controls.Add(this.grbLog);
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.rdbFromFile);
            this.Controls.Add(this.rdbNewTables);
            this.Controls.Add(this.grbPrecompute);
            this.Controls.Add(this.grbHash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hellman Tables Example - Halil Kemal TAŞKIN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbHash.ResumeLayout(false);
            this.grbHash.PerformLayout();
            this.grbPrecompute.ResumeLayout(false);
            this.grbPrecompute.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.grbLog.ResumeLayout(false);
            this.grbLog.PerformLayout();
            this.grbHashFind.ResumeLayout(false);
            this.grbHashFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbHash;
        private System.Windows.Forms.Button btnStartPrecomputation;
        private System.Windows.Forms.Button btnRndBytes;
        private System.Windows.Forms.GroupBox grbPrecompute;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtNumberOfTables;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbNewTables;
        private System.Windows.Forms.RadioButton rdbFromFile;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.GroupBox grbLog;
        private System.Windows.Forms.GroupBox grbHashFind;
        private System.Windows.Forms.TextBox txtHashInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPreimageResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFindPreImage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnFalseAlarmProb;
    }
}

