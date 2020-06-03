using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    //https://atcoder.jp/contests/abs/tasks/arc089_a
    class QuestionB
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            int n = int.Parse(Console.ReadLine());

            for(int t = 0; t < n; t++)
            {
                // 整数配列の入力
                var inputLongArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();



            }





            string result = "";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
