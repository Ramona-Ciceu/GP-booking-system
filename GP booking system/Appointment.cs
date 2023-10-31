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
        DateTime mDate;
        DateTime mTime;
        String mDoctor;

        #region Properties

        public Patient_login Name {  get { return mName; } }

        public DateTime Date { get { return mDate; } set { mDate = value; } }

        public DateTime Time { get { return mTime; } set { mTime = value; } }

        public String Doctor { get {  return mDoctor; } set { mDoctor = value; } }

        #endregion

        #region Constructors

        
        public Appointment(DateTime date, DateTime time)
        {
           mDate = date;
           mTime = time;

        }


        #endregion
    }
}
