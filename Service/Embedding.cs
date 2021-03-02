using System;
using System.Collections;
using System.Drawing;
using System.Text;

namespace Steganography.Service
{

    public static class Embedding
    {

        public static Image EmbedMessageInImage(string message, Image container, Channel channel, int number = -1)
        {
            Image result = null;
            if (!String.IsNullOrEmpty(message))
            {
                Bitmap temp = new Bitmap(container);
                int messageSizeInBit = Utils.GetMessageSizeInBit(message);
                if (Utils.CheckSize(messageSizeInBit, temp, number))
                {
                    WriteMessage(temp, message, messageSizeInBit, channel, number);
                    result = temp;
                }
            }
            return result;
        }

        public static Image EmbedMessageInImage(string message, Image container, int beginNumber, int endNumber)
        {
            Image result = null;
            if (!String.IsNullOrEmpty(message))
            {
                Bitmap temp = new Bitmap(container);
                int messageSizeInBit = Utils.GetMessageSizeInBit(message);
                if (Utils.CheckSize(messageSizeInBit, temp, (endNumber - beginNumber) / 2))
                {
                    WriteMessage(temp, message, messageSizeInBit, beginNumber, endNumber);
                    result = temp;
                }
            }
            return result;
        }

        private static void WriteMessage(Bitmap bitmap, string message, int msgSize, int beginNumber, int endNumber)
        {
            Random rand = new Random((beginNumber * endNumber) - endNumber);
            int bitIndex = 0;
            BitArray bitMessage = Utils.CreateResultBitArray(message, msgSize);
            int j_numb = 0;
            Channel channel = (Channel)rand.Next(1, 4);
            int inc = rand.Next(beginNumber, endNumber);
            for (int i = 0; i < bitmap.Width; i++)
            {
                int j = j_numb;
                for (; j < bitmap.Height; j += inc)
                {
                    if (bitIndex < bitMessage.Length)
                    {
                        Color pixelColor = bitmap.GetPixel(i, j);
                        byte channelByte = channel == Channel.R ? pixelColor.R : channel == Channel.G ? pixelColor.G : pixelColor.B;
                        ChangeLessBit(bitmap, i, j, channelByte, bitMessage[bitIndex], channel, pixelColor);
                        bitIndex++;
                    }
                    else
                    {
                        return;
                    }

                    if (inc > 1 && (j + inc) >= bitmap.Height)
                    {
                        j_numb = (j + inc) - bitmap.Height;
                        break;
                    }

                    inc = rand.Next(beginNumber, endNumber);
                }
            }
        }

        private static void WriteMessage(Bitmap bitmap, string message, int msgSize, Channel channel, int number)
        {
            int bitIndex = 0;
            BitArray bitMessage = Utils.CreateResultBitArray(message, msgSize);
            if (number == -1)
            {
                number = 1;
            }
            int j_numb = 0;
            for (int i = 0; i < bitmap.Width; i++)
            {
                int j = j_numb;
                for (; j < bitmap.Height; j += number)
                {
                    if (bitIndex < bitMessage.Length)
                    {
                        Color pixelColor = bitmap.GetPixel(i, j);
                        byte channelByte = channel == Channel.R ? pixelColor.R : channel == Channel.G ? pixelColor.G : pixelColor.B;
                        ChangeLessBit(bitmap, i, j, channelByte, bitMessage[bitIndex], channel, pixelColor);
                        bitIndex++;
                    }
                    else
                    {
                        return;
                    }

                    if (number > 1 && (j + number) >= bitmap.Height)
                    {
                        j_numb = (j + number) - bitmap.Height;
                        break;
                    }
                }
            }
        }

        private static void ChangeLessBit(Bitmap bitmap, int i, int j, byte channelByte, bool currentBit, Channel channel, Color pixelColor)
        {
            bool lessBit = channelByte.GetBit(0);
            if (currentBit != lessBit)
            {
                byte newChannelByte = lessBit ? (byte)(channelByte - 1) : (byte)(channelByte + 1);
                Color newPixelColor;
                if (channel == Channel.R)
                    newPixelColor = Color.FromArgb(newChannelByte, pixelColor.G, pixelColor.B);
                else if (channel == Channel.G)
                    newPixelColor = Color.FromArgb(pixelColor.R, newChannelByte, pixelColor.B);
                else
                    newPixelColor = Color.FromArgb(pixelColor.R, pixelColor.G, newChannelByte);
                bitmap.SetPixel(i, j, newPixelColor);
            }
        }

    }
}
