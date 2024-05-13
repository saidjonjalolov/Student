//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

using Student.Model;

namespace Student.Broker.Storeage
{
    internal interface IStoreageBroker
    {
        DemoStudent PrintNameAndEmail(int id);
        List<Student> FindStudentByLetter(char letter);
        Student FindStudentByName(string name);
        Student AddStudent(Student student);
    }
}
