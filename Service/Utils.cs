using System;
using System.Collections;
using System.Drawing;
using System.Text;

namespace Steganography.Service
{
    public static class Utils
    {

        public const int INT_SIZE_IN_BIT = sizeof(Int32) * 8; 

        public static Int32 GetMessageSizeInBit(string message)
        {
            BitArray bitArr = new BitArray(Encoding.UTF8.GetBytes(message));
            return bitArr.Length;
        }

        public static bool CheckSize(Int32 size, Bitmap bm)
        {
            int bmSize = (sizeof(Int32) * 8) + (bm.Width * bm.Height);
            return size <= bmSize;
        }

        public static BitArray GetResultBitArray(string message, Int32 msgSize)
        {
            int size = GetMessageSizeInBit(message) + INT_SIZE_IN_BIT;
            BitArray result = new BitArray(size);
            BitArray sizeBitArr = new BitArray(BitConverter.GetBytes(msgSize));
            BitArray msgBitArr = new BitArray(Encoding.UTF8.GetBytes(message));
            string resultBitStr = sizeBitArr.ToBitStr() + msgBitArr.ToBitStr();

            for (int i = 0; i < size; i++)
            {
                result[i] = Convert.ToBoolean(Convert.ToInt32(resultBitStr[i].ToString()));
            }

            return result;
        }

    }
}
