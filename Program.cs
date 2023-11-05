using MatrixLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixClientProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(2, 2, new int[,] { { 5, 4 }, { 8, 4} });
            Matrix m2 = new Matrix(2, 2, new int[,] { { 5, 3 }, { 3, 4 } });
            Matrix m3 = new Matrix(2, 2, new int[,] { { 9, 4 }, { 3, 4 } });
            Matrix c = m1 + m2;
            Matrix d = m1 * m2;
            Matrix e = m1 * 3;
            bool f = m1 == m3;
            bool g = m1 != m2;
            double determinant = ~m1;
            Matrix m4 = new Matrix();
            m4.Set();
            Console.WriteLine("----------------------------------------------------------------");
            Console.Write($"Enter matrix: \n{m4} \n");
            Console.WriteLine("----------------------------------------------------------------");
            if (m1) Console.Write($"The matrix size is set correctly \n");
            Console.WriteLine("----------------------------------------------------------------");
            Console.Write($"{m1.ToString()}  + \n{m2.ToString()}  = \n{c.ToString()} \n");
            Console.WriteLine("----------------------------------------------------------------");
            Console.Write($"{m1.ToString()}  * \n{m2.ToString()}  = \n{d.ToString()}\n");
            Console.WriteLine("----------------------------------------------------------------");
            Console.Write($"{m1.ToString()} * \n 3\n = \n{e.ToString()}\n");
            Console.WriteLine("----------------------------------------------------------------");
            Console.Write($"Are the matrices equal? \n{m1.ToString()} and \n{m3.ToString()}\n{f} \n");
            Console.WriteLine("----------------------------------------------------------------");
            Console.Write($"Are the matrices not equal? \n{m1.ToString()} and \n{m2.ToString()}\n{g}\n");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Determinant of m1: {determinant}");
            Console.WriteLine("----------------------------------------------------------------");


        }
    }
}
