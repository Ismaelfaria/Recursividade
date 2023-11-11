using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_de_Repetição_e_Recursividade
{
    internal class SomatoriaDosNumeros
    {
        public static int somatoriaNum(int fim)
        {
          
            if(fim > 1)
            {
                int resul = fim + somatoriaNum(fim - 1); 
                return resul;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            somatoriaNum( 5);
        }
    }
}
