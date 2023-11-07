using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GP_booking_system
{
    internal class Appointment
    {
        Patient_login mName;
        String mDate;
        String mTime;
        String mDoctor;

        #region Properties

        public Patient_login Name {  get { return mName; } }

        public String Date { get { return mDate; } set { mDate = value; } }

        public String Time { get { return mTime; } set { mTime = value; } }

        public String Doctor { get {  return mDoctor; } set { mDoctor = value; } }

        #endregion

        #region Constructors

        /// <summary>
        /// Creates an appointment for the patient with the date and time
        /// </summary>
        /// <param name="date"></param>
        /// <param name="time"></param>
        public Appointment(String date, String time)
        {
            mDate = date;
            mTime = time;
        }


        #endregion

        #region Methods

        public void ChangeAppointment()
        {

        }


        #endregion
    }


}
