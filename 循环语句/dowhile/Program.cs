using System;

namespace dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            Console.WriteLine("while语句的执行结果为：");
            while (i<5)//先判断再做
            {
                Console.WriteLine("当前i的值为：{0}",i);
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("do-while语句的执行结果为:");
            do//先做一遍再判断
            {
                Console.WriteLine("当前i的值为：{0}", i);
                i++;
            } while (i<5);
            Console.Read();
        }
    }
}
