using System;
using System.Collections;
using System.Drawing;
using System.Linq;

namespace Steganography.Service
{
    public static class Extraction
    {

        public static string Simple(Image source, Channel channel, int number = -1)
        {
            string result = null;
            if (source != null)
            {
                Bitmap temp = new Bitmap(source);
                result = ReadMessageSimple(temp, channel, number);
            }
            return result;
        }

        public static string RandBitsSkipping(Image source, int beginNumber, int endNumber)
        {
            string result = null;
            if (source != null)
            {
                Bitmap temp = new Bitmap(source);
                result = ReadMessageRandBitsSkipping(temp, beginNumber, endNumber);
            }
            return result;
        }

        public static string BlockOneChannel(Image source, Channel channel, int blockWidth, int blockHeight)
        {
            string result = null;
            if (source != null)
            {
                Bitmap temp = new Bitmap(source);
                result = ReadMessageBlockOneChannel(temp, channel, blockWidth, blockHeight);
            }
            return result;
        }

        public static string BlockThreeChannel(Image source, int blockWidth, int blockHeight)
        {
            string result = null;
            if (source != null)
            {
                Bitmap temp = new Bitmap(source);
                result = ReadMessageBlockThreeChannel(temp, blockWidth, blockHeight);
            }
            return result;
        }

