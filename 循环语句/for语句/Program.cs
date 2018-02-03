using System;

namespace for语句
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                Console.WriteLine("array[{0}]的值为：{1}",i,i);
            }
            Console.Read();
        }
    }
}
