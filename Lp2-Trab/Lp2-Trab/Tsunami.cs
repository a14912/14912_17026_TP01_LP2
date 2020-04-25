using System;
using System.Collections.Generic;
using System.Text;

namespace Lp2_Trab
{
     class Tsunami : Catastrofe
    {
        #region Atributos

        string epicentro;
        Tsunami[] total;
        int totalvitimas;

        #endregion

        #region Properties
        public string Epicentro
        {
            get { return epicentro; }
            set { epicentro = value; }
        }

        public int Totalvitimas
        {
            get { return totalvitimas; }
            set { totalvitimas = value; }
        }

        #endregion

        #region Construtores
        public Tsunami(string m)
        {
            epicentro = m;
        }

        #endregion

        #region Overrides

        public override string ToString()
        {
            return "Epicentro: " + epicentro;
        }


        /// <summary>
        /// Compara dois Tsunamis
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Tsunami aux = (Tsunami)obj;
            return (String.Compare(aux.epicentro, this.epicentro) == 0);
        }
        #endregion

    }
}
