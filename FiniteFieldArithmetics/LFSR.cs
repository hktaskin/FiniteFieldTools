using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading;

/*
Author: Halil Kemal TAŞKIN
Web: http://hkt.me
*/

namespace FiniteFieldArithmetics
{
    public class LFSR
    {
        #region Constructor

        public LFSR(Polynomial feedbackPolynomial, FiniteFieldElement[] initialState)
        {
            if (feedbackPolynomial.Field.Characteristic != initialState[0].Field.Characteristic)
                throw new Exception("Both values should be defined in the same field.");
            if ((initialState.Length - 1) < feedbackPolynomial.Degree)
                throw new ArgumentOutOfRangeException("Initial state size must be greater then feedback polynomial degree.");

            this.currentState = initialState;
            this._feedbackPolynomial = feedbackPolynomial;
            periodOncedenHesaplandiysa = false;
        }

        #endregion

        #region Fields

        /// <summary>
        /// If set, behaves as initial state. i.e. after setting currentState, .Clock() uses the new value.
        /// </summary>
        public FiniteFieldElement[] currentState { get; set; }

        private Polynomial _feedbackPolynomial;

        private FiniteFieldElement _streamOutput;

        private int _period;

        bool periodOncedenHesaplandiysa;

        #endregion

        #region Properties

        public FiniteFieldElement StreamOutput
        {
            get
            {
                return _streamOutput;
            }

        }

        public Polynomial FeedbackPolynomial
        {
            get
            {
                return _feedbackPolynomial;
            }
        }

        public int Period
        {
            get
            {
                if (!periodOncedenHesaplandiysa)
                {
                    _period = 1;
                    FiniteFieldElement[] startState = new FiniteFieldElement[this.currentState.Length];
                    currentState.CopyTo(startState, 0);

                    this.Clock();

                    while (!IsEqualStates(startState, this.currentState))
                    {
                        _period++;
                        this.Clock();

                        // DEBUG
                        //for (int i = 0; i < this.currentState.Length; i++)
                        //    Debug.Write(this.currentState[i].Value.ToString());                            
                        //Debug.WriteLine(": " + _period);
                    }

                    periodOncedenHesaplandiysa = true;
                    startState.CopyTo(currentState, 0);
                }

                return _period;
            }
        }

        #endregion

        #region Methods

        public void Clock()
        {
            FiniteFieldElement r = new FiniteFieldElement();
            r.Field = _feedbackPolynomial.Field;
            r.Value = 0;
            // Evaluate the current state on feedback polynomial
            for (int i = 0; i < currentState.Length; i++)
                r += _feedbackPolynomial.Coefficients[i] * currentState[i];
            // Shift the currentState right.
            _streamOutput = currentState[0];
            Array.Copy(currentState, 1, currentState, 0, currentState.Length - 1);
            currentState[currentState.Length - 1] = r;
        }

        public void Clock(int n)
        {
            for (int i = 0; i < n; i++)
                this.Clock();
        }

