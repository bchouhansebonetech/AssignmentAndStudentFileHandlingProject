using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseAndStudentsProject.DummyData;
using CourseAndStudentsProject.AggregationOperations;

namespace CourseAndStudentsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentDummyData studentDummyData = new StudentDummyData();
            var studentList = studentDummyData.GetStudentDataDOs();

            AssignmentAndStudentOperations assignmentAndStudentOperations = new AssignmentAndStudentOperations();
            var studentAsc = assignmentAndStudentOperations.getAssignmentByStudentCountAsc(studentList); 

            foreach (var student in studentAsc)
            {
                Console.WriteLine($"{student.assignmentName} - {student.noOfStudents}");
            }

            //Console.WriteLine("*****************************************************************************");

            //var studentAndAssignmentCount = assignmentAndStudentOperations.getStudentsByAssignmentAndDaysCount(studentList);

            //foreach(var student in studentAndAssignmentCount)
            //{
            //    Console.WriteLine($"{student.studentId} - {student.studentName} - {student.assignmentCount} - {student.completionDays}");
            //}
            //Console.WriteLine("*****************************************************************************");

            //var studentAssignmentByStatus = assignmentAndStudentOperations.getAssignmetByStatusDirty(studentList);

            //foreach(var assignment in studentAssignmentByStatus)
            //{
            //    Console.WriteLine($"{assignment.assignmentName} - {assignment.noOfStudents} - {assignment.totalCompletionDays} - {assignment.assignmentStatus}");
            //}
            //Console.WriteLine("*****************************************************************************");

            //var studentAssignmentByStatus1 = assignmentAndStudentOperations.getAssignmetByStatus(studentList);

            //foreach (var assignment in studentAssignmentByStatus1)
            //{
            //    Console.WriteLine($"{assignment.assignmentName} - {assignment.noOfStudents} - {assignment.totalCompletionDays} - {assignment.assignmentStatus}");
            //}
        }
    }
}
