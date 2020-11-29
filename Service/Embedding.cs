using System;
using System.Collections;
using System.Drawing;
using System.Text;

namespace Steganography.Service
{

    public enum Channel
    {
        R = 0,
        G,
        B
    }

    public static class Embedding
    {

        public static Image EmbedMessageInImage(string message, Image container, Channel channel, Int32 number)
        {
            Image result = null;
            if (!String.IsNullOrEmpty(message))
            {
                Bitmap temp = new Bitmap(container);
                Int32 messageSizeInBit = Utils.GetMessageSizeInBit(message);
                if (Utils.CheckSize(messageSizeInBit, temp, number))
                {
                    WriteMessage(temp, message, messageSizeInBit, channel, number);
                    result = temp;
                }
            }
            return result;
        }

        private static void WriteMessage(Bitmap bm, string message, Int32 msgSize, Channel channel, Int32 number)
        {
            int bitIndex = 0;
            BitArray msg = Utils.CreateResultBitArray(message, msgSize);
            if (number == 0)
                number += 1;
            int j_numb = 0;
            for (int i = 0; i < bm.Width; i++)
            {
                int j = j_numb;
                for (; j < bm.Height; j += number)
                {
                    if (bitIndex < msg.Length)
                    {
                        Color pixelColor = bm.GetPixel(i, j);
                        byte channelByte = channel == Channel.R ? pixelColor.R : channel == Channel.G ? pixelColor.G : pixelColor.B;
                        bool lessBit = channelByte.GetBit(0);
                        if (msg[bitIndex] != lessBit)
                        {
                            byte newChannelByte = lessBit ? (byte)(channelByte - 1) : (byte)(channelByte + 1);
                            Color newPixelColor;
                            if (channel == Channel.R)
                                newPixelColor = Color.FromArgb(newChannelByte, pixelColor.G, pixelColor.B);
                            else if (channel == Channel.G)
                                newPixelColor = Color.FromArgb(pixelColor.R, newChannelByte, pixelColor.B);
                            else
                                newPixelColor = Color.FromArgb(pixelColor.R, pixelColor.G, newChannelByte);
                            bm.SetPixel(i, j, newPixelColor);
                        }
                        bitIndex++;
                    }
                    else
                    {
                        return;
                    }

                    if ((j + number) >= bm.Height)
                    {
                        j_numb = (j + number) - bm.Height;
                        break;
                    }
                }
            }
        }

    }
}
