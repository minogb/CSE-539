using System.Collections;

namespace Steganography
{
    internal class Program
    {
        static void Main(string[] args) {//args B1 FF FF CC 98 80 09 EA 04 48 7E C9.
            byte[] bmpBytes = new byte[] {
                0x42,0x4D,0x4C,0x00,0x00,0x00,0x00,0x00,
                0x00,0x00,0x1A,0x00,0x00,0x00,0x0C,0x00,
                0x00,0x00,0x04,0x00,0x04,0x00,0x01,0x00,
                0x18,0x00,0x00,0x00,0xFF,0xFF,0xFF,0xFF,
                0x00,0x00,0xFF,0xFF,0xFF,0xFF,0xFF,0xFF,
                0xFF,0x00,0x00,0x00,0xFF,0xFF,0xFF,0x00,
                0x00,0x00,0xFF,0x00,0x00,0xFF,0xFF,0xFF,
                0xFF,0x00,0x00,0xFF,0xFF,0xFF,0xFF,0xFF,
                0xFF,0x00,0x00,0x00,0xFF,0xFF,0xFF,0x00,
                0x00,0x00
            };
            //start position after the header
            var currentByte = bmpBytes.Length - (3 * 16);
            //parse the input
            var input = args[0].Split(" ");
            byte[] bytesToHide = new byte[input.Length];
            for (int i = 0; i < input.Length; i++) {
                bytesToHide[i] = Convert.ToByte(input[i], 16);
            }
            //Loop through each byte to hide
            for (int i = 0; i < bytesToHide.Length; i++) {
                //reverse loop through each hidding bit to get the correct order
                for (int position = 7; position > -1; position--) {
                    //because we are only setting two bits, we need to alternate between
                    //setting the last and first position
                    int hidePosition = position % 2 == 0 ? 0 : 1;
                    //calculate the value of the bit to hide
                    var hideBit = ((bytesToHide[i] >> position) & 1);
                    //xor the bit to hide
                    //bitArray[hidePosition] ^= hideBit;

                    byte mask = (byte)(hideBit << hidePosition);
                    bmpBytes[currentByte] ^= mask;
                    //if we have used up all locations to hide things in,
                    //move on to the next bit.
                    if (hidePosition == 0) {
                        //increment the new byte array, unless we are out of
                        //places to hide our bits.
                        currentByte++;
                    }
                }
            }
            Console.WriteLine(BitConverter.ToString(bmpBytes).Replace("-", " "));
        }
    }
}
