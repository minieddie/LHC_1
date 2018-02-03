using System;

namespace LHC_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Complex number1 = new Complex(1,2);
            Complex number2 = new Complex(3,4);

            //用+运算符对两个复数进行相加
            //如果复数类型中没有对+运算符进行重载
            //则此处将不能使用+运算符来对复数类型进行相加操作
            Complex sum = number1 + number2;

            Console.WriteLine("第一个复数为：{0}",number1);
            Console.WriteLine("第二个复数为：{0}",number2);
            Console.WriteLine("两个复数的和为：{0}",sum);

            Console.Read();
        }

        //public void TestMethod()//变量的访问域
        //{
        //    string[] varInMethod = new string[5] { "H", "e", "l", "l", "o" };

        //    foreach (string varforeach in varInMethod)
        //    {
        //        Console.WriteLine(varforeach);
        //     }
        //}

        public struct Complex//Complex 结构体属于一个自定义结构体
        {
            public int real;//复数的实数部分

            public int imaginary;//复数的虚数部分

            public Complex(int real,int imaginary)
            {
                this.real = real;//初始化复数的实数和虚数
                this.imaginary = imaginary;
            }

            //+运算符重载方法
            //    complex1表示一个操作数，类型必须为Complex类型
            //    第二个操作数的类型也必须为Complex类型
            //    返回为Complex类型
            public static Complex operator+(Complex complex1,Complex complex2)
            {
                Complex result = new Complex();//值类型都有默认无参构造函数，通过无参构造函数进行初始化

                result.real = complex1.real + complex2.real;
                result.imaginary = complex1.imaginary + complex2.imaginary;

                return result;
            }

            public override string ToString()//重载ToString()方法
            {
                return string .Format("{0}+{1}i",real,imaginary);
            }
        }

    }

  
}
