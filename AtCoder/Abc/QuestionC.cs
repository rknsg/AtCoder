using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    //https://atcoder.jp/contests/abs/tasks/abc087_b
    class QuestionC
    {

        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int X = int.Parse(Console.ReadLine());

            int count = 0;

            // ①500円の枚数を決める
            var n_500 = Math.Min(X / 500, A);
            
            // ②100円の枚数を決めて、50円で残りが払えたらカウント
            for(int i = n_500; i >= 0; i--)
            {
                // 100円,50円で実現すべき金額
                var amari = X - (500 * i);

                // 100円玉の出せる数
                var n_100 = Math.Min(amari / 100, B);

                for(int j = n_100; j >= 0; j--)
                {
                    // 50円で実現すべき金額
                    var nokori = amari - (100 * j);

                    if (nokori % 50 == 0 && nokori / 50 <= C)
                    {
                        count++;
                    }
                }
            }
 
            string result = count.ToString();

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
