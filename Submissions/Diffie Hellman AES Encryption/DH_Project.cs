using System.Numerics;
using System.Security.Cryptography;
using System.Text;


namespace DH_Project
{
    internal class Program
    {
        static void Main(string[] args) {
            //------------------------------Input--------------------------------------
            byte[] init =                     ToBytes(args[0]);
            int gE =                        int.Parse(args[1]);
            BigInteger gC =          BigInteger.Parse(args[2]);
            int nE =                        int.Parse(args[3]);
            BigInteger nC =          BigInteger.Parse(args[4]);
            int x =                         int.Parse(args[5]);
            BigInteger gYn =         BigInteger.Parse(args[6]);
            byte[] encrypted =                ToBytes(args[7]);
            string outPlain =                         args[8];
            //------------------------------Setup--------------------------------------
            byte[] outPlainBytes = Encoding.UTF8.GetBytes(outPlain);
            byte[] encryptedOutBytes;
            BigInteger n = BigInteger.Pow(2, nE) - nC;
            var aes = System.Security.Cryptography.Aes.Create();
            var key = BigInteger.ModPow(gYn, x,n).ToByteArray();
            string inPlain;
            //------------------------------Decrypt--------------------------------------
            var decryptor = aes.CreateDecryptor(key, init);
            using (MemoryStream msDecrypt = new MemoryStream(encrypted)) {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)) {
                    using (StreamReader swDecrypt = new StreamReader(csDecrypt)) {
                        inPlain = swDecrypt.ReadToEnd();
                    }
                }
            }
            Console.Write(inPlain);
            Console.Write(",");
            //------------------------------Encrypt--------------------------------------
            var encryptor = aes.CreateEncryptor(key, init);
            using (MemoryStream msEncrypt = new MemoryStream()) {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)) {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt)) {
                        foreach (var b in outPlain) {
                            swEncrypt.Write(b);
                        }
                    }
                    encryptedOutBytes = msEncrypt.ToArray();
                }
            }
            Console.Write(BitConverter.ToString(encryptedOutBytes).Replace("-", " "));
        }
        /// <summary>
        /// Easy function to convert a string of bytes to bytes
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static byte[] ToBytes(string value) {
            string[] initValues = value.Split(" ");
            byte[] init = new byte[initValues.Length];
            for (int i = 0; i < initValues.Length; i++) {
                init[i] = Convert.ToByte(initValues[i], 16);
            }
            return init;
        }
    }
}
