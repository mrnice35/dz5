using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите N размерность двумерного массива NxN");
            int N = Convert.ToInt32(Console.ReadLine());
            int n = N;
            int m = N;
            int[,] t = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((i + j) % 2 == 1)
                    {

                        t[i, j] = 0;
                    }

                    else
                    {
                        t[i, j] = 1;
                    }
                    Console.Write("{0}", t[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
