using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_de_Repetição_e_Recursividade
{
    internal class SomatoriaDosNumeros
    {
        public static int somatoriaNum(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num + somatoriaNum(num - 1);
                
            }
        }
        /*static void Main(string[] args)
        {
            Console.WriteLine(somatoriaNum(5));
        }*/
    }
}
