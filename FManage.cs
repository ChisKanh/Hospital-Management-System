using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HosManage
{
    class FManage
    {
        private int ManagerID;
        private string FullName;
        private string Address;
        private DateTime DateOfBirth;
        private string PhoneNumber;

        public FManage()
        {
        }
        public FManage(int managerID, string fullName, string address, DateTime dateOfBirth, string phoneNumber)
        {
            ManagerID = managerID;
            FullName = fullName;
            Address = address;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
        }
        public int managerID { get => ManagerID; set => ManagerID = value; }
        public string fullName { get => FullName; set => FullName = value; }
        public string address { get => Address; set => Address = value; }
        public DateTime dateOfBirth { get => DateOfBirth; set => DateOfBirth = value; }
        public string phoneNumber { get => PhoneNumber; set => PhoneNumber = value; }
    }
}
