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
            float x, y, z;
            do
            {
                Console.WriteLine("elija una operacion");
                Console.WriteLine("1 suma");
                Console.WriteLine("2 resta");
                Console.WriteLine("3 multiplicacion");
                Console.WriteLine("4 division");
                Console.WriteLine("salir");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
 
                }
            } while (op != 5);

        }
    }
}
