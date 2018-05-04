using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClavandoTablones
{
    class Ejercicio1
    {
        static void Main ( string[] args)
        {

           /* int n = 4;

            int[] a = new int[] {1,4,5,8};

            int[] b = new int[] { 4, 5, 9, 10 };
           
            int m = 5;

            int[] c = new int[] { 4,6, 7, 10 , 2};*/

            
            int n =0;

            while (n < 1 || n > 30000 ) {

                Console.WriteLine("\nIngrese la cantidad de Tablones (N):");
                n = Int32.Parse(Console.ReadLine());
                if (n < 1 || n > 30000)
                    Console.WriteLine("\n\nERROR: El numero debe ser superior a 1 e inferior a 30000. Intente nuevamente.");
            
            }
            int m = 0;

            while (m < 1 || m > 30000)
            {

                Console.WriteLine("\nIngrese la cantidad de Clavos (M):");
                m = Int32.Parse(Console.ReadLine());
                if (m < 1 || m > 30000)
                    Console.WriteLine("\n\nERROR: El numero debe ser superior a 1 e inferior a 30000. Intente nuevamente.");

            }



            int[] a = new int[n];
            Console.WriteLine("\n\nBien. Ingrese los valores de A["+n+"]:");
            for (int i =0 ; i<n ; i++) { 
            
                Console.WriteLine("\nA["+i+"]:");
                a[i]=Int32.Parse(Console.ReadLine());
                
            }


            int[] b = new int[n];
            Console.WriteLine("\n\nBien. Ingrese los valores de B[" + n + "]:");
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("\nB[" + i + "]:");
                b[i] = Int32.Parse(Console.ReadLine());

            }


            int[] c = new int[m];
            Console.WriteLine("\n\nBien. Ingrese los valores de C[" + m + "]:");
            for (int i = 0; i < m; i++)
            {

                Console.WriteLine("\nC[" + i + "]:");
                c[i] = Int32.Parse(Console.ReadLine());

            }


            Console.WriteLine("\n\nEl numero minimo de clavos es " + ClavosMinimos.Solution(a, b, n, c, m));

            Console.WriteLine("\n\n\n\n\n\nFin del programa");
            Console.ReadLine();




        }
    }
}
