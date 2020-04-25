using System;
using System.Collections.Generic;
using System.Text;

namespace Lp2_Trab
{
    class Sismo : Catastrofe
    {
        #region Atributos
        float magnitude;
        int replicas;
        #endregion

        #region Properties

        public float Magnitude
        {
            get { return magnitude; }
            set { magnitude = value; }
        }

        public int Replicas
        {
            get { return replicas; }
            set { replicas = value; }
        }

        #endregion

        #region CONSTRUTORES


        /// <summary>
        /// </summary>
        /// <param name="n">replicas</param>
        /// <param name="i">magnitude</param>
        public Sismo(int n, float i)
        {
            this.magnitude = i;
            this.replicas = n;
        }

        public float GetMagnitude()
        {
            return magnitude;
        }

        public int GetReplicas()
        {
            return replicas;
        }
        #endregion
    }
}
