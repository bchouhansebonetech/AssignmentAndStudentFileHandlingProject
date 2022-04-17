using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseAndStudentsProject.DataModels
{
    public class StudentDataDO
    {
        public int studentId;
        public string studentName;
        public string assignmentName;
        public string assignmentStatus;
        public int completionDays;

        public StudentDataDO(int studentId, string studentName, string assignmentName, string assignmentStatus, int completionDays)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.assignmentName = assignmentName;
            this.assignmentStatus = assignmentStatus;
            this.completionDays = completionDays;
        }
    }
}
