using System.Collections;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace Cryptanalysis {
    internal class Program {
        
        static void Main(string[] args) {
            string plaintext = args[0];
            string ciphertext = args[1];
            //calculate how big now is
            var maxTime = DateTime.Now;
            //check if the key was generated in the last year
            var minTime = DateTime.Now - TimeSpan.FromDays(365);
            var timeZero = new DateTime(1970, 1, 1);
            do {
                TimeSpan ts = maxTime.Subtract(timeZero);
                var maxMinutes = (int)ts.TotalMinutes;
                //set the expected range of generation to something reasonable
                var cMinutes = (int)minTime.Subtract(new DateTime(1970, 1, 1)).TotalMinutes;
                //we passed the known limits of the universe
                while (cMinutes < maxMinutes) {
                    Random rng = new Random(++cMinutes);
                    byte[] key = BitConverter.GetBytes(rng.NextDouble());
                    if (Encrypt(key, plaintext) == ciphertext) {
                        //we found the seed
                        Console.WriteLine(cMinutes);
                        return;
                    }
                }
                //Well i guess we didn't find it, go back a year
                maxTime = minTime;
                minTime -= TimeSpan.FromDays(365);
            } while (maxTime > timeZero);
        }
        private static string Encrypt(byte[] key, string secretString) {
#pragma warning disable SYSLIB0021 // Type or member is obsolete
            DESCryptoServiceProvider csp = new DESCryptoServiceProvider();
#pragma warning restore SYSLIB0021 // Type or member is obsolete
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms,
            csp.CreateEncryptor(key, key), CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cs);
            sw.Write(secretString);
            sw.Flush();
            cs.FlushFinalBlock();
            sw.Flush();
            return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
        }
    }
}
