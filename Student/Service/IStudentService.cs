//----------------------------------------
// Great Code Team (c) All rights reserved
//---------------------------------------

using Student.Model;

namespace Student.Service
{
    internal interface IStudentService
    {
        StudenT Print(int id);
        bool LetterCheck(string firstName);
        StudenT InsertStudent(StudenT student);
        bool Check(StudenT student);
    }
}
