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
            int num = 0;
      /*   Cadena = Console.ReadLine();
           Subcadena = Console.ReadLine();*/
       /*     Cadena = "MalanesaMuyricama";
          Subcadena = "am";*/
           Cadena = "hola, que buena ola Laomir";
           Subcadena = "oal";


           num = Ok.Solution(Cadena, Subcadena);

            Console.WriteLine("Se encontraron " + num + " anagramas");


            Console.ReadLine();
        }
    }
}
