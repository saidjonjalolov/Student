//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

using Student.Model;

namespace Student.Broker.Storeage
{
    internal interface IStoreageBroker
    {
        DemoStudent PrintNameAndEmail(int id);
        List<StudenT> FindStudentByLetter(char letter);
        StudenT FindStudentByName(string firstName);
        StudenT AddStudent(StudenT student);
    }
}
