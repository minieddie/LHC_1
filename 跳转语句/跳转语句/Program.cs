using System;

namespace 跳转语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //break语句：直接退出整个循环
            //continue语句：立即终止本次循环，但会继续执行下一次循环
            //goto语句：跳出讯号到已标记好的位置上（为了使代码易于阅读和理解，不建议大家使用goto语句退出循环）
            //return语句：退出循环和循环所在的函数

            Console.WriteLine("使用continue退出循环的情况：");
            for (int i = 0; i < 5; i++)
            {
                if (i==2)
                {
                    continue;
                }
                Console.WriteLine("当前i的值为：{0}",i);
            }

            Console.WriteLine("使用break退出循环的情况：");
            for (int i = 0; i < 5; i++)
            {
                if (i==2)
                {
                    break;
                }
                Console.WriteLine("当前i的值为：{0}",i);
            }

            Console.Read();
        }
    }
}
