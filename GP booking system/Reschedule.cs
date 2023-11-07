using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP_booking_system
{ 

    internal class Reschedule
    {
        //Attributes
        Patient_login mName;
        BookAnAppointment mTime, mDate;
        String newDate;
        String newTime;


        //Properties

        public Patient_login Name { get { return mName; } }

        public BookAnAppointment Time { get { return mTime; } }
        public BookAnAppointment Date { get { return mDate; } }

        public String bDate { get { return newDate; } set { newDate = value; } }

        public String bTime { get { return newTime; } set { newTime = value; } }

        //Constructors

        public Reschedule (Patient_login Name, String Date, String Time)

        {
            mName = Name;
            newDate = Date;
            newTime = Time; 
        }
        
        public Reschedule(Patient_login Name, String Date, String Time, BookAnAppointment dTime, BookAnAppointment dDate)

        {
            mName = Name;
            newDate = Date;
            newTime = Time;
            mTime = dTime;
            mDate = dDate;

        }

        public Reschedule(Patient_login Name, BookAnAppointment dTime, BookAnAppointment dDate)

        {

            this.mName = Name ;
            this.mTime = dTime;
            this.mDate = dDate;

        }


    }
}
