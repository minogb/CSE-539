using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;

namespace Hash_Project {
    internal class Program {
        public static void Main(string[] args) {
            Dictionary<string,string> Dictionary = new Dictionary<string, string>();
            byte salt = Convert.ToByte(args[0], 16);
            while (true) {
                var source = CreateString(127);
                var hashValue = Encoding.UTF8.GetBytes(source);
                Array.Resize(ref hashValue, hashValue.Length + 1);
                hashValue[hashValue.Length - 1] = salt;
                var saltedHash = System.Security.Cryptography.MD5.HashData(hashValue).Take(5);
                string hash = BitConverter.ToString(saltedHash.ToArray()).Replace("-", "");
                if (Dictionary.ContainsKey(hash)) {
                    Console.WriteLine($"{Dictionary[hash]},{source}");
                    return;
                }
                else {
                    Dictionary.Add(hash, source);
                }
            }
        }
        static Random random = new Random();
        internal static string CreateString(int stringLength) {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, stringLength)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
