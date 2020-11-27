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
                    WriteSizeOfMessage(temp, messageSizeInBit);
                    WriteMessage(temp, message);
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

        private static void WriteMessage(Bitmap bm, string message)
        {
            BitArray bitArr = new BitArray(Encoding.UTF8.GetBytes(message));
            string bytes = bitArr.ToBitStr();
            int bitIndex = 0;
            for (int i = 0; i < bm.Width; i++)
            {
                for (int j = 32; j < bm.Height; j++)
                {
                    if (bitIndex < bitArr.Length)
                    {
                        Color pixelColor = bm.GetPixel(i, j);
                        byte R = pixelColor.R;
                        bool lessBit = R.GetBit(0);
                        if (Convert.ToBoolean(Convert.ToInt32(bytes[bitIndex].ToString())) != lessBit)
                        {
                            byte newR;
                            if (lessBit)
                            {
                                newR = (byte)(R - 1);
                            }
                            else
                            {
                                newR = (byte)(R + 1);
                            }
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
