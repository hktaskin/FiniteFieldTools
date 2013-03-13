using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
Author: Halil Kemal TAŞKIN
Web: http://hkt.me
*/

namespace FiniteFieldArithmetics
{
    public static class ConvTools
    {
        public static byte[] ToByteArray(this uint s)
        {
            byte[] result = new byte[4];

            for (int i = 0; i < 4; i++)
			result[i] = (byte)((s>>(i*8)) & 0x000000FF);

            return result;
        }

        public static uint ToUInt32(this byte[] s)
        {
            uint result = 0x00000000;

            for (int i = 0; i < s.Length; i++)
            {
                if (i == 4)
                    break;

                result ^= (uint)(s[i] << (i * 8));                
            }

            return result;
        }

        public static byte[] ToByteArray(this string s)
        {
            string[] str = s.Split('-',':');
            byte[] byt = new byte[str.Length];

            for (int i = 0; i < str.Length; i++)
                byt[i] = Convert.ToByte(str[i], 16);

            return byt; 
        }

        public static string ToStringValue(this byte[] byt)
        {
            string[] str = new string[byt.Length];

            for (int i = 0; i < byt.Length; i++)
                str[i] = byt[i].ToString("X2");

            return String.Join("-", str);
        }

        /// <summary>
        /// Takes 160-bit (20 bytes) SHA-1 Hash Result, divides it into 32-bit (4 bytes) chunks and XOR chunks to get 32-bit result.
        /// </summary>
        /// <param name="s">SHA-1 Hash Result as byte[]</param>
        /// <returns>32-bit unsigned integer uint ot UInt32</returns>
        public static uint ReduceSHA1to32bit(this byte[] s)
        {
            uint result = 0x00000000;

            for (int i = 0; i < s.Length; i++)
            {
                if (i == 4)
                    break;

                result ^= (uint)((s[i] ^ s[i + 4] ^ s[i + 8] ^ s[i + 12] ^ s[i + 16]) << (i * 8));
            }

            return result;
        }
    }
}
