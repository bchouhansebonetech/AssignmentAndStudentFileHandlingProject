using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAndStudentsProject.DataModels
{
    public class AssignmentByStatusDO
    {
        public string assignmentName;
        public int noOfStudents;
        public int totalCompletionDays;
        public string assignmentStatus;

        public AssignmentByStatusDO() { }
        public AssignmentByStatusDO(string assignmentName, int noOfStudents, int totalCompletionDays, string assignmentStatus)
        {
            this.assignmentName = assignmentName;
            this.noOfStudents = noOfStudents;
            this.totalCompletionDays = totalCompletionDays;
            this.assignmentStatus = assignmentStatus;
        }
    }
}
