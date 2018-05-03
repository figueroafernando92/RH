using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscandoAnagramas
{
    class Ok
    {
        public static int Solution(string CadenaMayor, string CadenaInterna)
        {

           int largomayor = CadenaMayor.Length;
           int largomenor = CadenaInterna.Length;

            if (CadenaMayor.Length >= CadenaInterna.Length)
            {
                char[] LetrasPalabraInterna = CadenaInterna.ToCharArray();
                char[] LetrasPalabraMayor = CadenaMayor.ToCharArray();



                for (int i = 0; i < CadenaInterna.Length; i++)
                  {

                      for (int j = 0; j < CadenaMayor.Length; j++)
                      {

                          if (LetrasPalabraInterna[i] == LetrasPalabraMayor[j])
                          {

                              int x = i+1;
                              int y = 0;
                              int cont = 0;
                              int anagramas = 0;



                              if (    LetrasPalabraInterna[x]    ){}
 
 


                          


                          }



                      }



              

                



                  }

            }

            else { Console.WriteLine("ERROR: La cadena mayor tiene menor cantidad de caracteres que la cadena interna."); }



         
            Console.WriteLine("fin del programa");

            return 0;



        }


    }
}
