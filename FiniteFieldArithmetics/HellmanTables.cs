using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

/*
Author: Halil Kemal TAŞKIN
Web: http://hkt.me
*/

namespace FiniteFieldArithmetics
{
    /* 
     * Constructing Hellman Tables
     * m*t^2 = N = 2^32 so taking m=2^10 and t=2^11 seems a good choice
     * So we will have at most t (m x (t+1)) size matrices.
     * 
     */

    public class HellmanTables
    {
        #region Constructor

        public HellmanTables(uint mm, uint tt, uint nnumberOfTables)
        {
            this._m = mm;
            this._t = tt;
            this._numberOfTables = nnumberOfTables;
            Tables = new uint[_numberOfTables, _m, 2];
        }

        #endregion

        #region Fields

        public delegate void TableProcessedEventHandler(uint TableNo);
        
        public event TableProcessedEventHandler TableProcessed;

        private uint _m;
        
        private uint _t;
        
        private uint _numberOfTables;
        
        private uint[, ,] Tables;

        #endregion

        #region Properties

        public uint m { get { return _m; } }

        public uint t { get { return _t; } }

        public uint numberOfTables { get { return _numberOfTables; } }

        #endregion

        #region Methods

        /// <summary>
        /// Generates the whole Table and fills values to the field (uint[,,])Tables.
        /// This part is also known as Precomputation part.
        /// </summary>
        public bool GenerateTables()
        {
            // For every table
            for (uint tValue = 0; tValue < _numberOfTables; tValue++)
            {
                // for every row
                for (uint mValue = 0; mValue < _m; mValue++)
                {
                    uint rowValue = (_m * tValue) + mValue;

                    // construct starting point and ending point
                    // starting point is mValue

                    // compute ending point
                    uint endPoint = rowValue;
                    for (int i = 0; i < _t; i++)
                        endPoint = CryptoTools.OneWayFunction32Bit(endPoint);

                    // fill the byte array
                    Tables[tValue, mValue, 0] = rowValue;
                    Tables[tValue, mValue, 1] = endPoint;
                }

                if (TableProcessed != null)
                {
                    TableProcessed(tValue + 1);
                }

            }

            return true;
        }

        /// <summary>
        /// Returns the value of a point in the Table
        /// </summary>
        /// <param name="TableNo">Table number</param>
        /// <param name="Row">Row Number</param>
        /// <param name="Column">Column Number: 0->StartingPoint 1->EndPoint</param>
        /// <returns>uint or UInt32</returns>
        public uint TableData(uint TableNo, uint Row, uint Column)
        {
            return Tables[TableNo, Row, Column];
        }

        public void SaveTablesToFile(string filename)
        {
            Stream stream = File.Open(filename, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, this.Tables);
            stream.Close();
        }

        public void ReadTablesFromFile(string filename)
        {
            Stream stream = File.Open(filename, FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            Tables = (uint[, ,])bFormatter.Deserialize(stream);
            stream.Close();
        }

        public uint? FindPreimageValue(uint hashValue)
        {
            // her tablo için
            for (uint i = 0; i < _numberOfTables; i++)
            {
                // her bir satırda ending point e bak
                for (int j = 0; j < _m; j++)
                {
                    uint aradigimizsayi = Tables[i, j, 0];
                    uint aradigimizsayininhashi = Tables[i, j, 1];
                    // hash al bak
                    for (int k = 0; k < _t; k++)
                    {
                        aradigimizsayininhashi = CryptoTools.OneWayFunction32Bit(aradigimizsayi);
                        if (aradigimizsayininhashi == hashValue)
                            return aradigimizsayi;

                        aradigimizsayi = aradigimizsayininhashi;
                    }
                }
            }

            return null;
        }

        #endregion

    }
}
