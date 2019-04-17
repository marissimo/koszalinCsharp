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
            //this.ProgrammingLanguage = programmingLanguage;

            ProgrammingLanguages temp1;
            Enum.TryParse(programmingLanguage, out temp1);
            this.ProgrammingLanguage = temp1;
        }
        public ItEmployee(string firstName, int stringID, Locations department, string programmingLanguage) : base(firstName, stringID, department)
        {
            this.ProgrammingLanguage = ProgrammingLanguage;

      
        }
        public string ProgrammingString()
        {
            return ProgrammingLanguage.ToString();
        }
    }
}
