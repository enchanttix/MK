using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MK
{
    internal class Program
    {
        static void pi()
        {
            double n = 1000;
            int k = 0;
            double s;
            double x;
            double y;
            Random random = new Random();

            for (int i = 0; i <= n; i++)
            {
                x = random.NextDouble();
                y = random.NextDouble();

                if (((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= 1)
                {
                    k += 1;
                }
            }
            s = 4 * k / n;
            Console.WriteLine(s);
        }

        static void p1()
        {
            double n = 1000;// количество точек
            double k = 0;// количество точек, попавших внутрь фигуры
            double s, x, y;
            double a = 5;// ширина
            double b = 8.5;// высота
            Random random = new Random();

            for (int i = 0; i <= n; i++)
            {
                x = random.NextDouble() * (0 - b) + b;
                y = random.NextDouble() * (0 - a) + a;

                if ((x / 3 <= y) && (y <= (x * (10 - x)) / 5))// если точка находится внутри фигуры
                {
                    k++;// увеличиваем счетчик точек
                }
            }
            s = a * b * k / n;
            Console.WriteLine(s);
        }

        static public void p2()
        {
            int n = 1000; 
            int k = 0; 
            double a = 20;
            double s;

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                double x = random.NextDouble() * (20) - 5; 
                double y = random.NextDouble(); 

                if (y < Math.Sin(x) && y > 0) 
                {
                    k++; 
                }
            }
            s = a * k / n;

            Console.WriteLine(s);
        }
        static public void p3()
        {
            int n = 1000; 
            int k = 0; 
            double a = 20;
            double b = 10;
            double s;

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                double x = random.NextDouble() * (20) - 10;
                double y = random.NextDouble() * b;

                if (y <= x * (8 - x) / 2 && y >= x / 2)
                {
                    k++;
                }
            }
            s = a * b * k / n;

            Console.WriteLine(s);
        }
        static public void p4()
        {
            int n = 1000; 
            int k = 0; 
            double a = 15;
            double b = 7;
            double s;

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                double x = random.NextDouble() * a;
                double y = random.NextDouble() * b;

                if (y >= ((x - 6) * (x - 6)) / 6 && y <= 6)
                {
                    k++;
                }
            }

            s = a * b * k / n;
            Console.WriteLine(s);
        }

        static public void p5()
        {
            int n = 1000; 
            int k = 0;
            double a = 15;
            double b = 4;
            double s;

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                double x = random.NextDouble() * a;
                double y = random.NextDouble() * b;

                if (y > (x * (12 - x) / 9) && y >= x / 5)
                {
                    k++;
                }
            }

            s = a * b * k / n;

            Console.WriteLine(s);
        }

        static public void p6()
        {
            int n = 1000; 
            int k = 0; 
            double a = 10;
            double b = 5;
            double s;

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                double x = random.NextDouble() * a;
                double y = random.NextDouble() * b;

                if (y >= x * (8 - x) / 4 && y >= (8 - x) / 8)
                {
                    k++;
                }
            }

            s = a * b * k / n;

            Console.WriteLine(s);
        }

        static public void p7()
        {
            int n = 1000; 
            int k = 0; 
            double a = 20;
            double s;

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                double x = random.NextDouble() * 20 - 5;
                double y = random.NextDouble();

                if (y <= Math.Sin(x) && y >= Math.Pow(x - 2, 2) / 2)
                {
                    k++;
                }
            }


            s = a * k / n;

            Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
            pi();
            p1();
            p2();
            p3();
            p4();
            p5();
            p6();
            p7();
        }
    }
}
