using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseAndStudentsProject.DataModels;

namespace CourseAndStudentsProject.DummyData
{
    public class StudentDummyData
    {
        public List<StudentDataDO> GetStudentDataDOs()
        {
            List<StudentDataDO> students = new List<StudentDataDO>();

            StudentDataDO student1 = new StudentDataDO(101, "Bhanu", "Java", "Complete", 5);
            students.Add(student1);
            StudentDataDO student2 = new StudentDataDO(102, "Bhavna", "Java", "Progress", 3);
            students.Add(student2);
            StudentDataDO student3 = new StudentDataDO(103, "Sajal", "C#", "Complete", 5);
            students.Add(student3);
            StudentDataDO student4 = new StudentDataDO(101, "Bhanu", "Unittest", "NotDone", 0);
            students.Add(student4);
            StudentDataDO student5 = new StudentDataDO(105, "Ritika", "Java", "NotDone", 0);
            students.Add(student5);
            StudentDataDO student6 = new StudentDataDO(106, "Utkarsh", "Web", "Progress", 4);
            students.Add(student6);
            StudentDataDO student7 = new StudentDataDO(105, "Ritika", "Web", "Complete", 6);
            students.Add(student7);
            StudentDataDO student8 = new StudentDataDO(106, "Utkarsh", "Java", "Complete", 8);
            students.Add(student8);
            StudentDataDO student9 = new StudentDataDO(101, "Bhanu", "C#", "Complete", 12);
            students.Add(student9);
            StudentDataDO student10 = new StudentDataDO(102, "Bhavna", "Unittest", "Complete", 6);
            students.Add(student10);

            return students;
        }
    }
}
