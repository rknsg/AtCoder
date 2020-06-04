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
            List<int[]> list = new List<int[]>();
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine().Split(' ').Select(r => int.Parse(r)).ToArray());
            }

            // 移動元の点
            int t1 = 0;
            int x1 = 0;
            int y1 = 0;

            bool ret = true ;

            foreach(var array in list)
            {                
                // 移動先の点
                int t2 = array[0];
                int x2 = array[1];
                int y2 = array[2];

                // 移動時間
                int t = t2 - t1;

                // 移動距離
                var kyori = Math.Abs(x2 - x1) + Math.Abs(y2 - y1);

                var amari = t - kyori;

                // 時間が足りないか、余った時間を使いきれなければNG
                if(amari < 0 || (amari > 0 && amari % 2 > 0))
                {
                    ret = false;
                    break;
                }

                t1 = t2;
                x1 = x2;
                y1 = y2;
            }

            string result = ret? "Yes":"No";

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
