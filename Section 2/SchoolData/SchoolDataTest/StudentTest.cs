using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolData;

namespace SchoolDataTest
{
    [TestFixture]
    public class StudentTest
    {
        [Test]
        public void TestStudentName()
        {
            // Arrange
            Student student = new Student();
            student.Name = "Viya";

            // Act
            string studentName = student.Name;

            // Assert
            Assert.AreEqual("Viya", studentName);
        }

        [Test]
        public void TestStudentAddress()
        {
            // Arrange
            Student student = new Student();
            student.Address = "10 Mission Street";

            // Act
            string studentAddress = student.Address;

            // Assert
            Assert.AreEqual("10 Mission Street", studentAddress);
        }
    }
}