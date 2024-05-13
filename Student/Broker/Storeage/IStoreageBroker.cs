//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

using Student.Model;

namespace Student.Broker.Storeage
{
    internal interface IStoreageBroker
    {
        Print PrintNameAndEmail(int id);
        List<StudenT> FindStudentByLetter(char letter);
        StudenT FindStudentById(int id);
        StudenT AddStudent(StudenT student);
    }
}
