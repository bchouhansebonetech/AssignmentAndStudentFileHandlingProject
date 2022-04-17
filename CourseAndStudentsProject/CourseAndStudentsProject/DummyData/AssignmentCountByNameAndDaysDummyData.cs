using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseAndStudentsProject.DataModels;

namespace CourseAndStudentsProject.DummyData
{
    public class AssignmentCountByNameAndDaysDummyData
    {
        public List<AssignmentCountByNameAndDaysDO> GetAssignmentCountByNameAndDaysDOs()
        {
            List<AssignmentCountByNameAndDaysDO> assignmentCountByNameAndDaysDOs = new List<AssignmentCountByNameAndDaysDO>();
            AssignmentCountByNameAndDaysDO obj1 = new AssignmentCountByNameAndDaysDO(101, "Bhanu", 3, 17);
            assignmentCountByNameAndDaysDOs.Add(obj1);
            AssignmentCountByNameAndDaysDO obj2 = new AssignmentCountByNameAndDaysDO(102, "Bhavna", 2, 9);
            assignmentCountByNameAndDaysDOs.Add(obj2);
            AssignmentCountByNameAndDaysDO obj3 = new AssignmentCountByNameAndDaysDO(103, "Sajal", 1, 5);
            assignmentCountByNameAndDaysDOs.Add(obj3);
            AssignmentCountByNameAndDaysDO obj4 = new AssignmentCountByNameAndDaysDO(105, "Ritika", 2, 6);
            assignmentCountByNameAndDaysDOs.Add(obj4);
            AssignmentCountByNameAndDaysDO obj5 = new AssignmentCountByNameAndDaysDO(106, "Utkarsh", 2, 12);
            assignmentCountByNameAndDaysDOs.Add(obj5);

            return assignmentCountByNameAndDaysDOs;
        }
    }
}
//101 - Bhanu - 3 - 17
//102 - Bhavna - 2 - 9
//103 - Sajal - 1 - 5
//105 - Ritika - 2 - 6
//106 - Utkarsh - 2 - 12
