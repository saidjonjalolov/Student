//----------------------------------------
// Great Code Team (c) All rights reserved
//---------------------------------------

using Student.Model;

namespace Student.Service
{
    internal interface IStudentService
    {
        Print DisplayStudent(int id);
        List<StudenT> CheckoutByLetter(char letter);
        StudenT CheckoutByName(string firstName);
        bool Check(StudenT student);
    }
}
