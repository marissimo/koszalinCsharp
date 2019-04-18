using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp_Basics
{
    [TestFixture]
    public class Employee
    {
        //klasa pokazujaca imie, oddział i numer ID
        public string firstName { get; } //{ get; private set; }
        public int stringID { get; }
        public Locations department { get; }

        public Employee(string firstName, int stringID, string department)
        {
           
            this.firstName = firstName;
            this.stringID = stringID;
            Locations temp;
            Enum.TryParse(department, out temp);
            this.department = temp;
            ValidateIdNumber();

        }
        public Employee(string firstName, int stringID, Locations department)
        {

            this.firstName = firstName;
            this.stringID = stringID;
            this.department = department;
            ValidateIdNumber();
        }
        private void ValidateIdNumber()
            {
            if(stringID < 10000 || stringID > 99999)
            {
                throw new ArgumentOutOfRangeException("Badge should have 5 digits");
            }
            if (IsNorthOfWarsaw() && stringID >= 60000)
            {
                return;
            }

            if (!IsNorthOfWarsaw() && stringID < 60000)
            {
                return;
            }
            throw new ArgumentOutOfRangeException("Bagde is from wrong region");
        }

        
        public string LocationString ()
        {
            return department.ToString();
        }

        public bool IsNorthOfWarsaw()
        {
            if (department == Locations.Koszalin || department==Locations.Szczecin)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public string PrintEmployee()
        {
            return $"Name:{firstName} Badge:{stringID}";
        }
    }
}
