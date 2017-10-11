using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TJ2._7OutputTxtFromProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Administrator\Desktop\ConsoleOutput.txt");
            Console.SetOut(sw);

            double myDouble = 12.345678;
            Console.WriteLine("{0,20:G}--General", myDouble);//20表示右对齐，含变量共20位
            Console.WriteLine("{0,-10}--Default,same as General", myDouble);
            Console.WriteLine("{0,-10:F4}--Fixed Point,4 dec places", myDouble);//取小数点4位
            Console.WriteLine("{0,-10:C}--Currency", myDouble);//货币表示方法
            Console.WriteLine("{0,-10:E4}--Sci.Notation,3 dec places", myDouble);//科学计数法，4表示小数点后保留4位
            Console.WriteLine("{0,-10:N2}--分隔数字", 12345678.54321);//N2中的2表示小数点后保留几位
            Console.WriteLine("{0,-10:X4}--Hexadecimal integer", 11);//十六进制表示方法，X和x大小写区分，表示转换后的大小写；精度说明符：输出字符串中的最少位数。如果实际数的位数更少，则在左边以0填充
            Console.WriteLine("{0:P2}--Percentage style", 0.1234567);//转化为百分比
            Console.WriteLine("{0:R}--往返过程", 1234.21897);//保证输出字符串后如果使用Parse方法将字符串转化为数字，那么该值和原始值一样。
            Console.ReadKey();

            sw.Flush();
            sw.Close();
            //            12.345678--General
            //12.345678--Default,same as General
            //12.3457--Fixed Point,4 dec places
            //¥12.35--Currency
            //1.2346E+001--Sci.Notation,3 dec places
            //12,345,678.54--分隔数字
            //000B--Hexadecimal integer
            //12.35 % --Percentage style
            //1234.21897--往返过程
        }
    }
}
