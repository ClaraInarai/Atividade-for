using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._2__clara_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("informe um numero: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i += 2)
            {
                Console.WriteLine(i);

            }
          
            Console.ReadKey();
        }
    }
}
