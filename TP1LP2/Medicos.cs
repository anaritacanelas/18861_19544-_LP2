using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<copyright file = "Medicos.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>

namespace TP1LP2
{
    class Medicos : Pessoa
    {
        /// <summary>
        /// Gets doctors that aren't busy
        /// </summary>
        /// <returns></returns>
        int getAvaliableDoctors()
        {
            int avaliableDoctors = 3;
            return avaliableDoctors;
        }
    }
}
