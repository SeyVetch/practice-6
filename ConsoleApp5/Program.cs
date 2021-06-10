using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// сделал Маханов 1исп 11 - 17 практическая № 6
/// </summary>

namespace ConsoleApp5
{
    class prog2
    {
        private char p;
        void method1(char inp)
        {
            this.p = inp;
        }
        int method2()
        {
            return (int)p;
        }
        void method3()
        {
            Console.WriteLine(p + " " + method2());
        }
    }
    class prog3
    {
        char a;
        char b;
        void method()
        {
            for (int i = (int)this.a; i <= (int)this.b; i++)
            {
                Console.Write((char)i);
            }
            Console.WriteLine();
        }
    }
    class prog4
    {
        int a;
        int b;
        prog4()
        {
            a = 0;
            b = 0;
        }
        prog4(int x)
        {
            a = x;
            b = x;
        }
        prog4(int x, int y)
        {
            a = x;
            b = y;
        }
    }
    class prog5
    {
        int n;
        char c;
        prog5(int a, char b)
        {
            this.n = a;
            this.c = b;
        }
        prog5(double x)
        {
            this.n = Convert.ToInt32(Math.Truncate(x));
            this.c = (char)Convert.ToInt32(Math.Truncate((x - this.n) * 100));
        }
    }
    class prog6
    {
        private int n;
        prog6(int a = 0)
        {
            this.n = a;
        }
        void method(int a = 0)
        {
            this.n = a;
        }
    }
    class prog7
    {
        private int max;
        private int min;
        prog7(int a)
        {
            this.max = a;
            this.min = a;
        }
        prog7(int a, int b)
        {
            int[] nums = {a, b};
            int mi = int.MaxValue;
            int ma = int.MinValue;
            for (int i = 0; i < 2; i++)
            {
                if (nums[i] > mi)
                {
                    mi = nums[i];
                }
                if (nums[i] < mi)
                {
                    mi = nums[i];
                }
            }
            this.min = mi;
            this.max = ma;
        }
        void method1()
        {
            Console.WriteLine(max + " " + min);
        }
        void method2(int a)
        {

            int[] nums = { a, this.max, this.min };
            int mi = int.MaxValue;
            int ma = int.MinValue;
            for (int i = 0; i < 3; i++)
            {
                if (nums[i] > mi)
                {
                    mi = nums[i];
                }
                if (nums[i] < mi)
                {
                    mi = nums[i];
                }
            }
            this.min = mi;
            this.max = ma;
        }
        void method3(int a, int b)
        {

            int[] nums = { a, b, this.max, this.min };
            int mi = int.MaxValue;
            int ma = int.MinValue;
            for (int i = 0; i < 4; i++)
            {
                if (nums[i] > mi)
                {
                    mi = nums[i];
                }
                if (nums[i] < mi)
                {
                    mi = nums[i];
                }
            }
            this.min = mi;
            this.max = ma;
        }
    }
    class prog8
    {
        char c;
        string s;
        prog8(char a)
        {
            c = a;
        }
        prog8(string a)
        {
            s = a;
        }
        prog8(char[] a)
        {
            if (a.Length == 1)
            {
                c = a[0];
            }
            else
            {
                s = Convert.ToString(a);
            }
        }
    }
    class prog9
    {
        private static int x = 0;
        static void method()
        {
            Console.WriteLine(x);
            x++;
        }
    }
    class prog10
    {
        static int method1(params int[] n)
        {
            int max = int.MinValue;
            for (int i = 0; i < n.Length; i++)
            {
                if (max < n[i])
                {
                    max = n[i];
                }
            }
            return max;
        }
        static int method2(params int[] n)
        {
            int min = int.MaxValue;
            for (int i = 0; i < n.Length; i++)
            {
                if (min > n[i])
                {
                    min = n[i];
                }
            }
            return min;
        }
        static double method3(params int[] n)
        {
            double sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];
            }
            return sum / n.Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
