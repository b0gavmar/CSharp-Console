using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject.Tests
{
    [TestClass()]
    public class StudentExtensionTests
    {
        [TestMethod()]
        public void IsYoungerTestFirstIsYounger()
        {
            Student adel = new Student
            {
                Name = "Kis Adél",
                Age = 17,
            };
            Student jani = new Student
            {
                Name = "Kis János",
                Age = 18,
            };

            bool actual = adel.IsYounger(jani);

            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsYoungerTestSecondIsYounger()
        {
            Student adel = new Student
            {
                Name = "Kis Adél",
                Age = 17,
            };
            Student jani = new Student
            {
                Name = "Kis János",
                Age = 15,
            };

            bool actual = adel.IsYounger(jani);

            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void IsYoungerTestSameAge()
        {
            Student adel = new Student
            {
                Name = "Kis Adél",
                Age = 18,
            };
            Student jani = new Student
            {
                Name = "Kis János",
                Age = 18,
            };

            bool actual = adel.IsYounger(jani);

            Assert.IsFalse(actual);
        }

    }
}