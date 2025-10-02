using System.Numerics;

namespace RSA_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //parse input
            int pe = int.Parse(args[0]);
            int pc = int.Parse(args[1]);
            int qe = int.Parse(args[2]);
            int qc = int.Parse(args[3]);
            BigInteger cypher = BigInteger.Parse(args[4]);
            BigInteger plain = BigInteger.Parse(args[5]);
            //calculate all other variables
            BigInteger p = BigInteger.Pow(2, pe) - pc;
            BigInteger q = BigInteger.Pow(2, qe) - qc;
            BigInteger n = p * q;
            //calculate phi
            BigInteger phi = (p - 1) * (q - 1);
            //d lies in the coefficent of the gcd of e and phi
            BigInteger e = 65537;
            BigInteger d = ModularInverse(e, phi);
            //Verify d is valid
            BigInteger res = (e * d) % phi;
            if(res != 1) {
                Console.WriteLine("Invalid results calculating d");
            }
            Console.WriteLine($"{BigInteger.ModPow(cypher, d, n)},{BigInteger.ModPow(plain, e, n)}");
        }
        private static BigInteger ExtendedEuclideanGCD(BigInteger valueA, BigInteger valueB,
                         out BigInteger coefficentA, out BigInteger coefficentB) {
            if (valueA == 0) {
                coefficentA = 0;
                coefficentB = 1;
                return valueB;
            }

            BigInteger coefficentA1;
            BigInteger coefficentB1;
            BigInteger gcd = ExtendedEuclideanGCD(valueB % valueA, valueA, out coefficentA1, out coefficentB1);

            coefficentA = coefficentB1 - (valueB / valueA) * coefficentA1;
            coefficentB = coefficentA1;
            
            return gcd;
        }
        public static BigInteger ModularInverse(BigInteger value, BigInteger mod) {
            BigInteger y;
            ExtendedEuclideanGCD(value, mod, out y, out _);
            //positive only, return the y coefficent
            return (y % mod + mod) % mod;
        }
    }
}
