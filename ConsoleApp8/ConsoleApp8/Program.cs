using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class complex
    {
        double a;
        double b;
        public complex(double _a=0, double _b=1)
        {
           
                a = _a;
                b = _b;
           
        }

       



        public static complex operator +(complex z1, complex z2)
        {
            return new complex(z1.a + z2.a, z1.b+z2.b);
        }

        public static complex operator -(complex z1, complex z2)
        {
            return new complex(z1.a - z2.a, z1.b - z2.b);
        }


        public static complex operator *(complex z1, complex z2)
        {
            return new complex((z1.a*z2.a- z1.b* z2.b),( z1.b*z2.a+z1.a*z2.b));
        }

        public static complex operator /(complex z1, complex z2)
        {
            if(z1.a==0 && z1.b == 0)
            {
                return new complex(0, 0);
            }
            if ((z2.a != 0) && (z2.b != 0))
            {
                return new complex(((z1.a * z2.a + z1.b * z2.b) / (z2.a * z2.a + z2.b * z2.b)),( (z1.b * z2.a - z1.a * z2.b) / (z2.a * z2.a + z2.b * z2.b)));
            }
            else
            {
                Console.WriteLine("Делитель не может равняться 0!!!! ");
                Console.WriteLine("Делитель заменен на 0+1і ");
                z2.b = 1;
                return new complex((z1.a * z2.a + z1.b * z2.b) / (z2.a * z2.a + z2.b * z2.b),( (z1.b * z2.a - z1.a * z2.b) / (z2.a * z2.a + z2.b * z2.b)));
            }
        }

        public override string ToString()
        {
            return $"{a} + {b}i ";
        }
    }





    class Program
    {

        class inputI
        {
            public complex INp()
            {
                Console.Write("Введите действительную часть=>_\b");
                string str = Console.ReadLine();
                double a1 = Convert.ToDouble(str);
                Console.Write("Введите мнимую часть=>_\b");
                string str1 = Console.ReadLine();
                double b1 = Convert.ToDouble(str1);
                complex s = new complex(a1, b1);
                return s;

            }

            public complex doo(complex a, complex b)
            {
                Console.WriteLine("Выберите действие: +, -, *, /_\b");
                char str = Convert.ToChar(Console.ReadLine());
                complex s;
                if (str == '+')
                {
                    s = a + b;
                    return s;
                }

                if (str == '-')
                {
                    s = a - b;
                    return s;
                }

                if (str == '*')
                {
                    s = a * b;
                    return s;
                }
                if (str == '/')
                {
                    s = a / b;
                    return s;
                }



                return null;

            }



        }

        static void Main(string[] args)
        {

            complex a;
            complex b;
            complex c;
            inputI s = new inputI();
           char i ='0';
            while (i=='0')
            {
                a = s.INp();
                b = s.INp();
                Console.WriteLine(a);
                Console.WriteLine(b);
                c = s.doo(a, b);
                Console.WriteLine(c);
                Console.WriteLine("Хотите продолжить? Hажмите 0  =>-\b");
                string str = Console.ReadLine();
                i = Convert.ToChar(str);
                Console.Clear();
            }
          
        }
    }
}
