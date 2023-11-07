using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GP_booking_system
{

    internal class Doctors
    {
        //Atrributes
        String name;
        String speciality;
        String gender;


        //Properties
        public String Name
        {
            get { return name; }
            
            set { Name = value; }
        }

        public String Speciality
        {
            get { return speciality; }
            set { Speciality = value; }
        }

        public String Gender
        {
            get { return gender; }
            set { Gender = value; }
        }


        //Constructors
        /// <summary>
        /// Stores Name and Speciality of the doctor
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Speciality"></param>
        public Doctors( String Name, String Speciality)
        {
            name=Name;
            speciality=Speciality;
        }
        /// <summary>
        /// Stores Name, Speciality and Gendre of the doctor
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Speciality"></param>
        /// <param name="Gender"></param>
        public Doctors(String Name, String Speciality, String Gender)
        {
            name = Name;
            speciality = Speciality;    
            gender = Gender;    
        }

    }
}
