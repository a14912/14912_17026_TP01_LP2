using System;
using System.Collections.Generic;
using System.Text;

namespace Lp2_Trab
{
    /// <summary>
    /// Incendio herda de Catrastrofe
    /// </summary
    class Incendio : Catastrofe
    {
        #region ATRI
        
        public int numIncendio;
        DateTime inicioIncendio;

        #endregion

        #region CONST


        public Incendio(int num, string nome, DateTime dn, string local, Risco tipo) : base(local, nome, tipo)
        {
            numIncendio = num;
            inicioIncendio = new DateTime(2020, 04, 20);
            
        }
        #endregion

        #region Metodos


        /// <summary>
        /// Quais os Incendios maiores que X
        /// </summary>
        /// <param name="incendio"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int[] ValIncendio(int[] incendio, int x)
        {
        
            int[] aux;
            int t = incendio.Length;

            //Conta Maiores
            int cont = 0;
            for (int i = 0; i < t; i++)
            {
                if (incendio[i] > x) cont++;

            }
            // Cria novo Array
            if (cont > 0)
            {
                aux = new int[cont];

                //Coloca os Valores no novo Array
                int j = 0;
                for (int i = 0; i < t; i++)
                {
                    if (incendio[i] > x)
                    {
                        aux[j] = incendio[i];
                        j++;
                    }

                }
                return aux;
            }
            return null;
        }


        /// <summary>
        /// Verifica se Existe Incendio
        /// </summary>
        /// <param name="valor">Valor a procurar</param>
        /// <param name="incendio">Array de valores</param>
        /// <param name="posicao">Posição onde se encontra</param>
        /// <returns></returns>
        public static bool ExisteIncendio(int valor, int[] incendio, out int posicao)
        {
            posicao = -1;

            for (int i = 0; i < incendio.Length; i++)
            {
                if (incendio[i] == valor)
                {
                    posicao = i;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Mostra os incendios
        /// </summary>
        /// <param name="incendios"></param>
        public static void MostraIncendio(int[] incendios)
        {
            foreach (int i in incendios)
            {
                Console.WriteLine("Incendios: " + i);
            }
        }
        #endregion
    }


}

