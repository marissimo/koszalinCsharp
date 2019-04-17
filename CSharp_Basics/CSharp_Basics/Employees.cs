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
        public void EmployeeData()
        {
            var employee1 = new Employee("Emka", 666, "Koszalin");
            var employee2 = new Employee("Bartek", 111, "Szczecin");
            var employee3 = new Employee("Aleksa", 444, "Wroclaw");
            var employee4 = new Employee("Marek", 333, "Koszalin");

            //employee1.firstName = "true";
            Assert.That(employee1.firstName, Is.EqualTo("Emka"));
            Assert.That(employee1.stringID, Is.EqualTo(666));
            Assert.That(employee1.LocationString, Is.EqualTo("Koszalin"));

            Assert.That(employee2.firstName, Is.EqualTo("Bartek"));
            Assert.That(employee2.stringID, Is.EqualTo(111));
            Assert.That(employee2.LocationString, Is.EqualTo("Szczecin"));

            Assert.That(employee3.firstName, Is.EqualTo("Aleksa"));
            Assert.That(employee3.stringID, Is.EqualTo(444));
            Assert.That(employee3.LocationString, Is.EqualTo("Wroclaw"));

            Assert.That(employee4.firstName, Is.EqualTo("Marek"));
            Assert.That(employee4.stringID, Is.EqualTo(333));
            Assert.That(employee4.LocationString, Is.EqualTo("Koszalin"));
        }
        [Test]
        public void EmployeeITData()
        {
            var employee1 = new ItEmployee("Marcin", 666, "Koszalin", "Csharp");
            var employee2 = new ItEmployee("Bartek", 111, "Szczecin", "Python");

            //employee1.firstName = "true";
            Assert.That(employee1.firstName, Is.EqualTo("Marcin"));
            Assert.That(employee1.stringID, Is.EqualTo(666));
            Assert.That(employee1.LocationString, Is.EqualTo("Koszalin"));
            Assert.That(employee1.ProgrammingString, Is.EqualTo("Csharp"));

            Assert.That(employee2.firstName, Is.EqualTo("Bartek"));
            Assert.That(employee2.stringID, Is.EqualTo(111));
            Assert.That(employee2.LocationString, Is.EqualTo("Szczecin"));
            Assert.That(employee2.ProgrammingString, Is.EqualTo("Python"));
        }
        [TestCase(Locations.Szczecin, true)]
        [TestCase(Locations.Koszalin, true)]
        [TestCase(Locations.Wroclaw, false)]
        [TestCase(Locations.Krakow, false)]
        [TestCase(Locations.ZielonaGora, false)]
        public void NortOrSouth(Locations loc, bool result)
        {
            var employee = new ItEmployee("Bartek", 111, loc, "Python");
            Assert.That(employee.IsNorthOfWarsaw, Is.EqualTo(result));
        }
    }
}
