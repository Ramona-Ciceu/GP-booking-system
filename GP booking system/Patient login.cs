using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GP_booking_system
{
    internal class Patient_login
    {
        //Attributes
        string mName;
        string mPassword;
        string mEmail;

        //Properties

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }
        public string Email { get; set; }



        //Constructors

        /// <summary>
        /// Creating first name and last name for the patient
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public Patient_login(string userName)
        {
           mName = userName;


        }
        /// <summary>
        /// Creating username and password for the patient
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="Password"></param>
        public Patient_login(string userName, string Password)
        {
            mName = userName;
            mPassword = Password;
            
        }

        /// <summary>
        /// Creats a password and Email for the patient
        /// </summary>
        /// <param name="Password"></param>
        /// <param name="Email"></param>
        public Patient_login(string userName, string Password, string Email) 
        { 
            mName=userName;
            mPassword = Password;   
            mEmail = Email;
        }


        //Methods

        /// <summary>
        /// Method to Authenticate patient
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
      /*  private bool AuthenticatePatient(string userName, string password)
        {
           for (int i = 0; i< Patient_login;i++)
            {
                if (Patient_login[i].Name == userName && Patient_login[i].Password==password)
                { return true; }

            }
            return false;
        }*/

    }
       

    
}
