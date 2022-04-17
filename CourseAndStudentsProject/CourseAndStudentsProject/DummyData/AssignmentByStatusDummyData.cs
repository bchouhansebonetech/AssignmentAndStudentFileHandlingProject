using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseAndStudentsProject.DataModels;

namespace CourseAndStudentsProject.DummyData
{
    public class AssignmentByStatusDummyData
    {
        public List<AssignmentByStatusDO> GetAssignmentByStatusDOs()
        {
            List<AssignmentByStatusDO> assignmentByStatusDOs = new List<AssignmentByStatusDO>();
            AssignmentByStatusDO assignmentByStatusDO1 = new AssignmentByStatusDO("Java", 2, 13, "Complete");
            assignmentByStatusDOs.Add(assignmentByStatusDO1);
            AssignmentByStatusDO assignmentByStatusDO2 = new AssignmentByStatusDO("Java", 1, 3, "Progress");
            assignmentByStatusDOs.Add(assignmentByStatusDO2);
            AssignmentByStatusDO assignmentByStatusDO3 = new AssignmentByStatusDO("C#", 2, 17, "Complete");
            assignmentByStatusDOs.Add(assignmentByStatusDO3);
            AssignmentByStatusDO assignmentByStatusDO4 = new AssignmentByStatusDO("Unittest", 1, 0, "NotDone");
            assignmentByStatusDOs.Add(assignmentByStatusDO4);
            AssignmentByStatusDO assignmentByStatusDO5 = new AssignmentByStatusDO("Java", 1, 0, "NotDone");
            assignmentByStatusDOs.Add(assignmentByStatusDO5);
            AssignmentByStatusDO assignmentByStatusDO6 = new AssignmentByStatusDO("Web", 1, 4, "Progress");
            assignmentByStatusDOs.Add(assignmentByStatusDO6);
            AssignmentByStatusDO assignmentByStatusDO7 = new AssignmentByStatusDO("Web", 1, 6, "Complete");
            assignmentByStatusDOs.Add(assignmentByStatusDO7);
            AssignmentByStatusDO assignmentByStatusDO8 = new AssignmentByStatusDO("Unittest", 1, 6, "Complete");
            assignmentByStatusDOs.Add(assignmentByStatusDO8);

            return assignmentByStatusDOs;
        }
    }
}

//Java - 2 - 13 - Complete
//Java - 1 - 3 - Progress
//C# - 2 - 17 - Complete
//Unittest - 1 - 0 - NotDone
//Java - 1 - 0 - NotDone
//Web - 1 - 4 - Progress
//Web - 1 - 6 - Complete
//Unittest - 1 - 6 - Complete
