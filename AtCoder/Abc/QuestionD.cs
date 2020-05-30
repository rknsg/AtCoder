using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    //https://atcoder.jp/contests/abs/tasks/abc083_b
    class QuestionD
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力

            // 整数配列の入力
            var inputLongArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

            var N = inputLongArray[0];
            var A = inputLongArray[1];
            var B = inputLongArray[2];



            var count = 0;
            for(int i = 1; i <= N; i++)
            {
                var sum = GetSum(i);
                
                if(A <= sum && sum <= B)
                {
                    count += i;
                }
            }


            string result = count.ToString();

            Console.WriteLine(result);

            Console.Out.Flush();
        }

        private static int GetSum(int num)
        {
            //999 0, 9, 9, 9
            var n0 = num / 10000;
            var n1 = (num - 10000 * n0) / 1000;
            var n2 = (num - 10000 * n0 - 1000*n1) / 100;
            var n3 = (num - 10000 * n0 - 1000*n1 - 100*n2) / 10;
            var n4 = (num - 10000 * n0 - 1000 * n1 - 100 * n2 - 10 * n3);
            

            return n0 + n1 + n2 + n3 + n4;
        }
    }
}
