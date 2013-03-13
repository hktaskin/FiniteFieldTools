using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

/*
Author: Halil Kemal TAŞKIN
Web: http://hkt.me
*/

namespace FiniteFieldArithmetics
{
    public class CryptoTools
    {
        /// <summary>
        /// Takes 32-bit unsigned integer and gives the LSB 32-bit of SHA1 hash result as UInt32. 
        /// </summary>
        /// <param name="input">32-bit unsigned integer</param>
        /// <returns>LSB 32-bit of SHA1 Hash result.</returns>
        public static uint SHA1_LSB32bit(uint input)
        {
            //SHA1 sha1 = SHA1.Create();
            //SHA1Managed sha1mng = new SHA1Managed();
            SHA1Cng sha1cng = new SHA1Cng();
            
            return sha1cng.ComputeHash(input.ToByteArray()).ToUInt32();
        }

        public static uint OneWayFunction32Bit(uint input)
        {
            //SHA1 sha1 = SHA1.Create();
            //SHA1Managed sha1mng = new SHA1Managed();
            SHA1Cng sha1cng = new SHA1Cng();
            
            return sha1cng.ComputeHash(input.ToByteArray()).ReduceSHA1to32bit();
        }

        public static uint OneWayFunction32Bit(byte[] input)
        {
            //SHA1 sha1 = SHA1.Create();
            //SHA1Managed sha1mng = new SHA1Managed();
            SHA1Cng sha1cng = new SHA1Cng();

            return sha1cng.ComputeHash(input).ReduceSHA1to32bit();
        }

       

    }
}
