using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    // https://atcoder.jp/contests/abs/tasks/abc085_b
    class QuestionF
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);


            // 整数の入力
            int n = int.Parse(Console.ReadLine());

            List<int> inputList = new List<int>(n);
            for(int i = 0; i < n; i++)
            {
                inputList.Add(int.Parse(Console.ReadLine()));                
            }

            var count = inputList.Distinct().ToList().Count();


            string result = count.ToString();

            Console.WriteLine(result);

            Console.Out.Flush();
        }
    }
}
