using System;

namespace Lp2_Trab
{
    class Program
    {
        static void Main(string[] args)
        {
            Catastrofe c1 = new Catastrofe("cat1", "lisboa", Risco.BAIXO);
            Incendio I1 = new Incendio(1, "aa", DateTime.Today, "Braga", Risco.MEDIO);

            Incendio[] incendios = new Incendio[2];
            
            Sismo s1 = new Sismo(20, 2);
            Sismo s2 = new Sismo(10, 7);

            s1.GetMagnitude();
            Console.WriteLine(s1.GetMagnitude());

            s2.GetReplicas();
            Console.WriteLine(s2.GetReplicas());

            //Mostrar todos os Incendios
            Console.WriteLine("INCENDIOS");
            foreach (Incendio s in incendios)
            {
                Console.WriteLine("NumERO:{0} \t Nome: {1}", s.numIncendio.ToString(), s.Nome);
            }

            //Maior Incendio
            int maiorIncendio = incendios[0].numIncendio;
            string nomeIncendio = incendios[0].Nome;
            int kk = 1;
            while (kk < incendios.Length)
            {
                if (incendios[kk].numIncendio > maiorIncendio)  
                {
                    maiorIncendio = incendios[kk].numIncendio;
                    nomeIncendio = incendios[kk].Nome;
                }
                kk++;
            }

            Console.WriteLine("Maior Incendio={0} - Nome do Incendio: {1}", maiorIncendio, nomeIncendio);

            //Qual Incendio
            
            for (int i = 0; i < incendios.Length; i++)
            {
                if (incendios[i].numIncendio == maiorIncendio)
                {
                    Console.WriteLine("Maior Incendio={0}", incendios[i].Nome);
                    break;
                    //return;
                }
            }

            Console.ReadKey();
        }



    }
}
