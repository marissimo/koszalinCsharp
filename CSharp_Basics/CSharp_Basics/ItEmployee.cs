using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    public class ItEmployee :Employee
    {
        public ProgrammingLanguages ProgrammingLanguage { get; }

        public ItEmployee(string firstName, int stringID, string department, string programmingLanguage) : base (firstName,stringID, department)
        {
            this.ProgrammingLanguage = ProgrammingLanguage;

            //ProgrammingLanguages temp1;
            //Enum.TryParse(programmingLanguage, out temp1);
            //this.ProgrammingLanguage = temp1;
        }
        public ItEmployee(string firstName, int stringID, Locations department, string programmingLanguage) : base(firstName, stringID, department)
        {
            this.ProgrammingLanguage = ProgrammingLanguage;    
        }
        public ItEmployee(string firstName, int stringID, Locations department, ProgrammingLanguages ProgrammingLanguage) : base(firstName, stringID, department)
        {
            this.ProgrammingLanguage = ProgrammingLanguage;
        }
        public ItEmployee(string firstName, int stringID, string department, ProgrammingLanguages programmingLanguage) : base(firstName, stringID, department)
        {
            this.ProgrammingLanguage = ProgrammingLanguage;
        }
        public string ProgrammingString()
        {
            return ProgrammingLanguage.ToString();
        }

        public new string PrintEmployee()
        {
            return $"Name:{firstName} Badge:{stringID} Lang: {ProgrammingLanguage}";
        }
    }
}
