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
        static List<string> keyword = new List<string> { "dreamer", "dream", "eraser", "erase" };

        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            string s = Console.ReadLine();

            var list = new List<string>() { s };
            
            while(list != null && list.Any())
            {
                list = CheckWords(list);
            }
                     
            string result = (list == null)? "YES" : "NO";

            Console.WriteLine(result);

            Console.Out.Flush();
        }

        public static List<string> CheckWords(List<string> list)
        {
            var ret = new List<string>();

            foreach(var word in list)
            {
                // 候補をリストに格納する
                foreach (var key in keyword)
                {
                    if (word.StartsWith(key))
                    {
                        var trimmed = TrimWord(word, key);
                        if(!string.IsNullOrEmpty(trimmed))
                        {
                            ret.Add(trimmed);
                        }
                        else
                        {
                            ret = null;
                            break;
                        }
                    }
                }
            }

            return ret;

        }

        public static string TrimWord(string original, string word)
        {
            return original.Substring(word.Length);
        }
    }
}
