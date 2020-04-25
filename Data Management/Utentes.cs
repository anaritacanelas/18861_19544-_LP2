using System;
using System.Collections.Generic;
using Objects;
///<copyright file = "Utentes.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>

namespace DataManagement
{
    public class Utentes
    {
        /// <summary>
        /// Where utentes are stored
        /// </summary>
        public static List<Utente> utentes = new List<Utente>();

        #region Methods

        /// <summary>
        /// Defining Utentes
        /// </summary>
        public void defineUtente()
        {           
                        
        }
        
    /// <summary>
    /// Printing all utentes
    /// </summary>
        public void showAllUtentes()
    {
        //Show all Utentes
        foreach (Utente u in utentes)
        {
            Console.WriteLine("Name: {0}\tBirthdate: {1}\tNHS Number: {2}\tGender:{3}\tLevel Of urgency:{4}"
        , u.name, u.birthDate, u.nhsNumber, u.gender, u.levelOfUrgency);
        }
    }
    #endregion

}
}