        private static string ReadMessageBlockOneChannel(Bitmap bitmap, Channel channel, int blockWidth, int blockHeight)
        {
            int i = 0, j = 0, msgBitIndex = 0, sizeBitIndex = 0, msgSize = 0;
            string result = null;

            bool isSizeReading = false;
            BitArray sizeArr = new BitArray(Utils.INT_SIZE_IN_BIT);

            for (; i < bitmap.Width; i += blockWidth)
            {
                if (i + blockWidth > bitmap.Width)
                {
                    break;
                }

                for (; j < bitmap.Height; j += blockHeight)
                {
                    if (j + blockHeight > bitmap.Height)
                    {
                        j = 0;
                        break;
                    }

                    bool xorBit = bitmap.GetBlockXOR(i, j, blockWidth, blockHeight, channel);
                    if (sizeBitIndex < Utils.INT_SIZE_IN_BIT)
                    {
                        sizeArr[sizeBitIndex] = xorBit;
                        sizeBitIndex++;
                    }
                    else if (sizeBitIndex == Utils.INT_SIZE_IN_BIT)
                    {
                        string temp = sizeArr.ToBitStr();
                        sizeArr = new BitArray(temp.Select(c => c == '1').ToArray());
                        msgSize = sizeArr.ToInt32();
                        isSizeReading = true;
                        break;
                    }
                }

                if (sizeBitIndex == Utils.INT_SIZE_IN_BIT && isSizeReading)
                {
                    break;
                }
            }
            if (msgSize > 0)
            {
                BitArray msgArr = new BitArray(msgSize);
                for (; i < bitmap.Width; i += blockWidth)
                {
                    if (i + blockWidth > bitmap.Width)
                    {
                        break;
                    }

                    for (; j < bitmap.Height; j += blockHeight)
                    {
                        if (j + blockHeight > bitmap.Height)
                        {
                            j = 0;
                            break;
                        }

                        bool xorBit = bitmap.GetBlockXOR(i, j, blockWidth, blockHeight, channel);
                        if (msgBitIndex < msgSize)
                        {
                            msgArr[msgBitIndex] = xorBit;
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

        private static string ReadMessageBlockThreeChannel(Bitmap bitmap, int blockWidth, int blockHeight)
        {
            int i = 0, j = 0, msgBitIndex = 0, sizeBitIndex = 0, msgSize = 0;
            string result = null;

            bool isSizeReading = false;
            BitArray sizeArr = new BitArray(Utils.INT_SIZE_IN_BIT);

            for (; i < bitmap.Width; i += blockWidth)
            {
                if (i + blockWidth > bitmap.Width)
                {
                    break;
                }

                for (; j < bitmap.Height; j += blockHeight)
                {
                    if (j + blockHeight > bitmap.Height)
                    {
                        j = 0;
                        break;
                    }

                    bool xorBit = bitmap.GetBlockXOR(i, j, blockWidth, blockHeight);
                    if (sizeBitIndex < Utils.INT_SIZE_IN_BIT)
                    {
                        sizeArr[sizeBitIndex] = xorBit;
                        sizeBitIndex++;
                    }
                    else if (sizeBitIndex == Utils.INT_SIZE_IN_BIT)
                    {
                        string temp = sizeArr.ToBitStr();
                        sizeArr = new BitArray(temp.Select(c => c == '1').ToArray());
                        msgSize = sizeArr.ToInt32();
                        isSizeReading = true;
                        break;
                    }
                }

                if (sizeBitIndex == Utils.INT_SIZE_IN_BIT && isSizeReading)
                {
                    break;
                }
            }
            if (msgSize > 0)
            {
                BitArray msgArr = new BitArray(msgSize);
                for (; i < bitmap.Width; i += blockWidth)
                {
                    if (i + blockWidth > bitmap.Width)
                    {
                        break;
                    }

                    for (; j < bitmap.Height; j += blockHeight)
                    {
                        if (j + blockHeight > bitmap.Height)
                        {
                            j = 0;
                            break;
                        }

                        bool xorBit = bitmap.GetBlockXOR(i, j, blockWidth, blockHeight);
                        if (msgBitIndex < msgSize)
                        {
                            msgArr[msgBitIndex] = xorBit;
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

        private static int GetMessageSize(Bitmap bitmap, Channel channel, int beginNumber)
        {
            int result = 0;
            int j_numb = 0, j = 0, i = 0, sizeBitIndex = 0;
            bool isSizeReading = false;
            BitArray sizeArr = new BitArray(Utils.INT_SIZE_IN_BIT);

            for (; i < bitmap.Width; i++)
            {
                j = j_numb;
                for (; j < bitmap.Height; j += beginNumber)
                {
                    Color pixelColor = bitmap.GetPixel(i, j);
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
                        result = sizeArr.ToInt32();
                        isSizeReading = true;
                        j_numb = j;
                        break;
                    }

                    if (beginNumber > 1 && (j + beginNumber) >= bitmap.Height)
                    {
                        j_numb = (j + beginNumber) - bitmap.Height;
                        break;
                    }

                }
                if (sizeBitIndex == Utils.INT_SIZE_IN_BIT && isSizeReading)
                {
                    break;
                }
            }
            return result;
        }

        private static string ReadMessageSimple(Bitmap bitmap, Channel channel, int number)
        {

            if (number == -1)
            {
                number = 1;
            }

            int i = 0, msgBitIndex = 0;
            int j_numb = 0;
            string result = null;

            int msgSize = GetMessageSize(bitmap, channel, number);

            if (msgSize > 0)
            {
                BitArray msgArr = new BitArray(msgSize);
                for (; i < bitmap.Width; i++)
                {
                    int j = j_numb;
                    for (; j < bitmap.Height; j += number)
                    {
                        Color pixelColor = bitmap.GetPixel(i, j);
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

                        if (number > 1 && (j + number) >= bitmap.Height)
                        {
                            j_numb = (j + number) - bitmap.Height;
                            break;
                        }
                    }
                }
            }
            return result;
        }

        private static string ReadMessageRandBitsSkipping(Bitmap bitmap, int beginNumber, int endNumber)
        {
            Random rand = new Random((beginNumber * endNumber) - endNumber);
            Channel channel = (Channel)rand.Next(1, 4);
            int inc = rand.Next(beginNumber, endNumber);
            int i = 0, msgBitIndex = 0, sizeBitIndex = 0, j_numb = 0, msgSize = 0;
            string result = null;

            bool isSizeReading = false;
            BitArray sizeArr = new BitArray(Utils.INT_SIZE_IN_BIT);

            for (; i < bitmap.Width; i++)
            {
                int j = j_numb;
                for (; j < bitmap.Height; j += inc)
                {
                    Color pixelColor = bitmap.GetPixel(i, j);
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
                        isSizeReading = true;
                        j_numb = j;
                        break;
                    }

                    if (inc > 1 && (j + inc) >= bitmap.Height)
                    {
                        j_numb = (j + inc) - bitmap.Height;
                        break;
                    }

                    inc = rand.Next(beginNumber, endNumber);
                }
                if (sizeBitIndex == Utils.INT_SIZE_IN_BIT && isSizeReading)
                {
                    break;
                }
            }
            if (msgSize > 0)
            {
                BitArray msgArr = new BitArray(msgSize);
                for (; i < bitmap.Width; i++)
                {
                    int j = j_numb;
                    for (; j < bitmap.Height; j += inc)
                    {
                        Color pixelColor = bitmap.GetPixel(i, j);
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

                        if (inc > 1 && (j + inc) >= bitmap.Height)
                        {
                            j_numb = (j + inc) - bitmap.Height;
                            break;
                        }
                        inc = rand.Next(beginNumber, endNumber);
                    }
                }
            }
            return result;
        }
    }
}