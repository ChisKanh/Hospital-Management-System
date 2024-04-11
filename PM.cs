using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HosManage
{
    class PM
    {
            
        private int PatientID;
        private string FullName;
        private string Address;
        private string NameOfMedicine;
        private string Amount;

        public PM()
        {
        }
        public PM(int patientID, string fullName, string address, string nameofmedicine, string amount)
        {
            PatientID = patientID;
            FullName = fullName;
            Address = address;
            NameOfMedicine = nameofmedicine;
            Amount = amount;
        }
        public int patientID { get => PatientID; set => PatientID = value; }
        public string fullName { get => FullName; set => FullName = value; }
        public string address { get => Address; set => Address = value; }
        public string nameofmedicine { get => NameOfMedicine; set => NameOfMedicine = value; }
        public string amount { get => Amount; set => Amount = value; }
    }
}
