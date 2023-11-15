using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_de_Repetição_e_Recursividade
{
    internal class Test
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num <= 10)
            {
                int i = 1;
                int x = num;
                
                while (i <= 10)
                {
                    int result = i * x;
                    Console.WriteLine($"{x} * {i} = {result}");
                    i++;
                    
                }
                Console.WriteLine("-------------------");
                num++;
            }
        }
    }
}
