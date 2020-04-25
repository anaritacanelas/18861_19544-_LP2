///<copyright file = "Urgencia.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>

namespace Objects
{
    public class Urgencia
    {


        #region Behavior
        /// <summary>
        /// Find highest level of urgency
        /// </summary>
        void findHighestUrgency()
        {
            int highestLevelOfUrgency = utente[0].levelOfUrgency;
            int iLevel = 1;
            while (iLevel < utentes.Length)
            {
                if (highestLevelOfUrgency < utentes[iLevel].levelOfUrgency)
                {
                    highestLevelOfUrgency = utentes[iLevel].levelOfUrgency;
                }
            }
        }


        #region Builders
        /// <summary>
        /// Builder by omission
        /// </summary>
        public Urgencia()
        {

        }

        
        #endregion
        #endregion
    }
}
