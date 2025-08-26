namespace EasyVigenere
{
    internal class Program
    {
        static string v = "SENDMOREMONEY";
        static int[] k = [9, 0, 1, 7, 23, 15, 21, 14, 11, 11, 2, 8,9];
        static void Main(string[] args)
        {
            string value = "";
            for (int i = 0; i < v.Length; i++)
            {
                var index = (int)v[i] + k[i] - 'A';
                while(index > 26)
                {
                    index -=26;
                }
                value += (char)(index+'A');
            }
            Console.WriteLine(value);
            string other = "CASHNOTNEEDED";
            var value2 = "";
            for (int i = 0; i < v.Length; i++)
            {
                value2 += (other[i]- value[i])+ " ";
            }
            Console.WriteLine(value2);
        }
    }
}
