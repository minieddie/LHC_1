using System;

namespace 循环语句
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i<5)
            {
                Console.WriteLine("当前i的值为：{0}",i);
                i++;
            }
            Console.Read();
        }
    }
}
