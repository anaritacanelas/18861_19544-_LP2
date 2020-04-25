using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<copyright file = "Pessoa.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>

namespace TP1LP2
{
    public class Pessoa
    {
        
        #region Class state
        /// <summary>
        /// Initializing attributes of Pessoa
        /// </summary>
        protected int age = 0;
        protected int nif = 0;
        protected string name;
        protected string gender;
        #endregion



        #region Behavior
        #region Builders
        /// <summary>
        /// Builder by omission
        /// </summary>
        public Pessoa()
        {

        }

        /// <summary>
        /// Builder of Pessoa
        /// </summary>
        /// <param name="n"></param>
        /// <param name="a"></param>
        /// <param name="ni"></param>
        /// <param name="gen"></param>
        public Pessoa(string n, int a, int ni, string gen)
        {
            name = n;
            age = a;
            nif = ni;
            gender = gen;
        }
        #endregion

        #region Methods
        #region Properties
        /// <summary>
        /// Property to manipulate name of Utente
        /// </summary>
        /// <returns></returns>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Property to manipulate age of Utente
        /// </summary>
        /// <returns></returns>
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        /// <summary>
        /// Property to manipulate gender of Utente
        /// </summary>
        /// <returns></returns>
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        /// <summary>
        /// Property to manipulate age of Utente
        /// </summary>
        /// <returns></returns>
        public int Nif
        {
            get { return nif; }
            set { nif = value; }
        }
        #endregion
        #endregion
        #endregion
    }
}
