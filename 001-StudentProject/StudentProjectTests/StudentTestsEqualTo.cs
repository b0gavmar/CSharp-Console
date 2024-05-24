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
    public class StudentTestsEqualTo
    {
        [TestMethod()]
        public void EqualToTestDifferentName()
        {
            //arrange
            Student adel = new Student
            {
                Name = "Kis Adél",
                Age = 17,
            };
            Student jani = new Student
            {
                Name = "Kis János",
                Age = 17,
            };

            //act
            bool actual = adel.EqualTo(jani);

            //assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void EqualToTestDifferentAge()
        {
            Student adel = new Student
            {
                Name = "Kis Adél",
                Age = 17,
            };
            Student jani = new Student
            {
                Name = "Kis Adél",
                Age = 18,
            };

            bool actual = adel.EqualTo(jani);

            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void EqualToTestAllPropertyDifferent()
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

            bool actual = adel.EqualTo(jani);

            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void EqualToTestSameStudent()
        {
            Student adel = new Student
            {
                Name = "Kis Adél",
                Age = 17,
            };
            Student jani = new Student
            {
                Name = "Kis Adél",
                Age = 17,
            };

            bool actual = adel.EqualTo(jani);

            Assert.IsTrue(actual);
        }

    }
}