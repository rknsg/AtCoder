using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abs/tasks/abc088_b
    class QuestionE
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            // 整数の入力
            int n = int.Parse(Console.ReadLine());

            // 整数配列の入力
            var inputIntArray = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

            // 大きい順にソート
            Array.Sort(inputIntArray);
            Array.Reverse(inputIntArray);

            int Alice = 0;
            int Bob = 0;
            for(int i = 0; i < n; i++)
            {
                if(i%2 == 0)
                {
                    Alice += inputIntArray[i];
                }
                else
                {
                    Bob += inputIntArray[i];
                }
            }
            
            string result = (Alice - Bob).ToString();

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
