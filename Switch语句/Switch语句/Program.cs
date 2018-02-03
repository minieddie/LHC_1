using System;

namespace Switch语句
{
    class Program
    {
        static void Main(string[] args)
        {
        
            {
                int switchVar = 2;
                switch (switchVar)
                {
                    case 0:
                    case 1:
                        Console.WriteLine("变量的值是0或1");
                        break;
                    case 2:
                        Console.WriteLine("变量的值是2");
                        break;
                        Console.WriteLine("不可能执行的语句");//该语句将引起一个警告
                    default:
                        Console.WriteLine("默认情况");//默认情况（default语句是可选的）
                        break;
                }
                Console.Read();
            }
        }
    }
}
