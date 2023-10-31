using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP_booking_system
{
    internal class Appointment
    {
        Patient_login mName;
        string mDate;
        String mTime;
        String mDoctor;

        #region Properties

        public Patient_login Name {  get { return mName; } }

        public String Date { get { return mDate; } set { mDate = value; } }

        public String Time { get { return mTime; } set { mTime = value; } }

        public String Doctor { get {  return mDoctor; } set { mDoctor = value; } }

        #endregion

        #region Constructors

        
        public Appointment(String date, String time)
        {
           mDate = date;
           mTime = time;

        }


        #endregion
    }
}
