using System;
using System.Collections;
using System.Drawing;
using System.Linq;

namespace Steganography.Service
{
    public static class Extraction
    {

        public static string ExtractMessage(Image source, Channel channel)
        {
            string result = null;
            if (source != null)
            {
                Bitmap temp = new Bitmap(source);
                result = GetMessage(temp, channel);
            }
            return result;
        }

        private static string GetMessage(Bitmap bm, Channel channel)
        {
            int i = 0, j = 0, msgSize = 0, sizeBitIndex = 0, msgBitIndex = 0;
            string result = null;
            BitArray sizeArr = new BitArray(Utils.INT_SIZE_IN_BIT);
            for (; i < bm.Width; i++)
            {
                for (; j < bm.Height; j++)
                {
                    Color pixelColor = bm.GetPixel(i, j);
                    byte channelByte = channel == Channel.R ? pixelColor.R : channel == Channel.G ? pixelColor.G : pixelColor.B;
                    bool lessBit = channelByte.GetBit(0);
                    if (sizeBitIndex < Utils.INT_SIZE_IN_BIT)
                    {
                        sizeArr[sizeBitIndex] = lessBit;
                        sizeBitIndex++;
                    }
                    else if (sizeBitIndex == Utils.INT_SIZE_IN_BIT)
                    {
                        string temp = sizeArr.ToBitStr();
                        sizeArr = new BitArray(temp.Select(c => c == '1').ToArray());
                        msgSize = sizeArr.ToInt32();
                        break;
                    }
                }
                if (sizeBitIndex == Utils.INT_SIZE_IN_BIT)
                {
                    break;
                }
            }
            if (msgSize > 0)
            {
                BitArray msgArr = new BitArray(msgSize);
                for (; i < bm.Width; i++)
                {
                    for (; j < bm.Height; j++)
                    {
                        Color pixelColor = bm.GetPixel(i, j);
                        byte channelByte = channel == Channel.R ? pixelColor.R : channel == Channel.G ? pixelColor.G : pixelColor.B;
                        bool lessBit = channelByte.GetBit(0);
                        if (msgBitIndex < msgSize)
                        {
                            msgArr[msgBitIndex] = lessBit;
                            msgBitIndex++;
                        }
                        else
                        {
                            result = msgArr.ToUTF8Str();
                            return result;
                        }
                    }
                }
            }
            return result;
        }
    }
}
