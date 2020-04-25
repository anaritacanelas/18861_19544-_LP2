﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<copyright file = "Enfermeiro.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>

namespace Objects
{
    /// <summary>
    /// Nurse class
    /// </summary>
    class Enfermeiro : Pessoa
    {
        #region Class stats
        public int nurseCode;
        public string specialty;        
        #endregion

        #region Behaviour

        #region Builders
        /// <summary>
        /// Builder by omission for enfermeiro
        /// </summary>
        public Enfermeiro()
        {

        }

        /// <summary>
        /// Builder for enfermeiro
        /// </summary>
        /// <param name="nc"></param>
        /// <param name="spec"></param>
        public Enfermeiro(int nc, string spec)
        {
            nurseCode = nc;
            specialty = spec;
        }

        #endregion

        #region Methods


        #region Properties

        /// <summary>
        /// Getting nurse code for enfermeiro
        /// </summary>
        public int NurseCode
        {
            get { return nurseCode; }
            set { nurseCode = value;}
        }

        /// <summary>
        /// Getting nurse code for enfermeiro
        /// </summary>
        public string Specialty
        {
            get { return specialty; }
            set { specialty = value; }
        }

        #endregion
        #endregion
        #endregion
    }
}
