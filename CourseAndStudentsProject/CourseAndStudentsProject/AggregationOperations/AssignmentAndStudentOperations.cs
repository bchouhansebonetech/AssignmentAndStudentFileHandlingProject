using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseAndStudentsProject.DataModels;

namespace CourseAndStudentsProject.AggregationOperations
{
    public class AssignmentAndStudentOperations
    {
        //Solution-1(dirty solution)
        public List<AssignmentByStatusDO> getAssignmetByStatusDirty(List<StudentDataDO> studentDataDOs)
        {
            Dictionary<string, AssignmentByStatusDO> assignmetByStatus = new Dictionary<string, AssignmentByStatusDO>();
            List<AssignmentByStatusDO> assignmet = new List<AssignmentByStatusDO>();

            foreach (StudentDataDO studentData in studentDataDOs)
            {
                string key = studentData.assignmentName + studentData.assignmentStatus;
                if (assignmetByStatus.ContainsKey(key))
                {
                    assignmetByStatus[key].noOfStudents++;
                    assignmetByStatus[key].totalCompletionDays += studentData.completionDays;
                }
                else
                {
                    assignmetByStatus.Add(key, new AssignmentByStatusDO());
                    assignmetByStatus[key].assignmentName = studentData.assignmentName;
                    assignmetByStatus[key].assignmentStatus = studentData.assignmentStatus;
                    assignmetByStatus[key].noOfStudents = 1;
                    assignmetByStatus[key].totalCompletionDays = studentData.completionDays;
                }
            }

            foreach (AssignmentByStatusDO assignmentByStatusDO in assignmetByStatus.Values)
                assignmet.Add(assignmentByStatusDO);

            return assignmet;
        }

        //Solution-1

        //Write comment on before each logical code line
        public List<AssignmentByStatusDO> getAssignmetByStatus(List<StudentDataDO> studentDataDOs)
        {
            //Here we created dictionary where key is composition of two value (studentDataDO.assignmentName, studentDataDO.assignmentStatus)
            //and value as AssignmentByStatusDO type
            Dictionary<KeyValuePair<string, string>, AssignmentByStatusDO> assignmetByStatus = new Dictionary<KeyValuePair<string, string>, AssignmentByStatusDO>();
            List<AssignmentByStatusDO> assignmet = new List<AssignmentByStatusDO>();

            foreach(StudentDataDO studentDataDO in studentDataDOs)
            {
                //Here we combining two values in one key as keyValue
                var keyValue = new KeyValuePair<string, string>(studentDataDO.assignmentName, studentDataDO.assignmentStatus);
                //Checking is the keyValue is avalaible in dict or not, if available than we need to update only noOfStudents and totalCompletionDays
                //but in case key not available in dict than we first we need to create object of value type and we have to put all
                //the necessary fields in the value object.
                if (assignmetByStatus.ContainsKey(keyValue))
                {
                    assignmetByStatus[keyValue].noOfStudents++;
                    assignmetByStatus[keyValue].totalCompletionDays += studentDataDO.completionDays;
                }
                else
                {
                    assignmetByStatus.Add(keyValue, new AssignmentByStatusDO());
                    assignmetByStatus[keyValue].assignmentName = studentDataDO.assignmentName;
                    assignmetByStatus[keyValue].assignmentStatus = studentDataDO.assignmentStatus;
                    assignmetByStatus[keyValue].noOfStudents = 1;
                    assignmetByStatus[keyValue].totalCompletionDays = studentDataDO.completionDays;
                }
            }

            //Putting the value of dict in list
            foreach (AssignmentByStatusDO assignmentByStatusDO in assignmetByStatus.Values)
                assignmet.Add(assignmentByStatusDO);

            return assignmet;
        }

        //Solution-2
        public List<AssignmentByStudentDO> getAssignmentByStudentCountAsc(List<StudentDataDO> studentDataDOs)
        {
            //Dict of key:string and value:AssignmentByStudentDO type
            Dictionary<string, AssignmentByStudentDO> assignmentAndCount = new Dictionary<string, AssignmentByStudentDO>();
            List<AssignmentByStudentDO> assignment = new List<AssignmentByStudentDO>();

            foreach (StudentDataDO studentDataDO in studentDataDOs)
            {
                //Checking if the key available in the dict or not, if available than we need to update only noOfStudents if not
                //then we need to create AssignmentByStudentDO type object and we need to put all the necessary value in it
                if (assignmentAndCount.ContainsKey(studentDataDO.assignmentName))
                    assignmentAndCount[studentDataDO.assignmentName].noOfStudents++;
                else
                {
                    assignmentAndCount.Add(studentDataDO.assignmentName, new AssignmentByStudentDO());
                    assignmentAndCount[studentDataDO.assignmentName].assignmentName = studentDataDO.assignmentName;
                    assignmentAndCount[studentDataDO.assignmentName].noOfStudents = 1;
                }
            }

            //converting dict in list, the structure of list is list<<
            var myList = assignmentAndCount.ToList();

            myList.Sort((pair1, pair2) => pair2.Value.noOfStudents.CompareTo(pair1.Value.noOfStudents));

            foreach (var pair in myList)
            {
                AssignmentByStudentDO assignmentByStudentAscDO = new AssignmentByStudentDO();
                assignmentByStudentAscDO.assignmentName = pair.Value.assignmentName;
                assignmentByStudentAscDO.noOfStudents = pair.Value.noOfStudents;
                assignment.Add(assignmentByStudentAscDO);
            }
            return assignment;
        }

        //Solution-3
        public List<AssignmentCountByNameAndDaysDO> getStudentsByAssignmentAndDaysCount(List<StudentDataDO> studentDataDOs)
        {
            Dictionary<int, AssignmentCountByNameAndDaysDO> students = new Dictionary<int, AssignmentCountByNameAndDaysDO>();
            List<AssignmentCountByNameAndDaysDO> assignments = new List<AssignmentCountByNameAndDaysDO>();

            foreach (StudentDataDO studentData in studentDataDOs)
            {
                if (students.ContainsKey(studentData.studentId))
                {
                    students[studentData.studentId].assignmentCount++;
                    students[studentData.studentId].completionDays += studentData.completionDays;
                }
                else
                {
                    students.Add(studentData.studentId, new AssignmentCountByNameAndDaysDO());
                    students[studentData.studentId].studentId = studentData.studentId;
                    students[studentData.studentId].studentName = studentData.studentName;
                    students[studentData.studentId].assignmentCount = 1;
                    students[studentData.studentId].completionDays = studentData.completionDays;
                }
            }

            foreach(AssignmentCountByNameAndDaysDO assignment in students.Values)
                assignments.Add(assignment);

            return assignments;
        } 
    }
}
