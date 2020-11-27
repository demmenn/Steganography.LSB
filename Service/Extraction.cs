using System;
using System.Collections;
using System.Drawing;

namespace Steganography.Service
{
    public static class Extraction
    {

        public static string ExtractMessage(Image source)
        {
            string result = null;
            if (source != null)
            {
                Bitmap temp = new Bitmap(source);
                Int32 msgSize = Utils.GetMessageSizeFromBitmap(temp);
                result = GetMessage(temp, msgSize);
            }
            return result;
        }

        private static string GetMessage(Bitmap bm, int messageSize)
        {
            string result = null;
            int bitIndex = 0;
            BitArray bitArr = new BitArray(messageSize);
            for (int i = 0; i < bm.Width; i++)
            {
                for (int j = 32; j < bm.Height; j++)
                {
                    if (bitIndex < messageSize)
                    {
                        Color pixelColor = bm.GetPixel(i, j);
                        byte R = pixelColor.R;
                        bool lessBit = R.GetBit(0);
                        bitArr[bitIndex] = lessBit;
                        bitIndex++;
                    }
                    else
                    {
                        result = bitArr.ToUTF8Str();
                        return result;
                    }
                }
            }
            return result;
        }
    }
}
