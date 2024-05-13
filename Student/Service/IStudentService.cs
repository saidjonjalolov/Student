//----------------------------------------
// Great Code Team (c) All rights reserved
//---------------------------------------

using Student.Model;

namespace Student.Service
{
    internal interface IStudentService
    {
        void Print(string firstName, string Email);
        bool LetterCheck(string firstName);
        Student InsertStudent(Student student);
        bool Check(Student student);
    }
}
