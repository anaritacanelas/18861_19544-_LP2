using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<copyright file = "Utentes.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>

namespace TP1LP2
{
    public class Utentes : Utente
    {
        /// <summary>
        /// Where utentes are stored
        /// </summary>
        Utente[] utentes = new Utente[10];

        #region Methods

        /// <summary>
        /// Defining Utentes
        /// </summary>
        void defineUtente()
        {
            //giving utente 1 variables
            utentes[0] = new Utente();
            //giving utente 2 variables
            utentes[1] = new Utente("utente 1", 30, 227890567, "male", 3);

            //setting variables for 3rd utente(Set)
            utentes[2].Name = "utente 3";
            utentes[2].Age = 45;

            //getting variables from 3rd utente(Get)
            Console.WriteLine("Name:{0}", utentes[2].Name);

            

        }
        
    /// <summary>
    /// Printing all utentes
    /// </summary>
        void showAllUtentes()
    {
        //Show all Utentes
        foreach (Utente u in utentes)
        {
            Console.WriteLine("Name: {0}\tAge: {1}\tNIF: {2}\tGender:{3}\tLevel Of urgency:{4}"
        , u.name, u.age, u.nif, u.gender, u.levelOfUrgency);
        }
    }
    #endregion

}
}
