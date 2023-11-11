using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_de_Repetição_e_Recursividade
{
    internal class Tabuada
    {
        public static void tabuad(int nummm)
        {

            if (nummm == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine($"tabuada de {nummm}");
                for (int i = 1; i < 10; i++)
                { 
                    Console.WriteLine(nummm * i);
                }
                if(nummm < 10) { 
                tabuad(nummm+1);
                }
            }
        }
        /*static void Main(string[] args)
        {
            tabuad(5);
        }*/
    }

}




