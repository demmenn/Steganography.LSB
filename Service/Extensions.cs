using System;
using System.Collections;
using System.Drawing;
using System.Text;

namespace Steganography.Service
{
    public static class Extensions
    {

        public static bool CheckImageExtension(this string fileName)
        {
            return (fileName.EndsWith(".png") || fileName.EndsWith(".jpg") || fileName.EndsWith(".jpeg") || fileName.EndsWith(".bmp"));
        }

        public static string ToBitStr(this BitArray bits)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < bits.Count; i++)
            {
                char c = bits[i] ? '1' : '0';
                sb.Append(c);
            }
            return sb.ToString();
        }

        public static bool GetBit(this byte b, int bitNumber)
        {
            return (b & (1 << bitNumber)) != 0;
        }

        public static string Reverse(this string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static int ToInt32(this BitArray bitArray)
        {
            if (bitArray.Length > 32)
                throw new ArgumentException("Argument length shall be at most 32 bits.");

            int[] array = new int[1];
            bitArray.CopyTo(array, 0);
            return array[0];
        }

        public static String ToUTF8Str(this BitArray bitArray)
        {
            byte[] strArr = new byte[bitArray.Length / 8];
            UTF8Encoding encoding = new UTF8Encoding();
            for (int i = 0; i < bitArray.Length / 8; i++)
            {
                for (int index = i * 8, m = 1; index < i * 8 + 8; index++, m *= 2)
                {
                    strArr[i] += bitArray.Get(index) ? (byte)m : (byte)0;
                }
            }
            return encoding.GetString(strArr);
        }

        public static bool GetBlockXOR(this Bitmap bitmap, int i, int j, int blockWidth, int blockHeight, Channel channel)
        {
            bool result = false;
            int curBlockWidth = i + blockWidth;
            int curBlockHeight = j + blockHeight;

            for (; i < curBlockWidth && i < bitmap.Width; i++)
            {
                j = 0;
                for (; j < curBlockHeight && j < bitmap.Height; j++)
                {
                    Color pixelColor = bitmap.GetPixel(i, j);
                    byte channelByte = channel == Channel.R ? pixelColor.R : channel == Channel.G ? pixelColor.G : pixelColor.B;
                    bool lessBit = channelByte.GetBit(0);
                    result ^= lessBit;
                }
            }
            return result;
        }
    }
}
