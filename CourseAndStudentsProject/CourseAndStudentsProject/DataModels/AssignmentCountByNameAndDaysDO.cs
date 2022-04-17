using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAndStudentsProject.DataModels
{
    public class AssignmentCountByNameAndDaysDO
    {
        public int studentId;
        public string studentName;
        public int assignmentCount;
        public int completionDays;

        public AssignmentCountByNameAndDaysDO() { }
        public AssignmentCountByNameAndDaysDO(int studentId, string studentName, int assignmentCount, int completionDays)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.assignmentCount = assignmentCount;
            this.completionDays = completionDays;
        }
    }
}
