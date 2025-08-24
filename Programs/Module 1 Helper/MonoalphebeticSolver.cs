
// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace MonoAlphabeticSolver
{
    internal class Program
    {
        static string Cipher(string cipher, Dictionary<char,char> map)
        {
            string output = "";
            foreach (var c in cipher)
            {
                char m;

                if (map.TryGetValue(c, out m))
                {
                    var color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(m);
                    output += m;
                    Console.ForegroundColor = color;
                }
                else
                {
                    Console.Write(c);
                    output += c;
                }
            }
            Console.WriteLine();
            return output;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            Dictionary<char, char> map = new Dictionary<char, char>();
            string cipher = "ZITYOKLZEGDHXZTKZTKDOFQSLLXEIQLZITZTSTZNHTVTKTZNHTVKOZTKLZIQZEGXSRHKGRXETQFRWTEGFZKGSSTRWNCQKOGXLEGDHXZTKEGRTLZITLTXLTRZITJVTKZNSQNGXZLQFRQRRTRATNLLXEIQLTLEQHTTLEVIOEIIQRLHTEOQSDTQFOFULZGEGDHXZTKLSQZTKATNWGQKRLQRRTRYXFEZOGFATNLQFRQKKGVATNLLOFETZITLZQFRQKROMQZOGFGYHEEGDHQZOWSTEGDHXZTKLQFRVOFRGVLDGLZYXSSLOMTREGDHXZTKATNWGQKRLIQCTYGSSGVTRZIOLLZQFRQKRZIOLSQNGXZIQLQLTHQKQZTFXDTKOEATNHQRYGKRQZQTFZKNQZZITKOUIZYXFEZOGFATNLQEKGLLZITZGHQFRQEXKLGKLTEZOGFZGZITKOUIZQFRETFZTKVOZIATNLYGKOFLTKZRTSTZTIGDTTFRHQUTXHQFRHQUTRGVFVOZIEXKLGKQKKGVLOFQFOFCTKZTRZLIQHTTCTFZITATNWGQKRNGXQKTXLOFUZGRTEKNHZZIOLDTLLQUTLIGXSRWTQCQKOQFZGYJVTKZNXFSTLLNGXIQCTWXOSZNGXKGVFJVTKZNOLZITFTVQWER".ToLower();
            string output = "";
            if(File.Exists("keys.txt"))
            map = JsonSerializer.Deserialize<Dictionary<char, char>>(File.ReadAllText("keys.txt"));
            File.WriteAllText("output.txt", Cipher(cipher, map));
            File.WriteAllText("other.txt", string.Join("", map.OrderBy(k => k.Value).Select(k => k.Value)).ToUpper());
            File.WriteAllText("key.txt", string.Join("", map.OrderBy(k => k.Value).Select(k => k.Key)).ToUpper());
            do
            {
                Console.Write("Map ");
                var next = Console.ReadKey();
                if (next.KeyChar == '`')
                {
                    break;
                }
                Console.WriteLine();
                Console.Write("With ");
                var nMap = Console.ReadKey();
                map.Add(next.KeyChar, nMap.KeyChar);
                var json = JsonSerializer.Serialize(map);
                File.WriteAllText("keys.txt", json);
                File.WriteAllText("keys.txt", json);

                Console.WriteLine();
                File.WriteAllText("output.txt",Cipher(cipher, map));
            } while (true);
            File.WriteAllText("key.txt",string.Join("",map.OrderBy(k=>k.Value).Select(k=>k.Key)).ToUpper());
        }
    }
}
