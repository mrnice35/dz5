using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите 7 чисел одномерного массива");
            int[] array = { a, b, c, d, e, f, j };
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());
            
            foreach (int A in array)
            {
                Console.WriteLine(A);
            }
            Console.ReadKey();

        }
        
    }
}
