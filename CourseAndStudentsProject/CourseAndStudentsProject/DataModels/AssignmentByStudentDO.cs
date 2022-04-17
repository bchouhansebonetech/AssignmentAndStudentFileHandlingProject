using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAndStudentsProject.DataModels
{
    public class AssignmentByStudentDO
    {
        public string assignmentName;
        public int noOfStudents;

        public AssignmentByStudentDO() { }
        public AssignmentByStudentDO(string assignmentName, int noOfStudents)
        {
            this.assignmentName = assignmentName;
            this.noOfStudents = noOfStudents;
        }
    }
}
