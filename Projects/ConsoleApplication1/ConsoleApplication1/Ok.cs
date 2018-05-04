using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscandoAnagramas
{
    class Ok
    {
        public static int Solution(string A, string B)
        {

           string CadenaMayor = A.ToLower(); 
           string CadenaInterna = B.ToLower();


           int flagencontrado = 0;
           int anagramas = 0;
            if (CadenaMayor.Length >= CadenaInterna.Length)
            {
                char[] LetrasPalabraInterna = CadenaInterna.ToCharArray();
                char[] LetrasPalabraMayor = CadenaMayor.ToCharArray();
               


                for (int i = 0; i < CadenaMayor.Length; i++)
                {
                   flagencontrado = 0;

                      for (int j = 0; (j < CadenaInterna.Length) && (flagencontrado == 0); j++)
                      {



                          if ((LetrasPalabraMayor[i] == LetrasPalabraInterna[j]) && (i <= ((CadenaMayor.Length) - (CadenaInterna.Length))))
                          {
                              char[] LetrasAuxInterna = new char[CadenaInterna.Length];

                              for (int z = 0; z < CadenaInterna.Length; z++)
                              {
                                  LetrasAuxInterna[z] ='X';
                              }

                              int coincidencias = 0;
                              int vueltas = 1;
                              LetrasAuxInterna[j] = 'S';

                              int x = i+1;
                              while (vueltas < CadenaInterna.Length){


                              for (int y = 0; y < CadenaInterna.Length; y++)
                              {

                                  if (x  < CadenaMayor.Length) {
                                      if (LetrasPalabraMayor[x] == LetrasPalabraInterna[y] && LetrasAuxInterna[y] == 'X')
                                      {
                                          LetrasAuxInterna[y] = 'S';
                                          x++;
                                      }
                                    }

                              }

                                                 

                              vueltas++;
                          }

                              for (int z = 0 ;z < CadenaInterna.Length;z++){

                                  if (LetrasAuxInterna[z] == 'S')
                                  {
                                     coincidencias++;

                                   }

                              }

                              if (coincidencias == CadenaInterna.Length)
                              {
                              anagramas++;
                              flagencontrado = 1;
                              
                              }




                          }
                      






                      }



              

                



                  }
                return anagramas;
            }

            else { Console.WriteLine("ERROR: La cadena mayor tiene menor cantidad de caracteres que la cadena interna."); }



         
            Console.WriteLine("fin del programa");

            return anagramas;



        }


    }
}
