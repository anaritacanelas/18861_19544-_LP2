using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<copyright file = "Medico.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>

namespace Objects
{
    /// <summary>
    /// Doctor class
    /// </summary>
    class Medico : Pessoa
    {
        #region Class stats
        public int doctorCode;
        public string specialty;
        #endregion

        #region Behaviour

        #region Builders
        /// <summary>
        /// Builder by omission for medico
        /// </summary>
        public Medico()
        {

        }

        /// <summary>
        /// Builder for medico
        /// </summary>
        /// <param name="nc"></param>
        /// <param name="spec"></param>
        public Medico(int dc, string spec)
        {
            doctorCode = dc;
            specialty = spec;
        }

        #endregion

        #region Methods


        #region Properties

        /// <summary>
        /// Getting nurse code for enfermeiro
        /// </summary>
        public int DoctorCode
        {
            get { return doctorCode; }
            set { doctorCode = value; }
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
