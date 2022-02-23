using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_03
{
    internal static class Class1
    {
        
        static TextBox textBox_a_new = new TextBox();
        static TextBox textBox_b_new = new TextBox();
        
        public static void myCount(string str1, string str2, string op, TextBox textBox_result)
        {
            textBox_a_new.Text = str1;
            textBox_b_new.Text = str2;
            int a, b;
            myRead(out a, out b);

            int c = 0;
            if (op == "+")
                c = DoOperation(a, b, Plus);
            if (op == "-")
                c = DoOperation(a, b, Minus);
            if (op == "*")
                c = DoOperation(a, b, Multiply);
            if (op == "/")
                c = DoOperation(a, b, Division);
            if (op == "x^y")
                c = DoOperation(a, b, Pow);
            myWrite(c, textBox_result);
           
        }

        public static void myCount1(string str1, string str2, string opp, TextBox textBox_result)
        {
            textBox_a_new.Text = str1;
            int a;
            myRead1(out a);

            double c = 0;
            if (opp == "Log")
                c = SNOperation(a, Log);
            if (opp == "Sqrt")
                c = SNOperation(a, Sqrt);
            if (opp == "1/x")
                c = SNOperation(a, n);
            if (opp == "n!")
                c = SNOperation(a, k);
            myWrite1(c, textBox_result);

        }

        public delegate int Operation(int x, int y);

        static int Plus(int x, int y) 
        { 
            return x + y; 
        }
        static int Minus(int x, int y) => x - y;
        static int Multiply(int x, int y) => x * y;
        static int Division(int x, int y) => x / y;
        static int Pow(int x, int y)
        {
            return (int)Math.Pow(x, y); 
        }

        public delegate double NOperation(double x);
        static double Log(double x) => Math.Log(x);
        static double Sqrt(double x) => Math.Sqrt(x);
        static double n(double x) => 1/x;
        static double k(double x)
        {
            double i, fact = 1;
            for (i = 1; i <= x; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        public static int DoOperation(int a, int b, Operation op)
        {
            return op(a, b);
        }
        public static double SNOperation(int a, NOperation opp)
        {
            return opp(a);
        }

        static void myRead(out int a, out int b)
        {
            string str1 = textBox_a_new.Text;
            string str2 = textBox_b_new.Text;

            a = Convert.ToInt32(str1, 10);
            b = Convert.ToInt32(str2, 10);
        }

        static void myRead1(out int a)
        {
            string str1 = textBox_a_new.Text;

            a = Convert.ToInt32(str1, 10);
        }

        static void myWrite(int c, TextBox textBox_result)
        {
            string result = Convert.ToString(c);

            textBox_result.Text = result;
        }

        static void myWrite1(double c, TextBox textBox_result)
        {
            string result = Convert.ToString(c);

            textBox_result.Text = result;
        }
    }
}
