using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;

namespace Steganography.Service
{

    public enum Method
    {
        Simple = 0,
        BitsSkipping,
        RandBitsSkipping,
        BlockOneChannel,
        BlockThreeChannel
    }

    public enum Channel
    {
        R = 2,
        G = 3,
        B = 1
    }

    public static class Utils
    {

        public const int INT_SIZE_IN_BIT = sizeof(int) * 8; 

        public static int GetMessageSizeInBit(string message)
        {
            BitArray bitArr = new BitArray(Encoding.UTF8.GetBytes(message));
            return bitArr.Length;
        }

        public static string GetAppFolder()
        {
            return new FileInfo(Assembly.GetExecutingAssembly().Location).Directory.FullName;
        }

        // Для всех методов, кроме блочного.
        public static bool CheckSize(int size, Bitmap bm, int number)
        {
            if (number == -1)
            {
                number = 1;
            }
            int bmSize = bm.Width * bm.Height;
            size = (INT_SIZE_IN_BIT + size) * number;
            return size <= bmSize;
        }

        // Для блочного метода.
        public static bool CheckSize(int size, Bitmap bm, int width, int height)
        {
            int bmSize = bm.Width * bm.Height;
            int blockSize = width * height;
            size = INT_SIZE_IN_BIT + size;
            return size <= (bmSize / blockSize);
        }

        public static BitArray CreateResultBitArray(string message, int msgSize)
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

        public static string GetResultBitArray(Bitmap bm)
        {
            string result = null;


            return result;
        }

    }
}
