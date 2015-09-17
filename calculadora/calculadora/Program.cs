using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Console.ReadKey();
            int op;
            double x, y, z;
            double resta;
            Console.WriteLine("ingrese primer numero");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese segundo numero");
            y = double.Parse(Console.ReadLine());
            resta = x - y;
            double suma = x + y;
            do
            {
                Console.WriteLine("elija una operacion");
                Console.WriteLine("1 suma");
                Console.WriteLine("2 resta");
                Console.WriteLine("3 multiplicacion");
                Console.WriteLine("4 division");
                Console.WriteLine("5 potencia");
                Console.WriteLine("salir");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            Console.WriteLine("ingrese primer numero");
                            x=double.Parse(Console.ReadLine());
                            Console.WriteLine("ingrese segundo numero");
                            y = double.Parse(Console.ReadLine());
                            z = x + y;
                            Console.WriteLine("resultado "+ z);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("ingrese primer numero");
                            x = double.Parse(Console.ReadLine());
                            Console.WriteLine("ingrese segundo numero");
                            y = double.Parse(Console.ReadLine());
                            z = x - y;
                            Console.WriteLine("resultado " + z);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("ingrese primer numero");
                            x = double.Parse(Console.ReadLine());
                            Console.WriteLine("ingrese segundo numero");
                            y = double.Parse(Console.ReadLine());
                            z = x * y;
                            Console.WriteLine("resultado " + z);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("ingrese primer numero");
                            x = double.Parse(Console.ReadLine());
                            Console.WriteLine("ingrese segundo numero");
                            y = double.Parse(Console.ReadLine());
                            z = x / y;
                            Console.WriteLine("resultado " + z);
                            break;
                        }
                    case 5:
                        {

                            Console.WriteLine("ingrese primer numero");
                            x = double.Parse(Console.ReadLine());
                            Console.WriteLine("ingrese el exponente");
                            y = double.Parse(Console.ReadLine());
                            z = Math.Pow(x, y);
                            Console.WriteLine("resultado " + z);
                            break;
                        }
                }
            } while (op != 6);

        }
    }
}
