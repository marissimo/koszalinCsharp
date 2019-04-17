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
        public string firstName
        { get; } //{ get; private set; }
        public int stringID
        { get; }
        public Locations department
        { get; }

        public Employee(string firstName, int stringID, string department)
        {

            this.firstName = firstName;
            this.stringID = stringID;
            Locations temp;
            Enum.TryParse(department, out temp);
            this.department = temp;


        }
        public Employee(string firstName, int stringID, Locations department)
        {

            this.firstName = firstName;
            this.stringID = stringID;
            this.department = department;


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

    }
    }
