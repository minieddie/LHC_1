using System;

namespace foreach语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach语句用于遍历数组或对象集合中的元素，只有那些实现了System.Collections.IEnumerable和System.Collections.Generic.IEnumerable<T>接口的数组或对象集合才可以使用
            int[] array = new int[] { 0, 1, 1, 2, 3, 4 };
            Console.WriteLine("数组中每个元素如下:");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
