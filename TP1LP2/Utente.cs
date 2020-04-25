using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<copyright file = "Utente.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>

namespace TP1LP2
{
    public class Utente : Pessoa
    {
        #region State Of Class
        /// <summary>
        /// Initializing attributes
        /// </summary>
        
        protected float levelOfUrgency = 0;
        #endregion



        #region Behavior

        #region Builder

        /// <summary>
        /// Builder by omission
        /// </summary>
        public Utente()
        {
            
        }

        /// <summary>
        /// Creates a new Utente, taking parameters
        /// </summary>       
        /// <param name="lou"></param>
        /// <param name="n"></param>
        /// <param name="a"></param>
        /// <param name="ni"></param>
        /// <param name="gen"></param>
        public Utente(string n, int a, int ni, string gen, float lou)
        {
            name = n;
            age = a;
            nif = ni;
            gender = gen;
            levelOfUrgency = lou;
        }
        #endregion

        #region Methods

        #region Properties
               

        /// <summary>
        /// Gets Level of urgency for a Utente
        /// </summary>
        public float LevelOfUrgency//Ideia: fazer a media dos niveis de gravidade dos sintomas que o utente apresenta
        {
            get { return levelOfUrgency; }
            set { levelOfUrgency = value; }
        }

        #endregion


        #endregion
        #endregion
    }
}
