﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<copyright file = "Utente.cs"	company = "IPCA">
///Copyright IPCA </copyright>
///<date>21-02-2020</date>
///<version>0.1</version>
///<author>Andre</author>

namespace Objects
{
    public class Utente : Pessoa
    {
        #region State Of Class
        /// <summary>
        /// Initializing attributes
        /// </summary>
        public int patientNumber;
        public string clinicalCase;
        public int levelOfUrgency;
        public int doctorCode;//Code of the doctor seeing to the patient
        public int nurseCode;
        public bool triageState;
        public bool seenByDoctor;

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
        /// <param name="pn"></param>
        /// <param name="cc"></param>
        /// <param name="dc"></param>
        /// <param name="nc"></param>
        /// <param name="ts"></param>
        /// <param name="sbd"></param>
        public Utente(int lou, int pn, string cc, int dc, int nc, bool ts, bool sbd)
        {
            levelOfUrgency = lou;
            patientNumber = pn;
            clinicalCase = cc;        
            doctorCode = dc;//Code of the doctor seeing to the patient
            nurseCode = nc;
            triageState = ts;
            seenByDoctor = sbd;
    }
        #endregion

        #region Methods

        #region Properties
        
        /// <summary>
        /// Gets Level of urgency for an Utente
        /// </summary>
        public int LevelOfUrgency
        {
            get { return levelOfUrgency; }
            set { levelOfUrgency = value; }
        }

        /// <summary>
        /// Gets patient number for an Utente
        /// </summary>
        public int PatientNumber
        {
            get { return patientNumber; }
            set { patientNumber = value; }
        }

        /// <summary>
        /// Gets Clinical case for an Utente
        /// </summary>
        public string ClinicalCase
        {
            get { return clinicalCase; }
            set { clinicalCase = value; }
        }

        /// <summary>
        /// Gets doctor code for an Utente
        /// </summary>
        public int DoctorCode
        {
            get { return doctorCode; }
            set { doctorCode = value; }
        }

        /// <summary>
        /// Gets nurse code for an Utente
        /// </summary>
        public int NurseCode
        {
            get { return nurseCode; }
            set { nurseCode = value; }
        }

        /// <summary>
        /// Gets triage state for an Utente
        /// </summary>
        public bool TriageState
        {
            get { return triageState; }
            set { triageState = value; }
        }

        /// <summary>
        /// Gets triage state for an Utente
        /// </summary>
        public bool SeenByDoctor
        {
            get { return seenByDoctor; }
            set { seenByDoctor = value; }
        }



        #endregion


        #endregion
        #endregion
    }
}
