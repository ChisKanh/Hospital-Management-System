using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HosManage
{
    class patient
    {
        private int PatientID;
        private string FullName;
        private string Address;
        private DateTime DateOfBirth;
        private string PhoneNumber;

        public patient()
        {
        }

        public patient(int patientID, string fullName, string address, DateTime dateOfBirth, string phoneNumber)
        {
            PatientID = patientID;
            FullName = fullName;
            Address = address;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
        }
        public int patientID { get => PatientID; set => PatientID = value; }
        public string fullName { get => FullName; set => FullName = value; }
        public string address { get => Address; set => Address = value; }
        public DateTime dateOfBirth { get => DateOfBirth; set => DateOfBirth = value; }
        public string phoneNumber { get => PhoneNumber; set => PhoneNumber = value; }
       
    }
}
