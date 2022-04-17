using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseAndStudentsProject.DataModels;

namespace CourseAndStudentsProject.DummyData
{
    public class AssignmentByStudentAscDummyData
    {
        public List<AssignmentByStudentDO> GetAssignmentByStudentAscDOs()
        {
            List<AssignmentByStudentDO> result = new List<AssignmentByStudentDO>();
            AssignmentByStudentDO assignmentByStudentAscDO1 = new AssignmentByStudentDO("Java", 4);
            result.Add(assignmentByStudentAscDO1);
            AssignmentByStudentDO assignmentByStudentAscDO2 = new AssignmentByStudentDO("C#", 2);
            result.Add(assignmentByStudentAscDO2);
            AssignmentByStudentDO assignmentByStudentAscDO3 = new AssignmentByStudentDO("Unittest", 2);
            result.Add(assignmentByStudentAscDO3);
            AssignmentByStudentDO assignmentByStudentAscDO4 = new AssignmentByStudentDO("Web", 2);
            result.Add(assignmentByStudentAscDO4);

            return result;
        }
    }
}