        private bool IsEqualStates(FiniteFieldElement[] s1, FiniteFieldElement[] s2)
        {
            bool kontrol = true;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i].Value != s2[i].Value)
                {
                    kontrol = false;
                    break;
                }
            }

            return kontrol;
        }

        #endregion

    }

    public class ExtensionLFSR
    {
        #region Constructor

        public ExtensionLFSR(ExtensionPolynomial feedbackPolynomial, ExtensionFieldElement[] initialState)
        {
            if (feedbackPolynomial.Field.Characteristic != initialState[0].Field.Characteristic)
                throw new Exception("Both values should be defined in the same field.");
            if ((initialState.Length - 1) < feedbackPolynomial.Degree)
                throw new ArgumentOutOfRangeException("Initial state size must be greater then feedback polynomial degree.");

            this.currentState = initialState;
            this._feedbackPolynomial = feedbackPolynomial;
        }

        #endregion

        #region Fields

        /// <summary>
        /// If set, behaves as initial state. i.e. after setting currentState, .Clock() uses the new value.
        /// </summary>
        public ExtensionFieldElement[] currentState { get; set; }

        private ExtensionPolynomial _feedbackPolynomial;

        private ExtensionFieldElement _streamOutput;

        #endregion

        #region Properties

        public ExtensionFieldElement StreamOutput
        {
            get
            {
                return _streamOutput;
            }
        }

        public ExtensionPolynomial FeedbackPolynomial
        {
            get
            {
                return _feedbackPolynomial;
            }
        }

        public int Period { get { return 0; } }

        #endregion

        #region Methods

        public void Clock()
        {
            ExtensionFieldElement r = ExtensionFieldElement.Zero(_feedbackPolynomial.Field);
            // Evaluate the current state on feedback polynomial
            for (int i = 0; i < currentState.Length; i++)
                r += _feedbackPolynomial.Coefficients[i] * currentState[i];
            // Shift the currentState right.
            _streamOutput = currentState[0];
            Array.Copy(currentState, 1, currentState, 0, currentState.Length - 1);
            currentState[currentState.Length - 1] = r;
        }

        public void Clock(int n)
        {
            for (int i = 0; i < n; i++)
                this.Clock();
        }

        #endregion

    }

    public class LFSRTools
    {
        #region Static Methods

        /// <param name="s">Output sequence as polynomial</param>
        /// <returns>Returns the Linear Complexity of given sequence</returns>
        public static int BerlekampMassey(Polynomial s)
        {
            Polynomial C = new Polynomial(s.Field, 1);
            Polynomial B = new Polynomial(s.Field, 1);
            int N = s.Degree + 1;
            int L = 0;
            int m = 1;
            FiniteFieldElement b = s.Field.Elements[1];
            int n;

            for (n = 0; n < N; n++)
            {
                // calculate discrepency
                FiniteFieldElement d = new FiniteFieldElement();
                d = s.Coefficients[n];
                for (int i = 1; i <= L; i++)
                {
                    try
                    {
                        d += C.Coefficients[i] * s.Coefficients[n - i];
                    }
                    catch { }

                }
                if (d.Value == 0)
                {
                    m++;
                }
                else if (2 * L <= n)
                {
                    Polynomial T = new Polynomial();

                    T = C;

                    Polynomial c1 = Polynomial.GenerateFromTerm(s.Field, d * b.Inverse, m);

                    C = C - (c1 * B);

                    L = n + 1 - L;

                    B = T;

                    b = d;

                    m = 1;

                }
                else
                {
                    Polynomial c1 = Polynomial.GenerateFromTerm(s.Field, d * b.Inverse, m);
                    C = C - (c1 * B);
                    m++;
                }


            }

            return L;

        }

        /// <param name="s">Output sequence as polynomial</param>
        /// <param name="C">Fills the given polynomial with LFSR Connection Polynomial</param>
        /// <returns>Returns the Linear Complexity of given sequence</returns>
        public static int BerlekampMassey(Polynomial s, out Polynomial Conn)
        {
            Polynomial C = new Polynomial(s.Field, 1);
            Polynomial B = new Polynomial(s.Field, 1);
            int N = s.Degree + 1;
            int L = 0;
            int m = 1;
            FiniteFieldElement b = s.Field.Elements[1];
            int n;

            for (n = 0; n < N; n++)
            {
                // calculate discrepency
                FiniteFieldElement d = new FiniteFieldElement();
                d = s.Coefficients[n];
                for (int i = 1; i <= L; i++)
                {
                    try
                    {
                        d += C.Coefficients[i] * s.Coefficients[n - i];
                    }
                    catch { }

                }


                if (d.Value == 0)
                {
                    m++;
                }
                else if (2 * L <= n)
                {
                    Polynomial T = new Polynomial();

                    T = C;

                    Polynomial c1 = Polynomial.GenerateFromTerm(s.Field, d * b.Inverse, m);

                    C = C - (c1 * B);

                    L = n + 1 - L;

                    B = T;

                    b = d;

                    m = 1;

                }
                else
                {
                    Polynomial c1 = Polynomial.GenerateFromTerm(s.Field, d * b.Inverse, m);
                    C = C - (c1 * B);
                    m++;
                }


            }

            Conn = C;
            return L;

        }

        public static int NumberOfRuns(string BinaryString)
        {
            string str = BinaryString;

            int strlen = str.Length, numberOfRuns = 1;
            char ilk = str[0];
            for (int i = 1; i < strlen; i++)
            {
                if (str[i] == ilk)
                {
                    continue;
                }
                else
                {
                    ilk = str[i];
                    numberOfRuns++;
                }
            }

            return numberOfRuns;
        }

        public static int NumberOfRuns(string BinaryString, out BindingList<Runs> runsList)
        {
            runsList = new BindingList<Runs>();
            List<int> runLens = new List<int>();

            string str = BinaryString;

            int strlen = str.Length, numberOfRuns = 1, internalSayac = 1;
            char ilk = str[0];
            for (int i = 1; i < strlen; i++)
            {
                if (str[i] == ilk)
                {
                    internalSayac++;
                    continue;
                }
                else
                {
                    //Debug.WriteLine(internalSayac);
                    runLens.Add(internalSayac);
                    internalSayac = 1;
                    ilk = str[i];
                    numberOfRuns++;
                }
            }

            //Debug.WriteLine(internalSayac);
            runLens.Add(internalSayac);

            runLens.Sort();

            foreach (int run in runLens)
            {
                bool yoksa = true;
                foreach (Runs r in runsList)
                {
                    if (r.RunLength == run)
                    {
                        r.Count++;
                        yoksa = false;
                        break;
                    }
                }
                if (yoksa)
                {
                    Runs r = new Runs(run, 1);
                    runsList.Add(r);
                }
            }

            return numberOfRuns;
        }

        public static double AutoCorrelationValue(string BinaryString, int shift)
        {
            double p = BinaryString.Length;

            if (shift > p)
                throw new Exception("Shift count can not be greater then the string length.");

            double toplam = 0;

            for (int i = 0; i < p; i++)
            {
                int value = int.Parse(BinaryString[i].ToString()) + int.Parse(BinaryString[(i + shift) % (int)p].ToString());
                if (value % 2 == 0)
                    toplam += 1;
                else
                    toplam -= 1;
            }

            return toplam / p;
        }

        public static double[] AllAutoCorrelationValues(string BinaryString)
        {
            int p = BinaryString.Length;
            double[] result = new double[p];

            for (int i = 0; i < p; i++)
                result[i] = AutoCorrelationValue(BinaryString, i);

            return result;
        }

        public static double[] AllAutoCorrelationValues(string BinaryString, out int DistinctPoints)
        {
            int p = BinaryString.Length;
            double[] result = new double[p];
            for (int i = 0; i < p; i++)
                result[i] = 2;

            DistinctPoints = 0;

            for (int i = 0; i < p; i++)
            {
                double val = AutoCorrelationValue(BinaryString, i);
                if (!result.Contains(val))
                    DistinctPoints++;
                result[i] = val;
            }
            return result;
        }

        public static int FindStreamPeriod(string stream, int initialSize)
        {
            string init = stream.Substring(0, initialSize);

            int period = stream.IndexOf(init, initialSize + 1);

            return period;
        }

        /// <summary>
        /// Used for ultimately periodic sequences.
        /// </summary>
        public static int FindStreamPeriodExtended(string stream, int initialSize)
        {
            string init = stream.Substring(0, initialSize);

            for (int i = 1; i < stream.Length - initialSize; i++)
            {
                init = stream.Substring(i, initialSize);
                int p = stream.IndexOf(init, i + initialSize);
                if (p != -1)
                    return p - i;
            }

            return -1;
        }

        #endregion

    }

    public class Runs
    {
        #region Constructor

        public Runs(int runLength, int count)
        {
            this.RunLength = runLength;
            this.Count = count;
        }

        #endregion

        #region Properties

        [DisplayName("Run Length")]
        public int RunLength { get; set; }

        [DisplayName("Number of Run")]
        public int Count { get; set; }

        #endregion

    }
}
