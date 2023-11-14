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
        Doctors mName;
        String mDate;
        String mTime;
        String mDoctor;

        #region Properties

        public Doctors Name {  get { return mName; } }

        public String Date { get { return mDate; } set { mDate = value; } }

        public String Time { get { return mTime; } set { mTime = value; } }

        public String Doctor { get {  return mDoctor; } set { mDoctor = value; } }

        #endregion

        #region Constructors

        /// <summary>
        /// Creates an appointment for the patient with specified date and time
        /// </summary>
        /// <param name="date"></param>
        /// <param name="time"></param>
        public Appointment(String date, String time)
        {
            mDate = date;
            mTime = time;
        }
        /// <summary>
        /// Creates an appointment for the patient with specified date, time and doctor.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="time"></param>
        /// <param name="doctor"></param>
        public Appointment(String date, String time, Doctors doctor)
        {
            mDate = date;
            mTime = time;
            mName = doctor;
        }


        #endregion

        #region Methods

        public void ChangeAppointment()
        {

        }


        #endregion
    }


}
