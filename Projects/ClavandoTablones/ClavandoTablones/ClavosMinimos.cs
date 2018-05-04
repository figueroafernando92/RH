using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClavandoTablones
{
    class ClavosMinimos
    {
        public static int Solution(int[] A, int[] B, int N, int[] C, int M){

            int clavos = 0;
            int TablonesClavados = 0;

            string[] Tablon = new string[N];
            string[] Clavo = new string[M];

            for (int i = 0; i < M; i++) {

                for (int j = 0; j < N; j++)
                {
                    if (C[i] >= A[j] && C[i] <= B[j])
                    {


                        if (Tablon[j] != "Clavado")
                        {
                            Tablon[j] = "Clavado";
                            TablonesClavados++;
                        }

                        if (Clavo[i] != "Usado") {
                            clavos++;
                            Clavo[i] = "Usado";
                        }
                        


                    }

                    if (TablonesClavados == N) return clavos;




                }

            }




             return -1; 

        }

        
    }
}
