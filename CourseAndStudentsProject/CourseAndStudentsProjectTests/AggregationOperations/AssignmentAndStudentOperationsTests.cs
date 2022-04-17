using Microsoft.VisualStudio.TestTools.UnitTesting;
using CourseAndStudentsProject.AggregationOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseAndStudentsProject.DataModels;
using CourseAndStudentsProject.DummyData;

namespace CourseAndStudentsProject.AggregationOperations.Tests
{
    [TestClass()]
    public class AssignmentAndStudentOperationsTests
    {
        [TestMethod()]
        public void getAssignmetByStatusTest()
        {
            //Arrange
            AssignmentByStatusDummyData assignmentByStatusDummyData = new AssignmentByStatusDummyData();
            StudentDummyData studentDummyData = new StudentDummyData();

            List<StudentDataDO> studentData = studentDummyData.GetStudentDataDOs();
            List<AssignmentByStatusDO> assignmentByStatus1 = assignmentByStatusDummyData.GetAssignmentByStatusDOs();

            //Act
            AssignmentAndStudentOperations assignmentAndStudentOperations = new AssignmentAndStudentOperations();
            List<AssignmentByStatusDO> assignmentByStatus2 = assignmentAndStudentOperations.getAssignmetByStatus(studentData);

            //Assert
            for (int iterator = 0; iterator < assignmentByStatus2.Count; iterator++)
            {
                AssignmentByStatusDO obj1 = assignmentByStatus1[iterator];
                AssignmentByStatusDO obj2 = assignmentByStatus2[iterator];

                Assert.AreEqual(obj1.assignmentName, obj2.assignmentName);
                Assert.AreEqual(obj1.assignmentStatus, obj2.assignmentStatus);
                Assert.AreEqual(obj1.totalCompletionDays, obj2.totalCompletionDays);
                Assert.AreEqual(obj1.noOfStudents, obj2.noOfStudents);
            }
        }

        [TestMethod()]
        public void getAssignmentByStudentCountAscTest()
        {
            //Arrange
            AssignmentByStudentAscDummyData assignmentByStudentAscDummyData = new AssignmentByStudentAscDummyData();
            StudentDummyData studentDummyData = new StudentDummyData();

            List<StudentDataDO> students = studentDummyData.GetStudentDataDOs();   
            List<AssignmentByStudentDO> assignmentByStudentAscDOs1 = assignmentByStudentAscDummyData.GetAssignmentByStudentAscDOs();

            //Act
            AssignmentAndStudentOperations assignmentAndStudentOperations = new AssignmentAndStudentOperations();
            List<AssignmentByStudentDO> assignmentByStudentAscDOs2 = assignmentAndStudentOperations.getAssignmentByStudentCountAsc(students);

            //Assert
            for(int iterator = 0; iterator < assignmentByStudentAscDOs1.Count; iterator++)
            {
                AssignmentByStudentDO obj1 = assignmentByStudentAscDOs1[iterator];
                AssignmentByStudentDO obj2 = assignmentByStudentAscDOs2[iterator];

                Assert.AreEqual(obj1.assignmentName, obj2.assignmentName);
                Assert.AreEqual(obj1.noOfStudents, obj2.noOfStudents);
            }
        }

        [TestMethod()]
        public void getStudentsByAssignmentAndDaysCountTest()
        {
            //Arrange
            AssignmentCountByNameAndDaysDummyData assignmentCountByNameAndDaysDummyData = new AssignmentCountByNameAndDaysDummyData();
            StudentDummyData studentDummyData = new StudentDummyData();

            List<StudentDataDO> students = studentDummyData.GetStudentDataDOs();
            List<AssignmentCountByNameAndDaysDO> assignmentCountByNameAndDaysDOs1 = assignmentCountByNameAndDaysDummyData.GetAssignmentCountByNameAndDaysDOs();

            //Act
            AssignmentAndStudentOperations assignmentAndStudentOperations = new AssignmentAndStudentOperations();
            List<AssignmentCountByNameAndDaysDO> assignmentCountByNameAndDaysDOs2 = assignmentAndStudentOperations.getStudentsByAssignmentAndDaysCount(students);

            //Assert
            for (int iterator = 0; iterator < assignmentCountByNameAndDaysDOs2.Count; iterator++)
            {
                AssignmentCountByNameAndDaysDO obj1 = assignmentCountByNameAndDaysDOs1[iterator];
                AssignmentCountByNameAndDaysDO obj2 = assignmentCountByNameAndDaysDOs2[iterator];

                Assert.AreEqual(obj1.studentId, obj2.studentId);
                Assert.AreEqual(obj1.studentName, obj2.studentName);
                Assert.AreEqual(obj1.assignmentCount, obj2.assignmentCount);
                Assert.AreEqual(obj1.completionDays, obj2.completionDays);
            }
        }
    }
}