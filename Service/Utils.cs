using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Steganography.Service
{
    public static class Utils
    {
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

        public static Int32 GetMessageSizeFromBitmap(Bitmap bm)
        {
            Int32 result = 0;
            BitArray bitArr = new BitArray(32);
            int bitIndex = 0;
            for (int i = 0; i < bm.Width; i++)
            {
                for (int j = 0; j < bm.Height; j++)
                {
                    if (bitIndex < bitArr.Length)
                    {
                        Color pixelColor = bm.GetPixel(i, j);
                        byte R = pixelColor.R;
                        bool lessBit = R.GetBit(0);
                        bitArr[bitIndex] = lessBit;
                        bitIndex++;
                    }
                    else
                    {
                        string temp = bitArr.ToBitStr();
                        temp = temp.Reverse();
                        bitArr = new BitArray(temp.Select(c => c == '1').ToArray());
                        result = bitArr.ToInt32();
                        return result;
                    }
                }
            }
            return result;
        }

    }
}
