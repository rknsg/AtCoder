using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    //https://atcoder.jp/contests/abs/tasks/arc065_a
    public class QuestionA
    {
        List<string> keyword = new List<string> { "dreamer", "dream", "eraser", "erase" };

        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            string s = Console.ReadLine();

            // 整数の入力
            long n = long.Parse(Console.ReadLine());

            // 文字列配列の入力
            string[] inputStrArray = Console.ReadLine().Split(' ');

            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();




            string result = "";

            Console.WriteLine(result);

            Console.Out.Flush();
        }

        public List<string> CheckWords(List<string> list)
        {
            var ret = new List<string>();

            foreach(var word in list)
            {
                // 候補をリストに格納する
                foreach (var key in keyword)
                {
                    if (word.StartsWith(key))
                    {
                        ret.Add(TrimWord(word, key));
                    }
                }
            }

            return ret;

        }

        public static string TrimWord(string original, string word)
        {
            return original.Substring(0, word.Length);
        }
    }
}
