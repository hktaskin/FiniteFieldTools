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
using System.IO;

/*
Author: Halil Kemal TAŞKIN
Web: http://hkt.me
*/

namespace HellmanTablesExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        #region Fields

        Random rnd;

        HellmanTables hll;

        #endregion

        #region Form Events

        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
            btnBrowseFile.Enabled = false;
            grbHashFind.Enabled = false;

            /*
            //uint a = 0x0;
            //uint hash = CryptoTools.SHA1_LSB32bit(a);

            List<uint> hashList = new List<uint>();

            for (uint i = 0; i <= uint.MaxValue; i++)
            {
                if (i % 10000 == 0)
                    Debug.WriteLine(i);

                uint hash = CryptoTools.SHA1_LSB32bit(i);

                if (hashList.Contains(hash))
                {
                    uint coll = (uint)hashList.IndexOf(hash);
                    Debug.WriteLine("\tCollusion at : " + i);
                    Debug.WriteLine("\tFirst Value  : " + coll);
                    Debug.WriteLine("\tHash Check   : " + (hash == CryptoTools.SHA1_LSB32bit(coll)) + " " + hash);
                }
                
                hashList.Add(hash);
            }
            */
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Bütün thread leri sonlandır.
            Environment.Exit(0);
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            /*
            uint t;
            int zaman = Environment.TickCount;

            for (uint i = 5000000; i < 5225000; i++)
                t = CryptoTools.OneWayFunction32Bit(i);

            zaman = Environment.TickCount - zaman;

            MessageBox.Show(zaman.ToString());
            */


            try
            {
                string hash = CryptoTools.OneWayFunction32Bit(txtInput.Text.ToByteArray()).ToByteArray().ToStringValue();
                txtOutput.Text = hash;
                txtHashInput.Text = hash;
            }
            catch (Exception exp)
            {
                MessageBox.Show("MESSAGE: " + exp.Message + "\r\nSTACK TRACE: " + exp.StackTrace, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnStartPrecomputation_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to save the result into a file?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            ThreadDataContainer tdc = new ThreadDataContainer();

            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                fbd.Description = "Please select a folder to save the generated Hellman Table";
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                    return;

                tdc.SaveToFile = true;
                tdc.FilePath = fbd.SelectedPath;
                UpdateLogWithDate("Selected Folder: " + fbd.SelectedPath);
            }
            else
            {
                tdc.SaveToFile = false;
                tdc.FilePath = "";
            }

            tdc.m = uint.Parse(txtM.Text.Trim());
            tdc.t = uint.Parse(txtT.Text.Trim());
            tdc.numberOfTables = uint.Parse(txtNumberOfTables.Text.Trim());
            UpdateLogWithDate("Starting a new thread.");
            Thread Th1 = new Thread(new ParameterizedThreadStart(ThreadedPrecomputation));
            Th1.Start(tdc);
            UpdateLogWithDate("New thread started with Thread ID " + Th1.ManagedThreadId.ToString());
        }

        private void btnRndBytes_Click(object sender, EventArgs e)
        {
            byte[] byt = new byte[4];
            rnd.NextBytes(byt);
            txtInput.Text = byt.ToStringValue();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "BIN Files|*.bin|All Files|*.*";
            ofd.InitialDirectory = Application.StartupPath;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;

            UpdateLogWithDate("Starting to parse file name to find parameters.");
            string dosya = Path.GetFileName(ofd.FileName);
            string[] mtn = dosya.Split('_', '.')[1].Split('-');

            uint m = uint.Parse(mtn[0].Trim());
            uint t = uint.Parse(mtn[1].Trim());
            uint numberOfTables = uint.Parse(mtn[2].Trim());
            DialogResult dr = MessageBox.Show("Recognized values are:\r\nm = " + m + "\r\nt = " + t + "\r\nNumber of Tables = " + numberOfTables + "\r\nConfirm?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No)
                return;
            UpdateLogWithDate("Generating Hellman Tables.");
            hll = new HellmanTables(m, t, numberOfTables);
            hll.ReadTablesFromFile(ofd.FileName);
            UpdateLogWithDate("Hellman Tables has been read from the file.");
            UpdateLogWithDate("Now you can use 'Hash Finder' section.");
            grbHashFind.Enabled = true;
        }

        private void rdbNewTables_CheckedChanged(object sender, EventArgs e)
        {
            grbPrecompute.Enabled = rdbNewTables.Checked;
            btnBrowseFile.Enabled = !rdbNewTables.Checked;
        }

        private void btnFindPreImage_Click(object sender, EventArgs e)
        {
            Thread Th2 = new Thread(new ThreadStart(ThreadedPreimage));
            Th2.Start();
            UpdateLogWithDate("New thread started with Thread ID " + Th2.ManagedThreadId.ToString());
        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.Length > 0)
            {
                txtInput.Text = txtOutput.Text;
                txtOutput.Text = "";
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }

        private void btnFalseAlarmProb_Click(object sender, EventArgs e)
        {
            Thread Th3 = new Thread(new ThreadStart(ThreadedFalsePositives));
            Th3.Start();
            UpdateLogWithDate("New thread started with Thread ID " + Th3.ManagedThreadId.ToString());

        }

        #endregion

        #region Methods

        void ThreadedPrecomputation(object o)
        {
            ThreadDataContainer tdc = o as ThreadDataContainer;

            //int zaman = Environment.TickCount;
            hll = new HellmanTables(tdc.m, tdc.t, tdc.numberOfTables);
            hll.TableProcessed += new HellmanTables.TableProcessedEventHandler(hll_TableProcessed);
            UpdateLogWithDate("Starting to generate Hellman Tables.");
            hll.GenerateTables();
            UpdateLogWithDate("Hellman Tables have been generated.");
            //zaman = Environment.TickCount - zaman;
            if (tdc.SaveToFile)
            {
                string yol = Path.Combine(tdc.FilePath, "Tables_" + hll.m + "-" + hll.t + "-" + hll.numberOfTables + ".bin");
                hll.SaveTablesToFile(yol);
                UpdateLogWithDate("Table Data has been written to the file: " + yol);
            }
            //MessageBox.Show(zaman.ToString() + " milisaniyede oldu bu iş...");
            UpdateLogWithDate("Now you can use 'Hash Finder' section.");
            grbHashFind.Enabled = true;
        }

        void hll_TableProcessed(uint TableNo)
        {
            UpdateLogWithDate("Table " + TableNo + " / " + hll.numberOfTables + " has been processed.");
        }

        void ThreadedPreimage()
        {
            UpdateLogWithDate("Starting to find Preimage.");
            txtPreimageResult.Clear();

            uint? sonuc = hll.FindPreimageValue(txtHashInput.Text.ToByteArray().ToUInt32());
            if (sonuc != null)
            {
                txtPreimageResult.Text = ((uint)sonuc).ToByteArray().ToStringValue();
                UpdateLogWithDate("Found the Preimage Value!");
            }
            else
                UpdateLogWithDate("Seems the result is not in the tables!");
        }

        void ThreadedFalsePositives()
        {
            int test = 100;
            int falsePositives = 0;
            UpdateLogWithDate("Starting to find preimages of hashes of " + test + " known random inputs.");
            for (int i = 0; i < test; i++)
            {
                byte[] byt = new byte[4];
                rnd.NextBytes(byt);
                byt[1] = 0; byt[2] = 0; byt[3] = 0;
                int tk = rnd.Next(test); tk++;
                uint deger = byt.ToUInt32();
                uint sondeger = 0;
                for (int j = 0; j < tk; j++)
                {
                    if (j == tk - 1)
                        sondeger = deger;
                    deger = CryptoTools.OneWayFunction32Bit(deger);

                }
                // yukarıdaki for'un yaptığı iş: hash(sondeger) = deger

                uint? kntrl = hll.FindPreimageValue(deger);
                if (kntrl != null)
                {
                    uint kontrol = (uint)kntrl;
                    UpdateLogWithDate((i + 1) + "/100: Plaintext:" + sondeger.ToByteArray().ToStringValue() + " Hash: " + deger.ToByteArray().ToStringValue() + " Preimage of hash: " + kontrol.ToByteArray().ToStringValue());
                    // eğer bulunan preimage gerçek değerin hash'ine eşitse
                    if (kontrol != sondeger)
                        falsePositives++;
                }
            }

            UpdateLogWithDate("Number of false positives: " + falsePositives + " over " + test + " tries.");
        }

        void UpdateLogWithDate(string s)
        {
            txtLog.AppendText(DateTime.Now.ToString() + ": " + s + Environment.NewLine);
        }

        #endregion

    }

    class ThreadDataContainer
    {
        public uint m { get; set; }
        public uint t { get; set; }
        public uint numberOfTables { get; set; }
        public string FilePath { get; set; }
        public bool SaveToFile { get; set; }
    }
}
