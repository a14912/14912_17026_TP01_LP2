using System;
using System.Collections.Generic;
using System.Text;

namespace Lp2_Trab
{

    #region ENUM
    enum Risco
    {
        GRANDE = 100,
        MEDIO,
        BAIXO
    }
    #endregion
    class Catastrofe
    {
        #region Atributos

        string nome;
        string local;
        bool perdas;
        DateTime data;
        protected Risco risco;

        #endregion

        #region Properties

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Local
        {
            get { return local; }
            set { local = value; }
        }

        public bool Perdas
        {
            get { return perdas; }
            set { perdas = value; }
        }


        /// <summary>
        /// Data da Catastrofe
        /// </summary>
        public DateTime Data
        {
            get { return data; }
            set
            {
                DateTime aux;
                if (DateTime.TryParse(value.ToString(), out aux) == true)
                {
                    data = value;
                }
            }
        }   
        #endregion

        #region Construtores
        public Catastrofe(string n ,string m,Risco risco)
        {
            nome = n;
            local = m;
            perdas = true;
        }

        public Catastrofe(string n, string m)
        {
            nome = n;
            local = m;
            risco = Risco.GRANDE;
        }

        public Catastrofe()
        {

        }
        #endregion

        #region METODOS

        
        #region OVERRIDES

        public override string ToString()
        {
            return string.Format("Nome={0} local ={1} perdas={2}", nome, local, perdas);
        }

        #endregion

        #endregion
    }
}
