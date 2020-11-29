using System;
using System.Collections;
using System.Drawing;
using System.Text;

namespace Steganography.Service
{
    public static class Embedding
    {

        public static Image EmbedMessageInImage(string message, Image container)
        {
            Image result = null;
            if (!String.IsNullOrEmpty(message))
            {
                Bitmap temp = new Bitmap(container);
                Int32 messageSizeInBit = Utils.GetMessageSizeInBit(message);
                if (Utils.CheckSize(messageSizeInBit, temp))
                {
                    WriteMessage(temp, message, messageSizeInBit);
                    result = temp;
                }
            }
            return result;
        }

        private static void WriteSizeOfMessage(Bitmap bm, Int32 size)
        {
            BitArray bitArr = new BitArray(BitConverter.GetBytes(size));
            string bytes = bitArr.ToBitStr().Reverse();
            int bitIndex = 0;
            for (int i = 0; i < bm.Width; i++)
            {
                for (int j = 0; j < bm.Height; j++)
                {
                    if (bitIndex < bytes.Length)
                    {
                        Color pixelColor = bm.GetPixel(i, j);
                        byte R = pixelColor.R;
                        bool lessBit = R.GetBit(0);
                        if (Convert.ToBoolean(Convert.ToInt32(bytes[bitIndex].ToString())) != lessBit)
                        {
                            byte newR = lessBit ? (byte)(R - 1) : (byte)(R + 1);
                            Color newPixelColor = Color.FromArgb(newR, pixelColor.G, pixelColor.B);
                            bm.SetPixel(i, j, newPixelColor);
                        }
                        bitIndex++;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private static void WriteMessage(Bitmap bm, string message, Int32 msgSize)
        {
            int bitIndex = 0;
            BitArray msg = Utils.GetResultBitArray(message, msgSize);
            for (int i = 0; i < bm.Width; i++)
            {
                for (int j = 0; j < bm.Height; j++)
                {
                    if (bitIndex < msg.Length)
                    {
                        Color pixelColor = bm.GetPixel(i, j);
                        byte R = pixelColor.R;
                        bool lessBit = R.GetBit(0);
                        if (msg[bitIndex] != lessBit)
                        {
                            byte newR = lessBit ? (byte)(R - 1) : (byte)(R + 1);
                            Color newPixelColor = Color.FromArgb(newR, pixelColor.G, pixelColor.B);
                            bm.SetPixel(i, j, newPixelColor);
                        }
                        bitIndex++;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

    }
}
