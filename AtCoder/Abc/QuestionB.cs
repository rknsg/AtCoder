using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    //https://atcoder.jp/contests/abs/tasks/abc081_b
    class QuestionB
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            int n = int.Parse(Console.ReadLine());

            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

            var count = 0;
            while(true)
            {
                // すべて偶数かチェック -> 奇数が1つでもあれば抜ける
                //var amari = 0;
                //Array.ForEach(inputLongArray, r => amari += r % 2);
                if(inputLongArray.Where(r => r%2 > 0).Any())
                {
                    break;
                }

                // すべて2で割り切れたら操作できる
                //if (amari == 0)
                {
                    //Array.ForEach(inputLongArray, r => r /= 2);
                    inputLongArray = inputLongArray.Select(r => r /= 2).ToArray();
                    count++;
                    continue;
                }

                //break;

            }

            string result = count.ToString();

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
