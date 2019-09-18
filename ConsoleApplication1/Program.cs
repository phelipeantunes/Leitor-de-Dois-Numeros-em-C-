using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.Write("\n valor de a?");
            a = int.Parse(Console.ReadLine());
            Console.Write("\n valor de b?");
            b = int.Parse(Console.ReadLine());

            if (a>b)
            Console.Write("\n O maior valor é:{0}",a);

            if (b>a)
            Console.Write("\n O menor valor é:{0}",b);

            if (a == b)
                Console.Write("\n são iguais");


            Console.ReadKey();
          
        }
    }
}
