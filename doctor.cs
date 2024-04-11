using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HosManage
{
    class doctor
    {
        private int DoctorID;
        private string FullName;
        private string Address;
        private DateTime DateOfBirth;
        private string PhoneNumber;

        public doctor()
        {
        }
        public doctor(int doctorID, string fullName, string address, DateTime dateOfBirth, string phoneNumber)
        {
            DoctorID = doctorID;
            FullName = fullName;
            Address = address;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
        }
        public int doctorID { get => DoctorID; set => DoctorID = value; }
        public string fullName { get => FullName; set => FullName = value; }
        public string address { get => Address; set => Address = value; }
        public DateTime dateOfBirth { get => DateOfBirth; set => DateOfBirth = value; }
        public string phoneNumber { get => PhoneNumber; set => PhoneNumber = value; }

    }
    
}
