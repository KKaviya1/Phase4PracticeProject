using SchoolData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SchoolDataTest
{
    [TestFixture]
    public class TeacherTest
    {
        [Test]
        public void Test_CreateTeacher()
        {
            // Arrange
            var teacher = new Teacher();
            teacher.TeacherId = 101;
            teacher.Name = "Mr. Krishna";

            // Act & Assert
            Assert.AreEqual(101, teacher.TeacherId);
            Assert.AreEqual("Mr. Krishna", teacher.Name);
        }
    }
}