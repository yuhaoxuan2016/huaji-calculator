using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rabbit_1._2beta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("made by rabbit");//欢迎
            Console.WriteLine("welcome!");
            Console.WriteLine("请输入一个数字并按回车");//输入第一个数字
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入一个数字并按回车");//输入第二个数字
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入一个整数并按回车，加法：1 减法:2 乘法:3 除法:4");//选择运算符号
            int result = int.Parse(Console.ReadLine());
            double a = number + number1;
            double b = number - number1;
            double c = number * number1;
            double d = number / number1;
            switch(result)//显示结果
            {
                case 1: Console.WriteLine("两数相加结果为{0}",a);break;
                case 2: Console.WriteLine("两数相减结果为{0}", b); break;
                case 3: Console.WriteLine("两数相乘结果为{0}", c); break;
                case 4: Console.WriteLine("两数相除结果为{0}", d); break;
                default: Console.WriteLine("你是来搞笑的吧！/滑稽");break;
            }
            Console.WriteLine("按任意键退出");
            Console.ReadKey();
        }
    }
}
