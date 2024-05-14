//----------------------------------------
// Great Code Team (c) All rights reserved
//---------------------------------------

using Student.Model;

namespace Student.Service
{
    internal interface IStudentService
    {
        DemoStudent DisplayStudent(int id);
        List<StudenT> CheckoutByLetter(char letter);
        StudenT CheckoutByName(string firstName);
        StudenT InsertStudent (StudenT student);
    }
}
