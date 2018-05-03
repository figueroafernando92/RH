//+src=
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscandoAnagramas
{
    class Program
    {
        static void Main(string[] args)
        {
            string Cadena;
            string Subcadena;

           Cadena = Console.ReadLine();
           Subcadena = Console.ReadLine();
          
            Ok.Solution( Cadena,  Subcadena);

            Console.ReadLine();


             
        }
    }
}
