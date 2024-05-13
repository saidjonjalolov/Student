//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

using Student.Model;

namespace Student.Broker.Storeage
{
    internal interface IStoreageBroker
    {
        StudenT PrintNameAndEmail(string id);
        List<StudenT> FindStudentByLetter(char letter);
        StudenT FindStudentByName(string name);
        StudenT AddStudent(StudenT student);
    }
}
