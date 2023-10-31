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

        public string Name { get; set; }
        public string Password { get; set; }
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


    }
}
