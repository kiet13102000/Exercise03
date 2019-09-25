using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            write();
            ChanLe(5);
            maxximum(3, 2, 1);
            minimum(3, 2, 1);
            midmum(3, 2, 1);
            check(70);
            demngay();
            vehangngang(10 , 'a');
            vehangdoc(10, 'a');
            veduongcheo(10, '*');
            Problem7(4);
            Problem6(4);
        }
        static void write()
        {
            
            Console.WriteLine("_______________¶______");
            Console.WriteLine(@"| Love OOP & C#  ||l""|""\_,_");
            Console.WriteLine("| ______________ ||| __ | __ | __ |]");
            Console.WriteLine("(@)@)**********(@)(@)**(@)");

        }
        static void ChanLe(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("so " + n + " la so chan");
            }
            else
                Console.WriteLine("so " + n + " la so le ");
        }
        static void maxximum(int a , int b , int c)
        {
            if (a> b && a >c)
            {
                Console.WriteLine("so lon nhat la so " + a);
            }
            if (b>a && b >c)
            {
                Console.WriteLine("so lon nhat la so " + b);
            }
            else
            {
                Console.WriteLine("so lon nhat la so " + c);
            }
        }
        static void minimum(int a , int b , int c)
        {
            if (a < b && a < c)
            {
                Console.WriteLine("so nho nhat la so " + a);
            }
            if (b < a && b < c)
            {
                Console.WriteLine("so nho nhat la so " + b);
            }
            else
            {
                Console.WriteLine("so nho nhat la so " + b);
            }
        }
        static void midmum(int a , int b, int c)
        {
            if ( a > b && a<c)
            {
                Console.WriteLine("so mid  la so " + a);
            }
            if( b>a && b<c)
            {
                Console.WriteLine("so mid la so " + b);
            }
            else
            {
                Console.WriteLine("so mid la so " + c);
            }
            
        }
        static void check(int a)
        {
          if (a >0 && a<=60)
            {
                Console.WriteLine("F");
            }
            if (a > 60 && a <= 70)
            {
                Console.WriteLine("D");
            }
            if (a > 70 && a <= 80)
            {
                Console.WriteLine("C");
            }
            if (a > 80 && a <= 90)
            {
                Console.WriteLine("B");
            }
            if (a > 90 && a <= 100)
            {
                Console.WriteLine("A");
            }
        }
        static void demngay()
        {
            DateTime d1 = DateTime.Now;
            DateTime d2 = Convert.ToDateTime("1/1/2019");
            TimeSpan Time = d1 - d2;
            int Songay = Time.Days;
            Console.WriteLine("so ngay la :" + Songay);
        }
        static void vehangngang(int n, char a)
        {
            for (int i=1; i<=n; i++)
            {
                Console.Write(a);
            }
        }
        static void vehangdoc(int n , char a)
        {
            for (int i=0; i<n-1; i++)
            {
                Console.WriteLine(a);
            }
        }
        static void veduongcheo(int n , char a)
        {
            for (int i= 0; i < n ; i++)
            {
                for (int j=0; j<n; j++)
                {
                    if (i == j)
                    {
                        Console.Write(a);
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();

            }
        }
        static void Problem6(int n)
        {
            Console.WriteLine("Horizontal line : ");
            DrawHorizontalLine(n, '*');
            Console.WriteLine("Vertical line : ");
            DrawVerticalLine(n, '*');
            Console.WriteLine("Diagonal line : ");
            DrawDiagonalLine(n, '*');
        }

        static void DrawHorizontalLine(int n, char c)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(c);
            }
        }

        static void DrawVerticalLine(int n, char c)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(c);
            }
        }

        static void DrawDiagonalLine(int n, char c)
        {
            for (int i = 1; i <= n; i++)
            {
                DrawHorizontalLine(i - 1, ' ');
                Console.WriteLine(c);
            }
        }

        static void Problem7(int n)
        {
            Console.WriteLine("Isosceles triangle up : ");
            DrawUpIsoscelesTriangle(n, '*');
            Console.WriteLine("N letter : ");
            DrawNLetter(5, '*');
            Console.WriteLine("Isosceles triangle down : ");
            DrawDownIsoscelesTriangle(n, '*');
        }

        static void DrawUpIsoscelesTriangle(int n, char c)
        {
            DrawHorizontalLine(n - 1, ' ');
            Console.WriteLine(c);

            int pre = n - 2, cen = 1;

            for (int i = 1; i <= n - 2; i++)
            {
                DrawHorizontalLine(pre, ' ');
                DrawHorizontalLine(1, c);
                DrawHorizontalLine(cen, ' ');
                DrawHorizontalLine(1, c);
                Console.WriteLine();
                pre -= 1;
                cen += 2;
            }

            DrawHorizontalLine(2 * n - 1, c);
            Console.WriteLine();
        }

        static void DrawNLetter(int n, char c)
        {
            DrawHorizontalLine(1, c);
            DrawHorizontalLine(n - 2, ' ');
            Console.WriteLine(c);

            int pre = 0, next = n - 3;
            for (int i = 1; i <= n - 2; i++)
            {
                DrawHorizontalLine(1, c);
                DrawHorizontalLine(pre, ' ');
                DrawHorizontalLine(1, c);
                DrawHorizontalLine(next, ' ');
                DrawHorizontalLine(1, c);
                Console.WriteLine();
                pre++;
                next--;
            }

            DrawHorizontalLine(1, c);
            DrawHorizontalLine(n - 2, ' ');
            Console.WriteLine(c);
        }

        static void DrawDownIsoscelesTriangle(int n, char c)
        {
            DrawHorizontalLine(2 * n - 1, c);
            Console.WriteLine();

            int pre = 1, cen = 2 * n - 5;
            for (int i = 1; i <= n - 2; i++)
            {
                DrawHorizontalLine(pre, ' ');
                DrawHorizontalLine(1, c);
                DrawHorizontalLine(cen, ' ');
                DrawHorizontalLine(1, c);
                Console.WriteLine();
                pre += 1;
                cen -= 2;
            }

            DrawHorizontalLine(n - 1, ' ');
            Console.WriteLine(c);
        }

    }
}
