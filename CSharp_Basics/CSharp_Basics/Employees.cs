using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp_Basics
{
    [TestFixture]
    class Employees
    {
        [Test]
        public void Test()
        {
            Console.WriteLine("Just test");
        }

        [Test]
        public void EmployeeData()
        {
            var employee1 = new Employee("Emka", 66666, Locations.Koszalin);
            var employee2 = new Employee("Bartek", 61111, Locations.Szczecin);
            var employee3 = new Employee("Aleksa", 14444, Locations.Wroclaw);
            var employee4 = new Employee("Marek", 63333, Locations.Koszalin);

            //employee1.firstName = "true";
            Assert.That(employee1.firstName, Is.EqualTo("Emka"));
            Assert.That(employee1.stringID, Is.EqualTo(66666));
            Assert.That(employee1.LocationString, Is.EqualTo("Koszalin"));

            Assert.That(employee2.firstName, Is.EqualTo("Bartek"));
            Assert.That(employee2.stringID, Is.EqualTo(61111));
            Assert.That(employee2.LocationString, Is.EqualTo("Szczecin"));

            Assert.That(employee3.firstName, Is.EqualTo("Aleksa"));
            Assert.That(employee3.stringID, Is.EqualTo(14444));
            Assert.That(employee3.LocationString, Is.EqualTo("Wroclaw"));

            Assert.That(employee4.firstName, Is.EqualTo("Marek"));
            Assert.That(employee4.stringID, Is.EqualTo(63333));
            Assert.That(employee4.LocationString, Is.EqualTo("Koszalin"));
        }
        [Test]
        public void EmployeeITData()
        {
            var employee1 = new ItEmployee("Marcin", 66666, Locations.Koszalin, ProgrammingLanguages.Csharp);
            var employee2 = new ItEmployee("Bartek", 61111, Locations.Szczecin, ProgrammingLanguages.Python);

            //employee1.firstName = "true";
            Assert.That(employee1.firstName, Is.EqualTo("Marcin"));
            Assert.That(employee1.stringID, Is.EqualTo(66666));
            Assert.That(employee1.LocationString, Is.EqualTo("Koszalin"));
            Assert.That(employee1.ProgrammingString, Is.EqualTo("Csharp"));

            Assert.That(employee2.firstName, Is.EqualTo("Bartek"));
            Assert.That(employee2.stringID, Is.EqualTo(61111));
            Assert.That(employee2.LocationString, Is.EqualTo("Szczecin"));
            Assert.That(employee2.ProgrammingString, Is.EqualTo("Python")); //Here is something wrong!!!! I have Python but it passes when I have Csharp? why?
        }
        [TestCase(Locations.Szczecin, true)]
        [TestCase(Locations.Koszalin, true)]
        [TestCase(Locations.Wroclaw, false)]
        [TestCase(Locations.Krakow, false)]
        [TestCase(Locations.ZielonaGora, false)]
        public void NorthOrSouth(Locations loc, bool result)
        {
            var employee = new ItEmployee("Bartek", 11111, loc, "Python");
            Assert.That(employee.IsNorthOfWarsaw, Is.EqualTo(result));
        }

        //throw new ArgumentOutOfRangeException();
        [Test]
        public void Employe_isOutOfRange()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new ItEmployee("Bartek",11111,Locations.Szczecin,"Python"));


        }

        [TestCase(Locations.Koszalin, 11111)]
        [TestCase(Locations.ZielonaGora, 66666)]
        public void Employe_IDisInWrongRange_ThrowsArgrumentOutOfRange(Locations loc, int badge)
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => new Employee("Bartek", badge, loc)
            );
        }

        [Test]

        public void Example()
        {
            var employee1 = new ItEmployee("Emka", 66666, Locations.Koszalin, ProgrammingLanguages.Csharp);
            var employee2 = new Employee("Bartek", 61111, Locations.Szczecin);
            Console.WriteLine(employee1.PrintEmployee());
            Console.WriteLine(employee2.PrintEmployee());

        }
    }
}
