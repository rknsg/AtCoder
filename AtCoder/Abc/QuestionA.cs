using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    //https://atcoder.jp/contests/abs/tasks/abc081_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 文字列の入力
            string s = Console.ReadLine();

            // 整数の入力
            //long n = long.Parse(Console.ReadLine());

            // 文字列配列の入力
            //string[] inputStrArray = Console.ReadLine().Split(' ');

            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

            //1の数を数える 101 001 111
            List<string> list = new List<string>();
            var count = 0;
            for(int i = 0; i < 3; i++)
            {

                if(s.Substring(i,1) == "1")
                {
                    count++;
                }

            }

            string result = count.ToString();

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
