using System;

namespace If语句
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            int x = 13;

            if (condition)
            {
                Console.WriteLine("变量设置为真");
            }
            else
            {
                Console.WriteLine("变量设置为假");
            }

            if (x<5)
            {
                Console.WriteLine("x的值小于5！");
            }
            else if (x<10)
            {
                Console.WriteLine("x的值大于5小于10！");
            }
            else if (x<20)
            {
                Console.WriteLine("x的值大于10小于20！");
            }
            Console.ReadKey();
        }
    }
}
