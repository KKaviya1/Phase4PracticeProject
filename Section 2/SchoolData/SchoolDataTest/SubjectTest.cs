using SchoolData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDataTest
{
    [TestFixture]
    public class SubjectTest
    {
        [Test]
        public void TestSubjectName()
        {
            // Arrange
            Subject subject = new Subject();
            subject.Name = "English";

            // Act
            string subjectName = subject.Name;

            // Assert
            Assert.AreEqual("English", subjectName);
        }

        [Test]
        public void TestSubjectId()
        {
            // Arrange
            Subject subject = new Subject();
            subject.Id = 3;

            // Act
            int subjectId = subject.Id;

            // Assert
            Assert.AreEqual(3, subjectId);
        }
      
       
    }
}