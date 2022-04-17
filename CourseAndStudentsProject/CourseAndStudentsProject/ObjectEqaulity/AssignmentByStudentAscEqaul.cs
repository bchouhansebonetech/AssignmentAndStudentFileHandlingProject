using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseAndStudentsProject.DataModels;

namespace CourseAndStudentsProject.ObjectEqaulity
{
    public class AssignmentByStudentAscEqaul
    {
        public bool checkObjectsAreEqaulOrNot(AssignmentByStudentDO obj1, AssignmentByStudentDO obj2)
        {
            Console.WriteLine($"{obj1.noOfStudents} : {obj2.noOfStudents} , {obj1.assignmentName} : {obj2.assignmentName}");
            if (obj1 == null || obj2 == null)
            {
                if (obj1.noOfStudents == obj2.noOfStudents && obj1.assignmentName == obj2.assignmentName)
                    return true;
            }

            return false;
        }
    }
}
