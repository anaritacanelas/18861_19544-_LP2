using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<copyright file = "ProfissionalDeSaude.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>

namespace TP1LP2
{
    class ProfissionalDeSaude : Pessoa
    {
        #region Class state
        int hospitalId = 0;//Hospital identification
        bool avaliable;//If doctor/nurse is avaliable to see a patient or not
        #endregion

        #region Behavior

        #region Builders

        /// <summary>
        /// Builder by omission
        /// </summary>
        public ProfissionalDeSaude()
        {

        }

        /// <summary>
        /// Builder for Prosissional de Saude, taking parameters for hospital ID and avaliability(boolean)
        /// </summary>
        /// <param name="hId"></param>
        /// <param name="av"></param>
        public ProfissionalDeSaude(int hId, bool av)
        {
            hospitalId = hId;
            avaliable = av;
        }

        #endregion

        #endregion
    }
}
