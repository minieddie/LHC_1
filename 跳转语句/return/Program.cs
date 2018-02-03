using System;

namespace return语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //return语句与break的区别：break只退出整个循环，循环体之后的代码依然会被执行；return则不但退出整个循环，还退出了循环所在的函数。

            Console.WriteLine("使用break退出循环的情况：");
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    break;
                }
                Console.WriteLine("当前i的值为：{0}", i);
            }
            Console.WriteLine("循环已退出！");

            Console.ReadKey();//输入任意按键后执行下方程序，会退出整个Main函数

            Console.WriteLine("使用return退出循环的情况：");
            for (int i = 0; i < 5; i++)
            {
                if (i==2)
                {
                    return;//return 退出整个Main函数
                }
                Console.WriteLine("当前i的值为：{0}",i);
            }

            Console.WriteLine("循环已退出！");

            
        }

        
    }
}
