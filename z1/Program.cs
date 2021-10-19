using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите 7 чисел одномерного массива");
            const int n = 7;
            int[] array = new int[n];
            array[0]= Convert.ToInt32(Console.ReadLine());
            array[1] = Convert.ToInt32(Console.ReadLine());
            array[2] = Convert.ToInt32(Console.ReadLine());
            array[3] = Convert.ToInt32(Console.ReadLine());
            array[4] = Convert.ToInt32(Console.ReadLine());
            array[5] = Convert.ToInt32(Console.ReadLine());
            array[6] = Convert.ToInt32(Console.ReadLine());
            float S = 0;
            for (int i = 0; i < 7; i++)
            {
               
                S += array[i];
               
            }
            Console.WriteLine();
            Console.WriteLine(S/n);
            Console.ReadKey();

        }
    }
}
